using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivary._900X500;
using Archivary.Archivary_Components;
using Archivary.BACKEND.BOOK_OPERATIONS;
using Archivary.BACKEND.COMMON_OPERATIONS;
using Archivary.BACKEND.OBJECTS;

namespace Archivary.SUB_FORMS
{
    public partial class FORM_BORROW : Form
    {
        private List<Book> availableBookList;
        private HashSet<string> selectedISBNs = new HashSet<string>();
        private Timer searchTimer, searchUserTimer;
        private bool startSearch = false;
        private int borrowerId = -1;
        private int studentBorrowLimit, teacherBorrowLimit, reserveLimit;
        private bool isStudent;
        public FORM_BORROW()
        {
            InitializeComponent();
        }

        private void FORM_BORROW_Load(object sender, EventArgs e)
        {
            BooksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BooksDataGridView.CellDoubleClick += BooksDataGridView_CellDoubleClick;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            InitializeSearchTimer();
            InitializeSearchUserTimer();
        }

        private void BooksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = BooksDataGridView.Rows[e.RowIndex];
                DataGridViewRow row = new DataGridViewRow();

                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value is Image)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = ResizeImage((Image)selectedRow.Cells[0].Value, 100, 100),
                        SizeMode = PictureBoxSizeMode.AutoSize,
                        Size = new Size(100, 100),
                    };
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    imageCell.Value = pictureBox.Image;
                    row.Height = pictureBox.Height;
                    row.Cells.Add(imageCell);
                    row.Cells[0].Style.Padding = new Padding(10);
                }
                else row.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells[1].Value });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells[2].Value });
                dataGridView1.Rows.Add(row);
                selectedISBNs.Add(selectedRow.Cells[2].Value.ToString());
                BooksDataGridView.Rows.Remove(selectedRow);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                DataGridViewRow row = new DataGridViewRow();

                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value is Image)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = ResizeImage((Image)selectedRow.Cells[0].Value, 100, 100),
                        SizeMode = PictureBoxSizeMode.AutoSize,
                        Size = new Size(100, 100),
                    };
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    imageCell.Value = pictureBox.Image;
                    row.Height = pictureBox.Height;
                    row.Cells.Add(imageCell);
                    row.Cells[0].Style.Padding = new Padding(10);
                }
                else row.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells[1].Value });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells[2].Value });
                BooksDataGridView.Rows.Add(row);
                BooksDataGridView.Sort(BooksDataGridView.Columns[1], ListSortDirection.Ascending);
                dataGridView1.Rows.Remove(selectedRow);
                selectedISBNs.Remove(selectedRow.Cells[2].Value.ToString());
            }
        }

        //
        // COLOR METHODS
        //
        private Color archivaryGreen()
        {
            return Color.FromArgb(37, 211, 102);
        }

        private Color archivaryWhite()
        {
            return Color.FromArgb(244, 244, 244);
        }

        private Color archivaryHoverGray()
        {
            return Color.FromArgb(200, 200, 200);
        }
        
        private void AddBookToBooksDataGridView(Book book)
        {
            DataGridViewRow row = new DataGridViewRow();

            if (!book.BookImage.Equals("NO_IMAGE"))
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = ResizeImage(Image.FromFile(book.BookImage), 100, 100),
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Size = new Size(100, 100),
                };
                DataGridViewImageCell imageCell = new DataGridViewImageCell();
                imageCell.Value = pictureBox.Image;
                row.Height = pictureBox.Height;
                row.Cells.Add(imageCell);
                row.Cells[0].Style.Padding = new Padding(10);
            }
            else row.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = book.BookTitle });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = book.BookISBN });
            BooksDataGridView.Rows.Add(row);
        }

        public void LoadAvailableBooks()
        {
            Setting setting = CommonOperation.GetSettingsFromDatabase();
            studentBorrowLimit = setting.borrowingCapacityStudent;
            teacherBorrowLimit = setting.borrowingCapacityTeacher;
            reserveLimit = setting.reserveLimit;

            availableBookList = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.LoadAvailableBooksFromDatabase("AVAILABLE");
            BooksDataGridView.Rows.Clear();
            foreach (Book book in availableBookList)
            {
                AddBookToBooksDataGridView(book);
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }


        //
        // SEARCH BOOK HOVERS
        //
        private void searchBook_Enter(object sender, EventArgs e)
        {
            if (searchBook.Text == "Search by Book")
            {
                searchBook.Text = "";
                searchBook.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                searchBook.ForeColor = archivaryWhite();
                startSearch = true;
            }
        }

        private void searchBook_Leave(object sender, EventArgs e)
        {
            if (searchBook.Text == "")
            {
                searchBook.Text = "Search by Book";
                searchBook.ForeColor = archivaryHoverGray();
                searchBook.Font = new Font("Montserrat", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
                startSearch = false;
            }
        }

        //
        // SEARCH ID HOVERS
        //
        private void searchID_Enter(object sender, EventArgs e)
        {
            if (searchID.Text == "Search by User ID")
            {
                searchID.Text = "";
                searchID.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                searchID.ForeColor = archivaryWhite();
                startSearch = true;
            }
        }

        private void searchID_Leave(object sender, EventArgs e)
        {
            if (searchID.Text == "")
            {
                searchID.Text = "Search by User ID";
                searchID.ForeColor = archivaryHoverGray();
                searchID.Font = new Font("Montserrat", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
                startSearch = false;
            }
        }

        private void left_TableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            BooksDataGridView.Rows.Clear();
            selectedISBNs.Clear();
            if (searchBook.Text.Equals("Search by Book")) LoadAvailableBooks();
            else SearchBooks(searchBook.Text);
        }

        private void InitializeSearchTimer()
        {
            //Set up a timer with a 500ms delay
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void InitializeSearchUserTimer()
        {
            searchUserTimer = new Timer();
            searchUserTimer.Interval = 500;
            searchUserTimer.Tick += SearchUserTimer_Tick;
        }

        private void SearchUserTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            SearchUser(searchID.Text);
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchUserTimer.Stop();
            SearchBooks(searchBook.Text);
        }

        private bool CheckIfBookAlreadySelected(Book book)
        {
            if (selectedISBNs.Contains(book.BookISBN)) return true;
            return false;
        }

        private void SearchBooks(string query)
        {
            BooksDataGridView.Rows.Clear();
            List<Book> bookList = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.SearchBooks(availableBookList,query);
            foreach(Book book in bookList)
            {
                if (CheckIfBookAlreadySelected(book)) continue;

                AddBookToBooksDataGridView(book);
            }
        }

        private void SearchUser(string query)
        {
            if (query.Contains("S") && query.Length == 10)
            {
                Student user = Archivary.BACKEND.USER_OPERATIONS.UserOperation.GetStudentById(query);
                if (user != null) SetTexts(user);
                borrowerId = user.StudentUserId;
                isStudent = true;
            }
            else if (query.Contains("T") && query.Length == 10)
            {
                Teacher user = Archivary.BACKEND.USER_OPERATIONS.UserOperation.GetTeacherById(query);
                if (user != null) SetTexts(user);
                borrowerId = user.TeacherUserId;
                isStudent = false;
            }
            else
            {
                IDInputLabel.Text = "";
                collegeInputLabel.Text = "";
                nameInputLabel.Text = "User not found.";
                borrowerId = -1;
                isStudent = false;
            }
        }

        private void SetTexts(Student user)
        {
            IDInputLabel.Text = user.StudentId;
            collegeInputLabel.Text = user.StudentDepartment;
            nameInputLabel.Text = $"{user.StudentFirstName} {user.StudentMiddleName}. {user.StudentLastName}";
        }
        private void SetTexts(Teacher user)
        {
            IDInputLabel.Text = user.TeacherId;
            collegeInputLabel.Text = user.TeacherDepartment;
            nameInputLabel.Text = $"{user.TeacherFirstName} {user.TeacherMiddleName}. {user.TeacherLastName}";
        }

        private void searchBook_TextChanged(object sender, EventArgs e)
        {
            if (searchBook != null && searchTimer != null && startSearch)
            {
                searchTimer.Stop();
                searchTimer.Start();
            }
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            HandleCirculationEvent("borrowed_books", "borrow");
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            HandleCirculationEvent("reserved_books", "reserv"); //kulang talaga ng e sa dulo.
        }

        private void HandleCirculationEvent(string type, string message)
        {
            int alreadyBorrowed = BookOperation.CheckCountOfExistingBorrowedReservedBooks(borrowerId, type);
            bool isBelowStudentLimit = isStudent && (dataGridView1.RowCount + alreadyBorrowed) <= studentBorrowLimit;
            bool isBelowTeacherLimit = !isStudent && (dataGridView1.RowCount + alreadyBorrowed) <= teacherBorrowLimit;
            if (isBelowStudentLimit || isBelowTeacherLimit)
            {
                Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.BorrowReserveBook(type, availableBookList, selectedISBNs, borrowerId);
                SuccessBorrowReserve(message);
            }
        }

        private void searchID_TextChanged(object sender, EventArgs e)
        {
            if (searchID != null && searchUserTimer != null && startSearch)
            {
                searchUserTimer.Stop();
                searchUserTimer.Start();
            }
        }

        private void SuccessBorrowReserve(string type)
        {
            dataGridView1.Rows.Clear();
            BooksDataGridView.Rows.Clear();
            LoadAvailableBooks();
            FORM_ALERT alert = new FORM_ALERT(3, $"Successfully {type}ed!", $"Successfully {type}ed books!");
            alert.TopMost = true;
            alert.Show();
        }
    }
}

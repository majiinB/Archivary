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
using Archivary.BACKEND.TIMER;

namespace Archivary.SUB_FORMS
{
    public partial class FORM_BORROW : Form
    {
        private List<Book> availableBookList;
        private List<Book> reversedBookList = new List<Book>();
        private HashSet<string> selectedISBNs = new HashSet<string>(), reservedBooksISBN = new HashSet<string>();
        private Timer searchTimer, searchUserTimer;
        private bool startSearch = false, startUserSearch = false;
        private int borrowerId = -1;
        private int studentBorrowLimit, teacherBorrowLimit, reserveLimit;
        private bool isStudent, isTeacher;
        private object user;
        public FORM_BORROW(object user)
        {
            InitializeComponent();
            this.user = user;
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
                        Image = ResizeImage((Image)selectedRow.Cells[0].Value, 150, 250),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(150, 250),
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
                row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells[3].Value });
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
                        Image = ResizeImage((Image)selectedRow.Cells[0].Value, 150, 250),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(150, 250),
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
                row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells[3].Value });
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

            try
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = ResizeImage(Image.FromFile(book.BookImage), 150, 250),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(150, 250),
                };
                DataGridViewImageCell imageCell = new DataGridViewImageCell();
                imageCell.Value = pictureBox.Image;
                row.Height = pictureBox.Height;
                row.Cells.Add(imageCell);
                row.Cells[0].Style.Padding = new Padding(10);
            }
            catch (System.IO.FileNotFoundException)
            {
                // Handle the case when the file is not found
                PictureBox pictureBox = new PictureBox
                {
                    Image = ResizeImage(Properties.Resources.ArchivaryLogoGreen, 150, 250),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(150, 250),
                };
                DataGridViewImageCell imageCell = new DataGridViewImageCell();
                imageCell.Value = pictureBox.Image;
                row.Height = pictureBox.Height;
                row.Cells.Add(imageCell);
                row.Cells[0].Style.Padding = new Padding(10);
            }

            row.Cells.Add(new DataGridViewTextBoxCell { Value = book.BookTitle });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = book.BookISBN });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = book.BookStatus });
            BooksDataGridView.Rows.Add(row);
        }


        private void LoadAvailableBooks()
        {
            BooksDataGridView.Rows.Clear();
            dataGridView1.Rows.Clear();
            selectedISBNs.Clear();
            reservedBooksISBN.Clear();
            if(availableBookList != null) availableBookList.Clear();
            if (reversedBookList != null) reversedBookList.Clear();
            Setting setting = CommonOperation.GetSettingsFromDatabase();
            studentBorrowLimit = setting.borrowingCapacityStudent;
            teacherBorrowLimit = setting.borrowingCapacityTeacher;
            reserveLimit = setting.reserveLimit;
             
            availableBookList = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.LoadAvailableBooksFromDatabase("AVAILABLE");
            if(borrowerId != - 1) reversedBookList.AddRange(Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.LoadReservedBooksOfUserFromDatabase(borrowerId));
            foreach(Book book in reversedBookList)
            {
                reservedBooksISBN.Add(book.BookISBN);
            }
            reversedBookList.AddRange(availableBookList);
            BooksDataGridView.Rows.Clear();
            foreach (Book book in reversedBookList)
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
                startUserSearch = true;
            }
        }

        private void searchID_Leave(object sender, EventArgs e)
        {
            if (searchID.Text == "")
            {
                searchID.Text = "Search by User ID";
                searchID.ForeColor = archivaryHoverGray();
                searchID.Font = new Font("Montserrat", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
                startUserSearch = false;
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
            searchUserTimer.Stop();
            TimerOpersys.Start();
            SearchUser(searchID.Text);
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            TimerOpersys.Start();
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
            List<Book> bookList = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.SearchBooks(reversedBookList,query);
            foreach(Book book in bookList)
            {
                if (CheckIfBookAlreadySelected(book)) continue;

                AddBookToBooksDataGridView(book);
            }
            TimerOpersys.Stop();
            if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
        }

        private void SearchUser(string query)
        {
            if (query.Contains("S") && query.Length == 10)
            {
                Student user = Archivary.BACKEND.USER_OPERATIONS.UserOperation.GetStudentById(query);
                if (user != null)
                {
                    SetTexts(user);
                    borrowerId = user.StudentUserId;
                }
                isStudent = true;
                isTeacher = false;
                LoadAvailableBooks();
                TimerOpersys.Stop();
            }
            else if (query.Contains("T") && query.Length == 10)
            {
                Teacher user = Archivary.BACKEND.USER_OPERATIONS.UserOperation.GetTeacherById(query);
                if (user != null)
                {
                    SetTexts(user);
                    borrowerId = user.TeacherUserId;
                }
                isStudent = false;
                isTeacher = true;
                LoadAvailableBooks();
                TimerOpersys.Stop();
            }
            else
            {
                IDInputLabel.Text = "";
                collegeInputLabel.Text = "";
                nameInputLabel.Text = "User not found.";
                borrowerId = -1;
                isStudent = false;
                isTeacher = false;
                BooksDataGridView.Rows.Clear();
                TimerOpersys.Start();
            }
            if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
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
            if (Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.CheckIfExistingUnsettledBorrowedBooks(borrowerId))
            {
                FORM_ALERT alert = new FORM_ALERT(1, "CANNOT BORROW", "The user has previous borrowed book transactions that isn't settled yet.");
                alert.TopMost = true;
                alert.Show();
                return;
            }
            HandleCirculationEvent("borrowed_books", "borrow");
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            HandleCirculationEvent("reserved_books", "reserv"); //kulang talaga ng e sa dulo.
        }

        private void HandleCirculationEvent(string type, string message)
        {
            TimerOpersys.Start();
            if(selectedISBNs.Count < 1)
            {
                TimerOpersys.Stop();
                FORM_ALERT alert = new FORM_ALERT(1, "NO SELECTED BOOKS", "Please add books before borrowing/reserving.");
                alert.TopMost = true;
                alert.Show();
                return;
            }

            int alreadyBorrowed = BookOperation.CheckCountOfExistingBorrowedReservedBooks(borrowerId, type);
            bool isBelowStudentLimit = isStudent && !isTeacher && (dataGridView1.RowCount + alreadyBorrowed) <= studentBorrowLimit;
            bool isBelowTeacherLimit = !isStudent && isTeacher && (dataGridView1.RowCount + alreadyBorrowed) <= teacherBorrowLimit;
            if (isBelowStudentLimit || isBelowTeacherLimit)
            {
                if (message.Equals("reserv"))
                {
                    bool hasReservedBookSelected = false;
                    foreach (Book book in reversedBookList)
                    {
                        if (reservedBooksISBN.Contains(book.BookISBN) && selectedISBNs.Contains(book.BookISBN)) hasReservedBookSelected = true;
                        if (hasReservedBookSelected) break;
                    }
                    if (hasReservedBookSelected)
                    {
                        TimerOpersys.Stop();
                        FORM_ALERT alert = new FORM_ALERT(1, "BOOK ALREADY RESERVED", "You can't reserve the reserved book.");
                        alert.TopMost = true;
                        alert.Show();
                        return;
                    }
                }

                if (reservedBooksISBN.Count > 0)
                {  
                    foreach(Book book in reversedBookList)
                    {
                        if (reservedBooksISBN.Contains(book.BookISBN) && selectedISBNs.Contains(book.BookISBN))
                        {
                            reservedBooksISBN.Remove(book.BookISBN);
                            Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.SetReservedBookToBorrowed(book, borrowerId, user is Admin ? ((Admin)user).AdminUserId : ((Employee)user).EmployeeUserId);
                        }
                    }
                }
                Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.BorrowReserveBook(type, reversedBookList, selectedISBNs, borrowerId, user is Admin admin ? admin.AdminUserId : ((Employee)user).EmployeeUserId);
                SuccessBorrowReserve(message);
                TimerOpersys.Stop();
            }
            else
            {
                int borrow = isStudent ? studentBorrowLimit : teacherBorrowLimit;
                string circulation = message.Equals("borrow") ? $"You may only borrow {borrow} books." : $"You many only reserve {reserveLimit} books.";
                TimerOpersys.Stop();
                FORM_ALERT alert = new FORM_ALERT(1, "LIMIT EXCEEDED", circulation);
                alert.TopMost = true;
                alert.Show();
            }
            TimerOpersys.Stop();
            if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
        }

        private void searchID_TextChanged(object sender, EventArgs e)
        {
            if (searchID != null && searchUserTimer != null && startUserSearch)
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

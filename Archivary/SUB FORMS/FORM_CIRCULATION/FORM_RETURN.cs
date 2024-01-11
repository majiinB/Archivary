using Archivary._1500X1000.FORM_CIRCULATION;
using Archivary._900X500;
using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.TIMER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archivary.SUB_FORMS
{
    public partial class FORM_RETURN : Form
    {
        private List<Book> borrowedReservedBooks;
        private List<string> bookOverdueStatus;
        private HashSet<string> selectedISBNs = new HashSet<string>();
        private Timer searchUser;
        private bool startSearch = false, isStudent, isTeacher;
        private int borrowerId = -1;
        private object user;
        private Setting settings;

        public FORM_RETURN(object user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FORM_RETURN_Load(object sender, EventArgs e)
        {
            BooksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InitializeSearchUser();
            settings = Archivary.BACKEND.COMMON_OPERATIONS.CommonOperation.GetSettingsFromDatabase();
        }

        private void InitializeSearchUser()
        {
            searchUser = new Timer();
            searchUser.Interval = 500;
            searchUser.Tick += searchUser_Tick;
        }

        private void searchUser_Tick(object sender, EventArgs e)
        {
            searchUser.Stop();
            TimerOpersys.Start();
            if(borrowedReservedBooks != null) borrowedReservedBooks.Clear();
            SearchUser(searchID.Text);
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
                    isStudent = true;
                    isTeacher = false;
                    borrowedReservedBooks = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.ShowBorrowedBooks(borrowerId);
                    bookOverdueStatus = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.IdentifyOverdueOrNotBooks(borrowerId);
                    LoadBorrowedReservedBooks();
                }
            }
            else if (query.Contains("T") && query.Length == 10)
            {
                Teacher user = Archivary.BACKEND.USER_OPERATIONS.UserOperation.GetTeacherById(query);
                if (user != null)
                {
                    SetTexts(user);
                    borrowerId = user.TeacherUserId;
                    isStudent = false;
                    isTeacher = true;
                    borrowedReservedBooks = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.ShowBorrowedBooks(borrowerId);
                    bookOverdueStatus = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.IdentifyOverdueOrNotBooks(borrowerId);
                    LoadBorrowedReservedBooks();
                }
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
                dataGridView1.Rows.Clear();
                selectedISBNs.Clear();
            }
            TimerOpersys.Stop();
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

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }

        private void AddBookToBooksDataGridView(Book book, int index)
        {
            DataGridViewRow row = new DataGridViewRow();

            try
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
            catch (System.IO.FileNotFoundException)
            {
                // Handle the case when the file is not found
                PictureBox pictureBox = new PictureBox
                {
                    Image = ResizeImage(Properties.Resources.ArchivaryLogoGreen, 100, 100),
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Size = new Size(100, 100),
                };
                DataGridViewImageCell imageCell = new DataGridViewImageCell();
                imageCell.Value = pictureBox.Image;
                row.Height = pictureBox.Height;
                row.Cells.Add(imageCell);
                row.Cells[0].Style.Padding = new Padding(10);
            }

            row.Cells.Add(new DataGridViewTextBoxCell { Value = book.BookTitle });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = book.BookISBN });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = bookOverdueStatus[index] });
            BooksDataGridView.Rows.Add(row);
        }

        private void LoadBorrowedReservedBooks()
        {
            BooksDataGridView.Rows.Clear();
            dataGridView1.Rows.Clear();
            selectedISBNs.Clear();
            for(int i = 0; i < borrowedReservedBooks.Count; i++)
            {
                AddBookToBooksDataGridView(borrowedReservedBooks[i], i);
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (borrowerId == -1) return;
            LoadBorrowedReservedBooks();
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
                row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedRow.Cells[3].Value });
                BooksDataGridView.Rows.Add(row);
                BooksDataGridView.Sort(BooksDataGridView.Columns[1], ListSortDirection.Ascending);
                dataGridView1.Rows.Remove(selectedRow);
                selectedISBNs.Remove(selectedRow.Cells[2].Value.ToString());
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (borrowerId == -1)
            {
                FORM_ALERT alert = new FORM_ALERT(1, "NO USER", "You cannot return books without an user.");
                alert.TopMost = true;
                alert.Show();
                return;
            }
            List<Book> selectedBooks = GetSelectedBooks();
            List<DateTime> date = GetSpecificBookBorrowedDates(selectedBooks);
            bool bookOverdue = false;
            foreach(DateTime time in date)
            {
                TimeSpan difference = DateTime.Now - time;
                double totalDaysRounded = Math.Floor(difference.TotalDays);
                if (totalDaysRounded > settings.borrowingDuration)
                {
                    Console.WriteLine($"{difference.TotalDays} and {settings.borrowingDuration}");
                    bookOverdue = true;
                    break;
                }
            }
            if (bookOverdue)
            {
                using (FORM_POS FormsPos = new FORM_POS(borrowedReservedBooks, selectedBooks, GetDates(selectedBooks), borrowerId, user))
                {
                    FormsPos.ShowInTaskbar = false;
                    FormsPos.BringToFront();
                    DialogResult result = FormsPos.ShowDialog();
                }
                borrowedReservedBooks.Clear();
                bookOverdueStatus.Clear();
                borrowedReservedBooks = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.ShowBorrowedBooks(borrowerId);
                bookOverdueStatus = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.IdentifyOverdueOrNotBooks(borrowerId);
                LoadBorrowedReservedBooks();
                return;
            }
            foreach (Book book in selectedBooks)
            {
                Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.SetBorrowedBookToReturned(book, borrowerId, user is Admin admin ? admin.AdminUserId : ((Employee)user).EmployeeUserId);
            }
            FORM_ALERT success = new FORM_ALERT(3, "BOOKS RETURNED", "Successfully returned books");
            success.TopMost = true;
            success.Show();
            borrowedReservedBooks.Clear();
            bookOverdueStatus.Clear();
            borrowedReservedBooks = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.ShowBorrowedBooks(borrowerId);
            bookOverdueStatus = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.IdentifyOverdueOrNotBooks(borrowerId);
            LoadBorrowedReservedBooks();
        }

        private List<DateTime> GetSpecificBookBorrowedDates(List<Book> selectedBooks)
        {
            List<DateTime> specific = new List<DateTime>();
            foreach (Book book in selectedBooks)
            {
                specific.Add(Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.GetDateFromSpecificBorrowedBooks(borrowerId, book.BookId));
            }
            return specific;
        }

        private List<Book> GetSelectedBooks()
        {
            List<Book> list = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.ShowBorrowedBooks(borrowerId);
            List<Book> selectedBooks = new List<Book>();
            foreach(Book book in list)
            {
                if (selectedISBNs.Contains(book.BookISBN))
                {
                    selectedBooks.Add(book);
                }
            }
            return selectedBooks;
        }

        private List<DateTime> GetDates(List<Book> list)
        {
            List<DateTime> dates = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.GetDateFromBorrowedBooks(borrowerId);
            List<DateTime> selectedDates = new List<DateTime>();
            for(int i = 0; i < list.Count; i++)
            {
                selectedDates.Add(dates[i]);
            }
            return selectedDates;
        }

        private void searchID_TextChanged(object sender, EventArgs e)
        {
            if (searchID != null && searchUser != null && startSearch)
            {
                searchUser.Stop();
                searchUser.Start();
            }
        }
    }
}

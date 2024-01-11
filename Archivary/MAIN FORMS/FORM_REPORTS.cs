using Archivary._900X500;
using Archivary.Archivary_Components;
using Archivary.BACKEND.COMMON_OPERATIONS;
using Archivary.BACKEND.OBJECTS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_REPORTS : Form
    {
        private monthlyOverview monthlyOverview;
        private booksReserved booksReserved;
        private booksBorrowed booksBorrowed;
        private bool isDataLoading = false;
        private bool needMoreData = true;
        private int whatPage = 0;
        private FORM_ALERT alert;


        public FORM_REPORTS()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private void FORM_REPORTS_Load(object sender, EventArgs e)
        {
            LAYOUT_REPORT.Scroll += LAYOUT_REPORT_Scroll;
            LAYOUT_REPORT.MouseWheel += LAYOUT_REPORT_MouseWheel;

            if (!isDataLoading)
            {
                isDataLoading = true;
                LoadReports();
            }
        }

        private void FORM_REPORTS_Resize(object sender, EventArgs e)
        {

            LAYOUT_REPORT.Controls.Clear();
            if (!isDataLoading)
            {
                isDataLoading = true;
                LoadReports();
            }  
        }

        #region BACKEND
        private async Task LoadReports()
        {
            await Task.Run(() =>
            {
                try
                {
                    //NOTE: Mas gusto ko naka await to pero ayaw niya gumana sa laptop ko pag naka await 
                    //Pero try niyo kung naka await

                    LoadMonthlyOverview();
                    BooksBorrowed();
                }
                catch (Exception ex)
                {
                    // Handle or log the exception
                    alert = new FORM_ALERT(1, "REPORT FORM ERROR", $"An error occurred: {ex.Message}");
                    alert.ShowDialog();
                }
            });
        }
        private async Task LoadMonthlyOverview()
        {
            try
            {
                if (LAYOUT_REPORT.InvokeRequired)
                {
                    LAYOUT_REPORT.BeginInvoke(new MethodInvoker(async () => await LoadMonthlyOverview()));
                    return;
                }

                monthlyOverview = new monthlyOverview();
                LAYOUT_REPORT.Controls.Add(monthlyOverview);
                monthlyOverview.Height = LAYOUT_REPORT.ClientSize.Width / 2;
                monthlyOverview.Width = LAYOUT_REPORT.ClientSize.Width - 30;
                monthlyOverview.Margin = new System.Windows.Forms.Padding(0);
                monthlyOverview.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
                //load monthly overview charts
                for (int y = 0; y < CommonOperation.GENRES.Length; y++)
                {
                    if (y < CommonOperation.CATEGORIES.Length)
                    {
                        //Get category in the CATEGORIES array in CommonOperations class
                        string category = CommonOperation.CATEGORIES[y];
                        //Get Book Count asynchronously in the CommonOperations class
                        int categoryCount = await CommonOperation.CountBooksByCategoryAsync(category);
                        //Add the information as a point in the monthly overview category copies chart
                        monthlyOverview.CategoryCopies.Points.AddXY(category, categoryCount);
                    }
                    string genre = CommonOperation.GENRES[y];
                    int genreCount = await CommonOperation.CountBooksByGenreAsync(genre);
                    monthlyOverview.GenreCopies.Points.AddXY(genre, genreCount);
                }
                //load monthly overview book circulation info
                for (int i = 0; i < CommonOperation.MONTHS.Length; i++)
                {
                    //Circulation chart info
                    string month = CommonOperation.MONTHS[i]; //Get months in commonoperations class MONTHS array
                                                              //Get info from database
                    int borroweBooksCount = await CommonOperation.GetBorrowedBooksCountForMonthAsync(i + 1);
                    int reservedBooksCount = await CommonOperation.GetReservedBooksCountForMonthAsync(i + 1);
                    int returnedBooksCount = await CommonOperation.GetReturnedBooksCountForMonthAsync(i + 1);
                    //Insert info to make a point in the monthly overview chart
                    monthlyOverview.BooksLoaned.Points.AddXY(month, borroweBooksCount);
                    monthlyOverview.BooksReserved.Points.AddXY(month, reservedBooksCount);
                    monthlyOverview.BooksReturned.Points.AddXY(month, returnedBooksCount);
                }
                isDataLoading = false;
            }
            catch(Exception ex)
            {
                alert = new FORM_ALERT(1, "REPORT FORM ERROR", $"An Error Has Occured in LoadMonthlyOverview {ex.Message}");
                alert.ShowDialog();
            }
        }
        private async Task BooksBorrowed()
        {
            if (LAYOUT_REPORT.InvokeRequired)
            {
                LAYOUT_REPORT.BeginInvoke(new MethodInvoker(async () => await BooksBorrowed()));
                return;
            }


            booksBorrowed = new booksBorrowed();
            LAYOUT_REPORT.Controls.Add(booksBorrowed);
            booksBorrowed.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksBorrowed.Height = LAYOUT_REPORT.ClientSize.Width / 2;
            booksBorrowed.Margin = new System.Windows.Forms.Padding(0);
            booksBorrowed.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);

            AddBorrowedBooksInDataGridView(booksBorrowed);
            isDataLoading = false;
            needMoreData = true;
            //whatPage = 1;
        }

        private void AddBorrowedBooksInDataGridView(booksBorrowed booksBorrowed)
        {
            List<BookReportsInfo> reportList = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.SetInfoFromBorrowedReports();
            foreach(BookReportsInfo report in reportList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.userId});
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.isbn });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.title });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.author });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = CommonOperation.FormatDateTime(report.obtainedDate) });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = CommonOperation.FormatDateTime(report.dueDate) });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.status });
                booksBorrowed.BorrowDataGridView.Rows.Add(row);
            }
        }

        private async Task BooksReserved()
        {
            if (LAYOUT_REPORT.InvokeRequired)
            {
                LAYOUT_REPORT.BeginInvoke(new MethodInvoker(async() => await BooksReserved()));
                return;
            }

            booksReserved = new booksReserved();
            LAYOUT_REPORT.Controls.Add(booksReserved);
            booksReserved.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksReserved.Height = LAYOUT_REPORT.ClientSize.Width / 2;
            booksReserved.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            booksReserved.Margin = new System.Windows.Forms.Padding(0);

            AddReservedBooksInDataGridView(booksReserved);
            isDataLoading = false;
            needMoreData = false;
            //whatPage = 2;
        }

        private void AddReservedBooksInDataGridView(booksReserved booksReserved)
        {
            List<BookReportsInfo> reportList = Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.SetInfoFromReservedReports();
            foreach (BookReportsInfo report in reportList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.userId });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.isbn });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.title });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.author });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = CommonOperation.FormatDateTime(report.obtainedDate)});
                row.Cells.Add(new DataGridViewTextBoxCell { Value = CommonOperation.FormatDateTime(report.dueDate)});
                row.Cells.Add(new DataGridViewTextBoxCell { Value = report.status });
                booksReserved.ReserveDataGridView.Rows.Add(row);
            }
        }

        //Scroll events to load other data
        private void LAYOUT_REPORT_Scroll(object sender, ScrollEventArgs e)
        {
            CheckIfAtBottom();
        }
        private void LAYOUT_REPORT_MouseWheel(object sender, MouseEventArgs e)
        {
            CheckIfAtBottom();
        }
        private void CheckIfAtBottom()
        {
            FlowLayoutPanel reportlist = this.LAYOUT_REPORT;
            int visibleHeight = LAYOUT_REPORT.ClientSize.Height;
            int totalHeigth = LAYOUT_REPORT.VerticalScroll.Value + visibleHeight;

            //Checks if total height is greater than or equal to the veritcal scroll value minus the height of the 4 bookinfos
            if (totalHeigth >= (LAYOUT_REPORT.VerticalScroll.Maximum - (monthlyOverview.Height / 10)) && LAYOUT_REPORT.VerticalScroll.Visible)
            {
                if (needMoreData && !isDataLoading) //We didnt call filter books method because we dont want to reset the value
                {
                    isDataLoading = true;
                    BooksReserved();
                }
            }
        }
        #endregion
    }
}

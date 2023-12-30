using Archivary.Archivary_Components;
using Archivary.BACKEND.COMMON_OPERATIONS;
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

        private async Task LoadReports()
        {
            await Task.Run(async() =>
            {
                try
                {
                    Task.Delay(500).Wait();
                    await LoadMonthlyOverview();
                    await BooksBorrowed();
                }
                catch (Exception ex)
                {
                    // Handle or log the exception
                    MessageBox.Show($"An error occurred: {ex.Message}");
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
                monthlyOverview.Width = LAYOUT_REPORT.ClientSize.Width - 30;
                monthlyOverview.Height = LAYOUT_REPORT.ClientSize.Width / 2;

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
                MessageBox.Show($"An Error Has Occured in LoadMonthlyOverview {ex.Message}");
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
            int n = 100;
            for (int i = 1; i <= n; i++)
            {
                booksBorrowed.BorrowDataGridView.Rows.Add("hh" + i, "ddadsgdffffgdsfgsdgdfgdfgv", "ss" + (i * 7), "ss", "aa", "aa", "Overdue");
                booksBorrowed.BorrowDataGridView.Rows.Add("hh" + i, "ddadsgdffffgdsfgsdgdfgdfgv", "ss" + (i * 7), "ss", "aa", "aa", "Not Overdue");
            }
            isDataLoading = false;
            needMoreData = true;
            //whatPage = 1;
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

            int n = 100;
            for (int i = 1; i <= n; i++)
            {
                booksReserved.ReserveDataGridView.Rows.Add("hh" + i, "ddadsgdffffgdsfgsdgdfgdfgv", "ss" + (i * 7), "ss", "aa", "aa", "Overdue");
                booksReserved.ReserveDataGridView.Rows.Add("hh" + i, "ddadsgdffffgdsfgsdgdfgdfgv", "ss" + (i * 7), "ss", "aa", "aa", "Not Overdue");
            }
            isDataLoading = false;
            needMoreData = false;
            //whatPage = 2;
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
    }
}

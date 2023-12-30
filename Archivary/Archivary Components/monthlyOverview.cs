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
using System.Windows.Forms.DataVisualization.Charting;

namespace Archivary.Archivary_Components
{
    public partial class monthlyOverview : UserControl
    {
        private int userCount = 0;
        private int reservedCount = 0;
        private int loanedCount = 0;
        private int returnedCount = 0;
        private int copiesCount = 0;
        public monthlyOverview()
        {
            InitializeComponent();
        }
        private async void monthlyOverview_Load(object sender, EventArgs e)
        {
            try
            {
                userCount = await CommonOperation.GetUserCountAsync();
                reservedCount = await CommonOperation.GetReservedBooksCountForCurrentMonthAsync();
                loanedCount = await CommonOperation.GetBorrowedBooksCountForCurrentMonthAsync();
                returnedCount = await CommonOperation.GetReturnedBooksCountForCurrentMonthAsync();
                copiesCount = await CommonOperation.GetBookCountAsync();

                // Update UI elements
                monthlyUserCountLabel.Text = userCount.ToString();
                monthlyReservedCountLabel.Text = reservedCount.ToString();
                monthlyLoanedCountLabel.Text = loanedCount.ToString();
                monthlyReturnedCountLabel.Text = returnedCount.ToString();
                monthlyCopiesCountLabel.Text = copiesCount.ToString();
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region Properties

        private string _monthlyUserCount;
        private string _monthlyReservedCount;
        private string _monthlyLoanedCount;
        private string _monthlyReturnedCount;
        private string _monthlyCopiesCount;

        public string UserCount
        {
            get { return _monthlyUserCount; }
            set { _monthlyUserCount = value; monthlyUserCountLabel.Text = value; }
        }
        public string ReservedCount
        {
            get { return _monthlyReservedCount; }
            set { _monthlyReservedCount = value; monthlyReservedCountLabel.Text = value; }
        }
        public string LoanedCount
        {
            get { return _monthlyLoanedCount; }
            set { _monthlyLoanedCount = value; monthlyLoanedCountLabel.Text = value; }
        }
        public string ReturnedCount
        {
            get { return _monthlyReturnedCount; }
            set { _monthlyReturnedCount = value; monthlyReturnedCountLabel.Text = value; }
        }
        public string CopiesCount
        {
            get { return _monthlyCopiesCount; }
            set { _monthlyCopiesCount = value; monthlyCopiesCountLabel.Text = value; }
        }

        //
        // comparison line graph 
        //
        public Series BooksLoaned
        {
            get { return monthlyComparisonChart.Series["Books Loaned"]; }
        }

        public Series BooksReserved
        {
            get { return monthlyComparisonChart.Series["Books Reserved"]; }
        }

        public Series BooksReturned
        {
            get { return monthlyComparisonChart.Series["Books Returned"]; }
        }

        //
        //category pie chart 
        //
        public Series CategoryCopies
        {
            get { return categoryCopiesChart.Series["categorySeries"]; }
        }

        //
        //genre pie chart 
        //
        public Series GenreCopies
        {
            get { return genreCopiesChart.Series["genreSeries"]; }
        }

        #endregion
    }
}

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
        public monthlyOverview()
        {
            InitializeComponent();
        }
        private void monthlyOverview_Load(object sender, EventArgs e)
        {
            monthlyUserCountLabel.Text = CommonOperation.GetUserCount().ToString();
            monthlyReservedCountLabel.Text = CommonOperation.GetReservedBooksCountForCurrentMonth().ToString();
            monthlyLoanedCountLabel.Text = CommonOperation.GetBorrowedBooksCountForCurrentMonth().ToString();
            monthlyReturnedCountLabel.Text = CommonOperation.GetReturnedBooksCountForCurrentMonth().ToString();
            monthlyCopiesCountLabel.Text = CommonOperation.GetBookCount().ToString();
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

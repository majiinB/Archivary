using Archivary.Archivary_Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_REPORTS : Form
    {
/*        private monthlyOverview monthlyOverview;
        private booksReserved booksReserved;
        private booksBorrowed booksBorrowed;*/

        public FORM_REPORTS()
        {
            InitializeComponent();
        }

        private void FORM_REPORTS_Load(object sender, EventArgs e)
        {
/*            monthlyOverview = new monthlyOverview();
            booksReserved = new booksReserved();
            booksBorrowed = new booksBorrowed();

            monthlyOverview.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksReserved.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksBorrowed.Width = LAYOUT_REPORT.ClientSize.Width - 30;

            monthlyOverview.Height = LAYOUT_REPORT.ClientSize.Width / 2;
            booksReserved.Height = LAYOUT_REPORT.ClientSize.Width / 2;
            booksBorrowed.Height = LAYOUT_REPORT.ClientSize.Width / 2;
            booksReserved.Padding = new Padding(0,0,0,20);
            LAYOUT_REPORT.Controls.Add(monthlyOverview);
            this.LAYOUT_REPORT.SetFlowBreak(this.monthlyOverview, true); 
            LAYOUT_REPORT.Controls.Add(booksBorrowed);
            this.LAYOUT_REPORT.SetFlowBreak(this.booksBorrowed, true);
            LAYOUT_REPORT.Controls.Add(booksReserved);*/
        }

        private void FORM_REPORTS_Resize(object sender, EventArgs e)
        {
/*            monthlyOverview.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksReserved.Width = LAYOUT_REPORT.ClientSize.Width - 30;
            booksBorrowed.Width = LAYOUT_REPORT.ClientSize.Width - 30;


            monthlyOverview.Height = LAYOUT_REPORT.ClientSize.Width / 2;
            booksReserved.Height = LAYOUT_REPORT.ClientSize.Width / 2;
            booksBorrowed.Height = LAYOUT_REPORT.ClientSize.Width / 2;*/
        }
    }
}

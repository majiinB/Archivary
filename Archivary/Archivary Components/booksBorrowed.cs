using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary.Archivary_Components
{
    public partial class booksBorrowed : UserControl
    {
        public booksBorrowed()
        {
            InitializeComponent();

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

        private Color archivaryBlack()
        {
            return Color.FromArgb(20, 18, 18);
        }

        private Color archivaryGray()
        {
            return Color.FromArgb(40, 40, 40);
        }

        private Color archivaryCream()
        {
            return Color.FromArgb(208, 190, 143);
        }

        private Color archivaryRed()
        {
            return Color.FromArgb(227, 25, 55);
        }

        public DataGridView BorrowDataGridView
        {
            get
            {
                return borrowDataGridView;

            }
        }
        //
        //change forecolor depending on status (d toh efficient)
        //
        private void borrowDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*foreach (DataGridViewRow row in borrowDataGridView.Rows)
            {
                string status = Convert.ToString(row.Cells[6].Value).ToLower();
                if (status == "overdue") row.Cells[6].Style.ForeColor = archivaryRed();
                else if (status == "not overdue") row.Cells[6].Style.ForeColor = archivaryGreen();
            }*/
        }
        //
        //change forecolor depending on status (d ko sure if efficient toh BWHAHAHA)
        //
        private void borrowDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for(int i = e.RowIndex; i <= e.RowIndex + e.RowCount - 1; i++)
            {
                var row = borrowDataGridView.Rows[i];
                string status = Convert.ToString(row.Cells[6].Value).ToLower();
                if (status == null) continue;

               if (status == "Overdue") row.Cells[6].Style.ForeColor = archivaryRed();
               else if (status == "Not Overdue" || status == "Returned") row.Cells[6].Style.ForeColor = archivaryGreen();

            }
        }

    }
}

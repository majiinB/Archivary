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
    public partial class booksReserved : UserControl
    {
        public booksReserved()
        {
            InitializeComponent();

        }
        //
        // COLOR METHODS
        //
       
        private Color archivaryCream()
        {
            return Color.FromArgb(208, 190, 143);
        }

        private Color archivaryRed()
        {
            return Color.FromArgb(227, 25, 55);
        }

        //
        //change forecolor depending on status (d toh efficient)
        //
        private void reserveDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*foreach (DataGridViewRow row in reserveDataGridView.Rows)
           {
               string status = Convert.ToString(row.Cells[6].Value).ToLower();
               if (status == "overdue") row.Cells[6].Style.ForeColor = archivaryRed();
               else if (status == "not overdue") row.Cells[6].Style.ForeColor = archivaryCream();
           }*/
        }

        //
        //change forecolor depending on status (d ko sure if efficient toh BWHAHAHA)
        //

        private void reserveDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i <= e.RowIndex + e.RowCount - 1; i++)
            {
                var row = reserveDataGridView.Rows[i];
                string status = Convert.ToString(row.Cells[6].Value).ToLower();
                if (status == null) continue;


                if (status == "late") row.Cells[6].Style.ForeColor = archivaryRed();
                else if (status == "on going") row.Cells[6].Style.ForeColor = archivaryCream();

            }
        }
        public DataGridView ReserveDataGridView
        {
            get { return reserveDataGridView; }
        }
    }
}

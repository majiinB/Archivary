using Archivary._1500X1000.FORM_CIRCULATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archivary.SUB_FORMS
{
    public partial class FORM_RETURN : Form
    {
        public FORM_RETURN()
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
            }
        }

        private void searchID_Leave(object sender, EventArgs e)
        {
            if (searchID.Text == "")
            {
                searchID.Text = "Search by User ID";
                searchID.ForeColor = archivaryHoverGray();
                searchID.Font = new Font("Montserrat", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            using (FORM_POS FormsPos = new FORM_POS())
            {
                FormsPos.ShowInTaskbar = false;
                FormsPos.BringToFront();
                DialogResult result = FormsPos.ShowDialog();
            }
        }
    }
}

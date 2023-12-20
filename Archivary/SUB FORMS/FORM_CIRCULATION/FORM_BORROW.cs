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
    public partial class FORM_BORROW : Form
    {
        public FORM_BORROW()
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
        // SEARCH BOOK HOVERS
        //
        private void searchBook_Enter(object sender, EventArgs e)
        {
            if (searchBook.Text == "Search by Book")
            {
                searchBook.Text = "";
                searchBook.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                searchBook.ForeColor = archivaryWhite();
            }
        }

        private void searchBook_Leave(object sender, EventArgs e)
        {
            if (searchBook.Text == "")
            {
                searchBook.Text = "Search Book";
                searchBook.ForeColor = archivaryHoverGray();
                searchBook.Font = new Font("Montserrat", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
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
    }
}

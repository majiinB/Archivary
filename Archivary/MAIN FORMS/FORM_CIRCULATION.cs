using Archivary.SUB_FORMS;
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
    public partial class FORM_CIRCULATION : Form
    {
        private FORM_RETURN FormsReturn = new FORM_RETURN();
        private FORM_BORROW FormsBorrow = new FORM_BORROW();
        private FORM_SIDEBAR FormsSidebar;

        public FORM_CIRCULATION(FORM_SIDEBAR FormsSidebar)
        {
            InitializeComponent();
            this.FormsSidebar = FormsSidebar;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            FormsBorrow.TopLevel = false;
            FormsSidebar.PANEL_CONTENTS.Controls.Add(FormsBorrow);
            FormsBorrow.Dock = DockStyle.Fill;
            FormsBorrow.BringToFront();
            FormsBorrow.Show();
            FormsBorrow.LoadAvailableBooks();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormsReturn.TopLevel = false;
            FormsSidebar.PANEL_CONTENTS.Controls.Add(FormsReturn);
            FormsReturn.Dock = DockStyle.Fill;
            FormsReturn.BringToFront();
            FormsReturn.Show();
        }
    }
}

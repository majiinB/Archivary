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
        private FORM_RETURN FormsReturn;
        private FORM_BORROW FormsBorrow;
        private FORM_SIDEBAR FormsSidebar;

        public FORM_CIRCULATION(FORM_SIDEBAR FormsSidebar, object user)
        {
            InitializeComponent();
            this.FormsSidebar = FormsSidebar;
            FormsReturn = new FORM_RETURN(user);
            FormsBorrow = new FORM_BORROW(user);

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            FormsBorrow.TopLevel = false;
            FormsSidebar.PANEL_CONTENTS.Controls.Add(FormsBorrow);
            FormsBorrow.Dock = DockStyle.Fill;
            FormsBorrow.BringToFront();
            FormsBorrow.Show();
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

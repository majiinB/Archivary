using Archivary.PARENT_FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary
{
    public partial class FORM_SIDEBAR1 : Form
    {
        private FORM_ROOT FormsRoot;
        private FORM_LOGIN FormsLogin;
        private FORM_LIBRARY FormsLibrary = new FORM_LIBRARY();

        private bool isToggled = false;

        public FORM_SIDEBAR1(FORM_ROOT showFormsRoot)
        {
            InitializeComponent();
            FormsRoot = showFormsRoot;
        }

        private void sidebarButton_Click(object sender, EventArgs e)
        {
            isToggled = !isToggled;
            collapseSidebar();
        }

        private void collapseSidebar()
        {
            if (isToggled)
            {
                PANEL_SIDEBAR.Size = new System.Drawing.Size(220, 540);
            }
            else
            {
                PANEL_SIDEBAR.Size = new System.Drawing.Size(60, 540);
            }
        }
    }
}

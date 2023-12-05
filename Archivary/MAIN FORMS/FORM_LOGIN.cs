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
    public partial class FORM_LOGIN : Form
    {
        private FORM_ROOT FormsRoot;


        public FORM_LOGIN(FORM_ROOT formsRoot)
        {
            InitializeComponent();
            FormsRoot = formsRoot;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormsRoot.loadParentForm(new FORM_SIDEBAR(FormsRoot));
            FormsRoot.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormsRoot.loadParentForm(new FORM_TITLE(FormsRoot));
        }
    }
}

using Archivary.PARENT_FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary
{
    public partial class FORM_TITLE : Form
    {
        private FORM_ROOT FormsRoot;
        private FORM_LOGIN FormsLogin;

        private readonly Size minimumSize = new Size(960, 650);

        public FORM_TITLE(FORM_ROOT showFormsRoot)
        {
            InitializeComponent();
            FormsRoot = showFormsRoot;

            this.Size = new Size(960, 650);
            this.MinimumSize = minimumSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goLoginButton_Click(object sender, EventArgs e)
        {
            FormsRoot.loadParentForm(new FORM_LOGIN(FormsRoot));
            this.Close();
        }
    }
}

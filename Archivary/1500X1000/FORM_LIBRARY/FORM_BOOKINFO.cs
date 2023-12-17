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

namespace Archivary._1500X1000.FORM_LIBRARY
{
    public partial class FORM_BOOKINFO : Form
    {

        private FORM_BOOKEDIT FormsBookEdit;

        public FORM_BOOKINFO()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void editInfoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            using (FormsBookEdit = new FORM_BOOKEDIT())
            {
                this.Close();
                FormsBookEdit.ShowDialog();
            }
                
        }
    }
}

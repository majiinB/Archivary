using Archivary._900X500;
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
    public partial class FORM_BOOKADD : Form
    {


        public FORM_BOOKADD()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadExcelButton_Click(object sender, EventArgs e)
        {
            FORM_UPLOAD upload = new FORM_UPLOAD(1);
            upload.ShowDialog();
        }
    }
}

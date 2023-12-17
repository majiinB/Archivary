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
    public partial class FORM_BOOKEDIT : Form
    {

        private FORM_BOOKINFO FormsBookInfo = new FORM_BOOKINFO();

        public FORM_BOOKEDIT()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            /*using (FormsBookInfo = new FORM_BOOKINFO())
            {
                FormsBookInfo.ShowDialog();
            }*/

                this.Close();
        }
    }
}

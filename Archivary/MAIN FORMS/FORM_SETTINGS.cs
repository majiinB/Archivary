using Archivary._900X500;
using RoundedCorners;
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
    public partial class FORM_SETTINGS : Form
    {
        private int panelWidth;

        public FORM_SETTINGS()
        {
            InitializeComponent();
        }

        private void FORM_SETTINGS_Load(object sender, EventArgs e)
        {

        }
       
        private void FORM_SETTINGS_Resize(object sender, EventArgs e)
        {

        }

        private void LoadPanels()
        {
            panelWidth = (PANEL_CONTAINER.ClientSize.Width / 1) - 10; //( -20 <-- this is padding size)

        }

        private void userId_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            using (FORM_PASSWORD pass = new FORM_PASSWORD())
            {
                pass.ShowInTaskbar = false;
                DialogResult result = pass.ShowDialog();
            }
        }
        private void EnableAllTextBoxes(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is RoundedTextBox)
                {
                    RoundedTextBox textBox = (RoundedTextBox)control;
                    textBox.Enabled = true;
                }

                if (control.HasChildren)
                {
                    EnableAllTextBoxes(control.Controls); 
                }
            }
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            EnableAllTextBoxes(this.Controls);
            changePassButton.Enabled = true;
            uploadImageButton.Enabled = true;

        }
    }
}

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
    public partial class FORM_LIBRARY : Form
    {
        private int buttonWidth;

        public FORM_LIBRARY()
        {
            InitializeComponent();
        }

        private void FORM_LIBRARY_Load(object sender, EventArgs e)
        {
            CreateButtons();
        }

        private void FORM_LIBRARY_Resize(object sender, EventArgs e)
        {
            CreateButtons();
        }

        private void CreateButtons()
        {
            flowLayoutPanel1.Controls.Clear(); // Clear existing buttons

            int maxButtons = 5;
            int total = 0;

            // Calculate the button width based on the FlowLayoutPanel size
            buttonWidth = (flowLayoutPanel1.ClientSize.Width / 2) - SystemInformation.VerticalScrollBarWidth;

            for (int i = 1; i <= maxButtons; i++)
            {
                Button buttonize = new Button();
                buttonize.Text = "Button " + i;
                buttonize.Width = buttonWidth;
                buttonize.Height = 200;
                buttonize.BackColor = Color.Gainsboro;
                flowLayoutPanel1.Controls.Add(buttonize);
                total += i;
            }

            // Set AutoScroll based on the number of buttons
            flowLayoutPanel1.AutoScroll = flowLayoutPanel1.Controls.Count > 6;
        }
    }
}

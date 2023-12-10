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
        private int buttonWidth1;
        private int controlPadding;
        private Button buttonize;
        private int maxButtons = 5;

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
            libraryList.Controls.Clear(); // Clear existing controls

            int maxButtons = 7;
            int total = 0;

            buttonWidth = ((libraryList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth) / 2) - 6;
            buttonWidth1 = ((libraryList.ClientSize.Width) / 2) - 6;

            // Adjust padding to provide space at the bottom
            libraryList.Padding = new Padding(0, 0, 0, 10);

            for (int i = 1; i <= maxButtons; i++)
            {
                buttonize = new Button();
                buttonize.Text = "Button " + i;
                buttonize.Height = 200;
                buttonize.BackColor = Color.Gainsboro;
                libraryList.Controls.Add(buttonize);
                total += i;
                if (maxButtons <= 4)
                {
                    buttonize.Width = buttonWidth1;
                }
                else if (maxButtons > 4)
                {
                    buttonize.Width = buttonWidth;
                }
            }
        }

    }
}

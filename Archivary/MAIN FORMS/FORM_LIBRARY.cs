using CustomDropdown;
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

        //
        // COLOR METHODS
        //
        private Color archivaryGreen()
        {
            return Color.FromArgb(37, 211, 102);
        }

        private Color archivaryWhite()
        {
            return Color.FromArgb(244, 244, 244);
        }

        private Color archivaryBlack()
        {
            return Color.FromArgb(20, 18, 18);
        }

        private Color archivaryGray()
        {
            return Color.FromArgb(40, 40, 40);
        }

        private Color archivaryCream()
        {
            return Color.FromArgb(208, 190, 143);
        }

        //MAIN
        public FORM_LIBRARY()
        {
            InitializeComponent();
        }

        private void FORM_LIBRARY_Load(object sender, EventArgs e)
        {
            CreateButtons();
            dropdownProperties();
        }

        private void FORM_LIBRARY_Resize(object sender, EventArgs e)
        {
            CreateButtons();
        }

        private void CreateButtons()
        {
            libraryList.Controls.Clear(); // Clear existing controls

            int maxButtons = 3;
            int total = 0;

            buttonWidth = ((libraryList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth) / 2) - 20; //( -20 <-- this is padding size)
            buttonWidth1 = (libraryList.ClientSize.Width / 2) - 20; //( -20 <-- this is padding size)

            // Adjust padding to provide space at the bottom
            libraryList.Padding = new Padding(0, 0, 0, 10);

            for (int i = 1; i <= maxButtons; i++)
            {
                buttonize = new Button();
                buttonize.Text = "Button " + i;
                buttonize.Height = 200;
                buttonize.Margin = new Padding(10);
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

        private void dropdownProperties()
        {
            dropdownMenu1.IsMainMenu = true;
            dropdownMenu1.PrimaryColor = archivaryGreen();
        }

        private void openDropdownMenu(DropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            /*dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
                => DropdownMenu.VisibleChanged(sender2, ev, control));*/
            dropdownMenu.Show(control, control.Width - dropdownMenu.Width, control.Height);
        }

    }
}

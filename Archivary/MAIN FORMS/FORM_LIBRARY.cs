using Archivary.Archivary_Components;
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
        private Button buttonize;
        private bookDetails bookInfo;

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

        private Color archivaryHoverGray()
        {
            return Color.FromArgb(200, 200, 200);
        }

        //MAIN
        public FORM_LIBRARY()
        {
            InitializeComponent();
        }

        private void FORM_LIBRARY_Load(object sender, EventArgs e)
        {
            CreateButtons1();
            dropdownProperties();
        }

        private void FORM_LIBRARY_Resize(object sender, EventArgs e)
        {
            CreateButtons1();
        }

        private void CreateButtons1()
        {
            libraryList.Controls.Clear(); // Clear existing controls

            int maxButtons = 7;
            int total = 0;

            buttonWidth = ((libraryList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth) / 2) - 20; //( -20 <-- this is padding size)
            buttonWidth1 = (libraryList.ClientSize.Width / 2) - 20; //( -20 <-- this is padding size)

            // Adjust padding to provide space at the bottom
            libraryList.Padding = new Padding(0, 0, 0, 10);

            for (int i = 1; i <= maxButtons; i++)
            {
                bookInfo = new bookDetails();
                bookInfo.Text = "Button " + i;
                bookInfo.Height = 200;
                bookInfo.Margin = new Padding(10);
                libraryList.Controls.Add(bookInfo);
                total += i;
                if (maxButtons <= 4)
                {
                    bookInfo.Width = buttonWidth1;
                }
                else if (maxButtons > 4)
                {
                    bookInfo.Width = buttonWidth;
                }
            }
        }

        private void CreateButtons()
        {
            libraryList.Controls.Clear(); // Clear existing controls

            int maxButtons = 20;
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
            filterDropdown.IsMainMenu = true;
            filterDropdown.PrimaryColor = archivaryGreen();
        }

        private void openDropdownMenu(DropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            //dropdownMenu.Show(control, control.Width - dropdownMenu.Width, control.Height);
            dropdownMenu.Show(control, control.Width - control.Width, control.Height);
        }

        private void filterSearchButton_Click(object sender, EventArgs e)
        {
            openDropdownMenu(filterDropdown, sender);
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == "Search Book")
            {
                searchBar.Text = "";
                searchBar.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
                searchBar.ForeColor = archivaryWhite();
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                searchBar.Text = "Search Book";
                searchBar.ForeColor = archivaryHoverGray();
                searchBar.Font = new Font("Montserrat Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
        }

        //
        // DROPDOWN EVENTS
        //
        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "All";
        }

        private void bookNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Book Name";
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Author";
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Category";
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Genre";
        }

        private void ISBNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "ISBN";
        }

    }
}

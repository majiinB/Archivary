using Archivary._1500X1000.FORM_LIBRARY;
using Archivary.Archivary_Components;
using Archivary.BACKEND.BOOK_OPERATIONS;
using Archivary.BACKEND.OBJECTS;
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
        private FORM_BOOKADD FormsBookAdd;
        private int start = 0;
        private int max = 0;
        private int pagesToAdd = 10;
        private Dictionary<int, Book> booksDictionary;
        private List<int> keys;
        private bool isDataLoading = false;

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
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        private async void FORM_LIBRARY_Load(object sender, EventArgs e)
        {
            dropdownProperties();
            //Subscribe to both
            libraryList.Scroll += libraryList_Scroll;
            libraryList.MouseWheel += libraryList_MouseWheel;

            //load first list
            libraryList.Controls.Clear();
            booksDictionary = BACKEND.BOOK_OPERATIONS.BookOperation.LoadBooksFromDatabase();
            keys = booksDictionary.Keys.ToList();
            max = booksDictionary.Count();
            {
                isDataLoading = true;
                await LoadListAsync();
            }
        }

        private async void FORM_LIBRARY_Resize(object sender, EventArgs e)
        {
            start = 0;
            pagesToAdd = 10;
            libraryList.Controls.Clear();

            if (!isDataLoading)
            {
                isDataLoading = true;
                await LoadListAsync();
            }
        }

        private async Task LoadListAsync()
        {

            await Task.Run(() =>
            {
                if (start == 0) Task.Delay(500).Wait();
                buttonWidth = ((libraryList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth) / 2) - 20;
                buttonWidth1 = (libraryList.ClientSize.Width / 2) - 20;

                // Adjust padding to provide space at the bottom
                libraryList.Padding = new Padding(0, 0, 0, 10);

                if (start <= max)
                {
                    var booksAdded = keys.Skip(start).Take(pagesToAdd);
                    foreach (int key in booksAdded)
                    {
                        Book bookAdded = booksDictionary[key];
                        if (bookAdded != null) CreateButtonsAsync(bookAdded);
                        start++;
                    }

                }

                isDataLoading = false;
            });
        }

        private void CreateButtonsAsync(Book bookAdded)
        {
            // Marshal task to go back to the thread that handles the ui
            if (libraryList.InvokeRequired)
            {
                libraryList.BeginInvoke(new MethodInvoker(() => CreateButtonsAsync(bookAdded)));
                return;
            }

            if (bookAdded != null)
            {
                bookInfo = new bookDetails(bookAdded);
                bookInfo.Height = 200;
                bookInfo.Margin = new Padding(10);
                libraryList.Controls.Add(bookInfo);
            }

            if (max <= 4)
            {
                bookInfo.Width = buttonWidth1;
            }
            else if (max > 4)
            {
                bookInfo.Width = buttonWidth;
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

        private void addBookButton_Click(object sender, EventArgs e)
        {
            FormsBookAdd = new FORM_BOOKADD();
            FormsBookAdd.ShowDialog();
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

        //Scroll events to load other data
        private void libraryList_Scroll(object sender, ScrollEventArgs e)
        {
            CheckIfAtBottom();
        }
        private void libraryList_MouseWheel(object sender, MouseEventArgs e)
        {
            CheckIfAtBottom();
        }

        private void CheckIfAtBottom()
        {
            FlowLayoutPanel libraryList = this.libraryList;
            int visibleHeight = libraryList.ClientSize.Height;
            int totalHeigth = libraryList.VerticalScroll.Value + visibleHeight;

            if (totalHeigth >= (libraryList.VerticalScroll.Maximum - (bookInfo.Height * 4)) && libraryList.VerticalScroll.Visible)
            {
                if (!isDataLoading)
                {
                    isDataLoading = true;
                    LoadListAsync();
                }
            }

        }
    }
}

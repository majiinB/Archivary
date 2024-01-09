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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_LIBRARY : Form
    {
        private Button buttonize;
        private bookDetails bookInfo;
        private FORM_BOOKADD FormsBookAdd;
        private int buttonWidth;
        private int buttonWidth1;
        private int start = 0;
        private int end = 0;
        private int max = 0;
        private int pagesToAdd = 10;
        private string filter = "All";
        private string searchTerms =  "";
        private List<Book> booksDictionary;
        private List<Book> booksSearched;
        public bool isDataLoading = false; 
        private bool startSearch = false;
        private Timer searchTimer;

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
            InitializeSearchTimer();

            await FilterBooks();
        }
        private async void FORM_LIBRARY_Resize(object sender, EventArgs e)
        {
            await FilterBooks();
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
                startSearch = true;
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                startSearch = false;
                searchBar.Text = "Search Book";
                searchBar.ForeColor = archivaryHoverGray();
                searchBar.Font = new Font("Montserrat Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            FormsBookAdd = new FORM_BOOKADD(this);
            FormsBookAdd.ShowDialog();
        }

        //
        // DROPDOWN EVENTS
        //
        private async void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "All";
            filter = "All";
            await FilterBooks();
        }
        private async void FictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Fiction";
            filter = "Fiction";
            await FilterBooks();
        }

        private async void NonFictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Nonfiction";
            filter = "Nonfiction";
            await FilterBooks();
        }

        private async void AcademicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterSearchButton.Text = "Academic";
            filter = "Academic";
            string selectedFilter = filter;
            await FilterBooks();
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

        #region BACKEND
        /*
         * Wala talagang filter na ginagawa dito pero filter books tawag
         * kasi once na icall to na na applly na laht ng filter
         * like yung dropdown pait search bar
         */
        public async Task FilterBooks()
        {
            //Reset values
            start = 0;
            pagesToAdd = 10;
            libraryList.Controls.Clear();

            //Call load list method
            if (!isDataLoading)
            {
                isDataLoading = true;
                await LoadListAsync();
            }
        }

        /*
         * Eto dito talga nangyayari yung filter tsaka pag retrieve ng data
         */
        private async Task LoadListAsync()
        {
            //Check if bookDictionary and book searched has any elements in it
            //if there are any clear it
            if (booksSearched != null && booksSearched.Count > 0 &&
            booksDictionary != null && booksDictionary.Count > 0)
            {
                booksDictionary.Clear();
                booksSearched.Clear();
            }

            //Create all book object based on filter passed from the drop down
            booksDictionary = BACKEND.BOOK_OPERATIONS.BookOperation.LoadBooksFromDatabase(filter);
            //Create another list of book object that contains the searh term or key needed
            booksSearched = BACKEND.BOOK_OPERATIONS.BookOperation.SearchBooks(booksDictionary, searchTerms);
            //Set the max to that will be loaded in the table based on the final list which is the book searched
            max = booksSearched.Count();
            // Adjust padding to provide space at the bottom
            libraryList.Padding = new Padding(0, 0, 0, 10);
            await Task.Run(() =>
            {
                if (start == 0) Task.Delay(500).Wait(); // Wait for other tasks in the thread que to finish

                buttonWidth = ((libraryList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth) / 2) - 20;
                buttonWidth1 = (libraryList.ClientSize.Width / 2) - 20;

                

                //Logic on how the program will divide the list that will be loaded
                //Check if list contains any elements based on the max value
                if (start < max)
                {
                    if (start == 0) end = 10; //If start equals zero it means that it is the initial list to be displayed
                    else if (start > 0) end = start + pagesToAdd; //otherwise set the end as start plus the pages of info needed to be loaded

                    //Check if end will is greater than max, if end is greater than max set the end to be the max value
                    if (end > max) end = max;

                    //Loop to load the pages or book info
                    for (int i = start; i < end; i++)
                    {
                        Book bookAdded = booksSearched[i]; //Access book
                        //Check if book is null before passing it to the createbutton method
                        if (bookAdded != null) CreateButtonsAsync(bookAdded);
                    }
                    start = end; //Set the start value to be the with the end value
                }
                isDataLoading = false; //set to indicate that the method or process is now finished
            });
        }
        /*
         * Method na gumagawa ng book info
         */
        private void CreateButtonsAsync(Book bookAdded)
        {
            //Marshal task to go back to the thread that handles the ui
            //Kasi hindi pwedeng iupdate ng process yung ui kung wala sila sa same thread
            //di kasi to thread safe basta yun
            if (libraryList.InvokeRequired)
            {
                libraryList.BeginInvoke(new MethodInvoker(() => CreateButtonsAsync(bookAdded)));
                return;
            }

            //Check if book added is not null
            if (bookAdded != null)
            {
                bookInfo = new bookDetails(bookAdded, this); //pass the object reference again
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
        /*
         * Method na ginagamit ng scroll event
         * para malaman kung medyo nasa dulo na yung 
         * scroll mo
         */
        private void CheckIfAtBottom()
        {
            FlowLayoutPanel libraryList = this.libraryList;
            int visibleHeight = libraryList.ClientSize.Height;
            int totalHeigth = libraryList.VerticalScroll.Value + visibleHeight;

            //Checks if total height is greater than or equal to the veritcal scroll value minus the height of the 4 bookinfos
            if (totalHeigth >= (libraryList.VerticalScroll.Maximum - (bookInfo.Height * 4)) && libraryList.VerticalScroll.Visible)
            {
                if (!isDataLoading) //We didnt call filter books method because we dont want to reset the value
                {
                    isDataLoading = true;
                    LoadListAsync();
                }
            }
        }
        /*
         * Pang initialize lang talga nung timer na need para sa search
         */
        private void InitializeSearchTimer()
        {
            //Set up a timer with a 500ms delay
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
        }
        /*
         * Event listener na nattriger after ng 500ms na delay
         * kasi nga pagka start ng timer 500ms yung delay kada o bago tick
         */
        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            //Stop the timer
            //After ng tick stop yung timer
            searchTimer.Stop();

            //Handle the text change after the debounce period
            HandleSearchTextChange();
        }
        /*
         * Method para iset yung searchTerm as yung value na nasa searchbar texbox
         * Tapos load  mo ulit yung list by filterbooks method
         * kasi text chaged yung event at hindi button
         */
        private void HandleSearchTextChange()
        {
            searchTerms = searchBar.Text;
            FilterBooks();
        }
        /*
         * Yung actual text changed event handler 
         */
        private async void searchBar_TextChanged(object sender, EventArgs e)
        {
            if(searchBar!= null && searchTimer != null && startSearch) //Check muna kung may text box talaga pati timer
            {
                // Restart the timer on each text change
                searchTimer.Stop();//Pag nag type ka stop yung timer para di umabot sa 500ms
                searchTimer.Start();//Tapos start ulit so antay ka ulit 500ms
                //Para lang sa pag mabilis nag type is user
            }
        }
        #endregion
    }
}

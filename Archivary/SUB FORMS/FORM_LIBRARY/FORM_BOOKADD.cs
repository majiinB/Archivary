using Archivary._900X500;
using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.TIMER;
using Archivary.BACKEND.Validations;
using Archivary.PARENT_FORMS;
using CustomDropdown;
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

namespace Archivary._1500X1000.FORM_LIBRARY
{
    public partial class FORM_BOOKADD : Form
    {
        private Archivary.PARENT_FORMS.FORM_LIBRARY library;
        private string imageFileLocation;

        public FORM_BOOKADD(Archivary.PARENT_FORMS.FORM_LIBRARY library)
        {
            InitializeComponent();
            DropdownProperties();
            bookPIctureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.library = library;
        }

        private void DropdownProperties()
        {
            dropdownMenu1.IsMainMenu = true;
            dropdownMenu2.IsMainMenu = true;
            dropdownMenu1.PrimaryColor = Color.FromArgb(37, 211, 102);
            dropdownMenu2.PrimaryColor = Color.FromArgb(37, 211, 102);
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

        private void ISBNTextbox_TextChanged(object sender, EventArgs e)
        {
            TextboxValidation.NumberBox(ISBNTextbox);
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            imageFileLocation = selectImage();
        }

        private string selectImage()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return null;
            }

            bookPIctureBox.Image = new Bitmap(openFileDialog1.FileName);
            return openFileDialog1.FileName;
        }

        private async void saveInfoButton_Click(object sender, EventArgs e)
        {
            RoundedTextBox[] boxes = { ISBNTextbox, publisherTextbox, authorLNTextbox, authorFNTextbox, authorMITextbox, copyrightTextbox, aisleTextbox, shelfTextbox };
            TimerOpersys.Start();
            if (TextboxValidation.CheckIfTextBoxesAreEmpty(boxes))
            {
                TimerOpersys.Stop();
                FORM_ALERT alert = new FORM_ALERT(1, "EMPTY TEXT", "You cannot save info with empty textboxes.");
                alert.TopMost = true;
                alert.Show();
                return;
            }
            if (CategoryValidation.CheckIfCategoryIsUnchanged(categoryDropdown, genreDropdown))
            {
                TimerOpersys.Stop();
                FORM_ALERT alert = new FORM_ALERT(1, "NO CATEGORY/GENRE", "Select a category and then genre first.");
                alert.TopMost = true;
                alert.Show();
                return;
            }
            string author = authorLNTextbox.Text + "," + authorFNTextbox.Text + " " + authorMITextbox.Text + ".";
            library.libraryList.Controls.Clear();
            await library.FilterBooks();
            Archivary.BACKEND.BOOK_OPERATIONS.BookOperation.AddBook(author, genreDropdown.Text, ISBNTextbox.Text, categoryDropdown.Text, titleTextbox.Text, copyrightTextbox.Text, publisherTextbox.Text, Convert.ToInt32(aisleTextbox.Text), Convert.ToInt32(shelfTextbox.Text), imageFileLocation);
            TimerOpersys.Stop();
            FORM_ALERT success = new FORM_ALERT(3, "BOOK ADDED", "Successfully added a new book.");
            success.TopMost = true;
            success.Show();
            if (TimerOpersys.IsEnabled) TimerOpersys.DisplayElapsedTime();
            this.Dispose();
            
            
        }

        private void OpenMenu(DropdownMenu dropdown, object sender)
        {
            Control control = (Control)sender;
            dropdown.Show(control, control.Width - control.Width, control.Height);
        }

        private void categoryDropdown_Click(object sender, EventArgs e)
        {
            OpenMenu(dropdownMenu1, sender);
        }

        private void genreDropdown_Click(object sender, EventArgs e)
        {
            OpenMenu(dropdownMenu2, sender);
        }

        private void academicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryDropdown.Text = "Academic";
            UpdateGenreMenu();
        }

        private void nonfictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryDropdown.Text = "Nonfiction";
            UpdateGenreMenu();
        }

        private void fictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryDropdown.Text = "Fiction";
            UpdateGenreMenu();
        }
        private void UpdateGenreMenu()
        {
            dropdownMenu2.Items.Clear();
            switch (categoryDropdown.Text)
            {
                case "Academic": SetAcademicGenres(); break;
                case "Nonfiction": SetNonFictionGenres(); break;
                case "Fiction": SetFictionGenres(); break;
            }
        }

        private void SetAcademicGenres()
        {
            genreDropdown.Text = "English";
            SetGenreDropdown(new string[] { "English", "Filipino", "History", "Mathematics", "Philosophy", "Science" });
        }

        private void SetNonFictionGenres()
        {
            genreDropdown.Text = "Autobiography";
            SetGenreDropdown(new string[] { "Autobiography", "Food and Cooking", "Health and Wellness", "Self Help", "Technology", "Travel and Exploration" });
        }

        private void SetFictionGenres()
        {
            genreDropdown.Text = "Fantasy";
            SetGenreDropdown(new string[] { "Fantasy", "Mystery", "Thriller", "Romance", "Horror", "Children's Literature", "Science Fiction", "Historical Fiction", "Young Adult", "Action", "Adventure", "Supernatural", "Comedy/Satire", "Psychological Fiction", "Apocalyptic/Post-Apocalyptic" });
        }

        private void SetGenreDropdown(string[] menuItems)
        {
            foreach (string menuItemText in menuItems)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Name = menuItemText.ToLower();
                menuItem.Size = new System.Drawing.Size(180, 22);
                menuItem.Text = menuItemText;
                menuItem.Click += new System.EventHandler(this.genre_Click);
                dropdownMenu2.Items.Add(menuItem);
            }
        }

        private void genre_Click(object sender, EventArgs e)
        {
            genreDropdown.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void aisleTextbox_TextChanged(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            foreach (char letter in aisleTextbox.Text)
            {
                if (char.IsDigit(letter))
                {
                    result.Append(letter);
                }
            }

            aisleTextbox.Text = result.ToString();
        }

        private void shelfTextbox_TextChanged(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            foreach (char letter in shelfTextbox.Text)
            {
                if (char.IsDigit(letter))
                {
                    result.Append(letter);
                }
            }

            shelfTextbox.Text = result.ToString();
        }

        private void removeImageButton_Click(object sender, EventArgs e)
        {
            imageFileLocation = "No_image";
            bookPIctureBox.Image = null;
        }

        private void removeImageButton_MouseEnter(object sender, EventArgs e)
        {
            removeImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
        }

        private void removeImageButton_MouseLeave(object sender, EventArgs e)
        {
            removeImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
        }


        //
        // HOVERS FOR BOOK ADD
        //
        private string titleInput,
            isbnInput, publisherInput,
            authorFNInput, authorLNInput,
            authorMIInput, copyrightInput,
            aisleInput, shelfInput;

        // TITLE
        private void titleTextbox_Enter(object sender, EventArgs e)
        {
            titleInput = titleTextbox.Text;
            if (titleInput == "Enter Book Title") titleTextbox.Text = "";
            else titleTextbox.Text = titleInput;
        }

        private void titleTextbox_Leave(object sender, EventArgs e)
        {
            titleInput = titleTextbox.Text;
            if (string.IsNullOrWhiteSpace(titleInput)) titleTextbox.Text = "Enter Book Title";
        }

        // ISBN
        private void ISBNTextbox_Enter(object sender, EventArgs e)
        {
            isbnInput = ISBNTextbox.Text;
            if (isbnInput == "000") ISBNTextbox.Text = "";
            else ISBNTextbox.Text = isbnInput;
        }

        private void ISBNTextbox_Leave(object sender, EventArgs e)
        {
            isbnInput = ISBNTextbox.Text;
            if (string.IsNullOrWhiteSpace(isbnInput)) ISBNTextbox.Text = "000";
        }

        //PUBLISHER
        private void publisherTextbox_Enter(object sender, EventArgs e)
        {
            publisherInput = publisherTextbox.Text;
            if (publisherInput == "Enter Publisher") publisherTextbox.Text = "";
            else publisherTextbox.Text = publisherInput;
        }

        private void publisherTextbox_Leave(object sender, EventArgs e)
        {
            publisherInput = publisherTextbox.Text;
            if (string.IsNullOrWhiteSpace(publisherInput)) publisherTextbox.Text = "Enter Publisher";
        }

        // AUTHOR FIRST NAME
        private void authorLNTextbox_Enter(object sender, EventArgs e)
        {
            authorLNInput = authorLNTextbox.Text;
            if (authorLNInput == "Enter Author Last Name") authorLNTextbox.Text = "";
            else authorLNTextbox.Text = authorLNInput;
        }

        private void authorLNTextbox_Leave(object sender, EventArgs e)
        {
            authorLNInput = authorLNTextbox.Text;
            if (string.IsNullOrWhiteSpace(authorLNInput)) authorLNTextbox.Text = "Enter Author Last Name";
        }

        // AUTHOR LAST NAME
        private void authorFNTextbox_Enter(object sender, EventArgs e)
        {
            authorFNInput = authorFNTextbox.Text;
            if (authorFNInput == "Enter Author First Name") authorFNTextbox.Text = "";
            else authorFNTextbox.Text = authorFNInput;
        }

        private void authorFNTextbox_Leave(object sender, EventArgs e)
        {
            authorFNInput = authorLNTextbox.Text;
            if (string.IsNullOrWhiteSpace(authorFNInput)) authorLNTextbox.Text = "Enter Author First Name";
        }

        // AUTHOR MIDDLE NAME
        private void authorMITextbox_Enter(object sender, EventArgs e)
        {
            authorMIInput = authorMITextbox.Text;
            if (authorMIInput == "M.I") authorMITextbox.Text = "";
            else authorMITextbox.Text = authorMIInput;
        }

        private void authorMITextbox_Leave(object sender, EventArgs e)
        {
            authorMIInput = authorMITextbox.Text;
            if (string.IsNullOrWhiteSpace(authorMIInput)) authorMITextbox.Text = "M.I";
        }

        // COPYRIGHT
        private void copyrightTextbox_Enter(object sender, EventArgs e)
        {
            copyrightInput = copyrightTextbox.Text;
            if (copyrightInput == "0000") copyrightTextbox.Text = "";
            else copyrightTextbox.Text = copyrightInput;
        }

        private void copyrightTextbox_Leave(object sender, EventArgs e)
        {
            copyrightInput = copyrightTextbox.Text;
            if (string.IsNullOrWhiteSpace(copyrightInput)) copyrightTextbox.Text = "0000";
        }

        // AISLE
        private void aisleTextbox_Enter(object sender, EventArgs e)
        {
            aisleInput = aisleTextbox.Text;
            if (aisleInput == "000") aisleTextbox.Text = "";
            else aisleTextbox.Text = aisleInput;
        }

        private void aisleTextbox_Leave(object sender, EventArgs e)
        {
            aisleInput = aisleTextbox.Text;
            if (string.IsNullOrWhiteSpace(aisleInput)) aisleTextbox.Text = "000";
        }

        // SHELF
        private void shelfTextbox_Enter(object sender, EventArgs e)
        {
            shelfInput = shelfTextbox.Text;
            if (shelfInput == "000") shelfTextbox.Text = "";
            else shelfTextbox.Text = shelfInput;
        }

        private void shelfTextbox_Leave(object sender, EventArgs e)
        {
            shelfInput = shelfTextbox.Text;
            if (string.IsNullOrWhiteSpace(copyrightInput)) shelfTextbox.Text = "000";
        }
    }
}

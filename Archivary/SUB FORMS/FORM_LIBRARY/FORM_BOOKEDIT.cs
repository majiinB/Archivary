using Archivary._900X500;
using Archivary.BACKEND.OBJECTS;
using Archivary.PARENT_FORMS;
using CustomDropdown;
using MySql.Data.MySqlClient;
using sidebarComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace Archivary._1500X1000.FORM_LIBRARY
{
    public partial class FORM_BOOKEDIT : Form
    {
        private Book book;
        private string imageFileLocation;
        private Archivary.PARENT_FORMS.FORM_LIBRARY library;
        private Archivary._1500X1000.FORM_LIBRARY.FORM_BOOKINFO bookInfo;
        public FORM_BOOKEDIT(Book bookAdded, Archivary.PARENT_FORMS.FORM_LIBRARY library, Archivary._1500X1000.FORM_LIBRARY.FORM_BOOKINFO bookInfo)
        {
            InitializeComponent();
            book = bookAdded;
            this.library = library;
            this.bookInfo = bookInfo;
            SetBookInformation(book);
            DropdownProperties();
            UpdateGenreMenu();
        }
        private void DropdownProperties()
        {
            dropdownMenu1.IsMainMenu = true;
            dropdownMenu2.IsMainMenu = true;
            dropdownMenu1.PrimaryColor = Color.FromArgb(37, 211, 102);
            dropdownMenu2.PrimaryColor = Color.FromArgb(37, 211, 102);
        }

        private void SetBookInformation(Book bookAdded)
        {
            titleTextbox.Text = bookAdded.BookTitle;
            ISBNTextbox.Text = bookAdded.BookISBN;
            publisherTextbox.Text = bookAdded.BookPublisher;
            string[] nameParts = SplitName(bookAdded.BookAuthor);
            authorLNTextbox.Text = nameParts[0];
            authorFNTextbox.Text = nameParts[1];
            authorMITextbox.Text = nameParts[2];
            copyrightTextbox.Text = bookAdded.BookCopyright;
            aisleTextbox.Text = bookAdded.BookAisle.ToString();
            shelfTextbox.Text = bookAdded.BookShelf.ToString();
            categoryDropdown.Text = bookAdded.BookCategory.ToString();
            genreDropdown.Text = bookAdded.BookGenre.ToString();
            SetPictureBoxImage(bookAdded.BookImage);
            imageFileLocation = bookAdded.BookImage;
        }
        static string[] SplitName(string input)
        {
            // Split the input string using ',' as the delimiter
            string[] parts = input.Split(',');

            // Check if there are at least two parts (Last Name and First Name + Middle Initial)
            if (parts.Length >= 2)
            {
                // Extract the Last Name (trimmed to remove leading/trailing spaces)
                string lastName = parts[0].Trim();

                // Extract the First Name and Middle Initial
                string[] firstNameMiddleInitial = parts[1].Trim().Split(' ');

                // If there's no middle initial, set it to "N/A"
                string middleInitial = firstNameMiddleInitial.Length > 1 ? firstNameMiddleInitial[1] : "N/A";

                // Return the result as an array
                return new string[] { lastName, firstNameMiddleInitial[0], middleInitial };
            }

            // If the input is not in the expected format, return an array with default values
            return new string[] { "N/A", "N/A", "N/A" };
        }


        private void SetPictureBoxImage(string imagePath)
        {
            try
            {
                // Load the image from the file
                var image = Image.FromFile(imagePath);

                // Set the image to the PictureBox
                bookPictureBox.Image = image;

                // Optionally, adjust the PictureBox size to fit the image
                bookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                bookPictureBox.Size = image.Size;
            }
            catch (System.IO.FileNotFoundException)
            {
                // Handle the case when the file is not found
                // Load a default image from resources and set it to the PictureBox
                bookPictureBox.Image = Properties.Resources.ArchivaryLogoGreen;

                // Optionally, adjust the PictureBox size to fit the default image
                bookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                bookPictureBox.Size = Properties.Resources.ArchivaryLogoGreen.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SetBookInformation(book); // this resets the current information inputted when cancelled
            this.Close();
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

            bookPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            return openFileDialog1.FileName;
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

        private void academicToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            categoryDropdown.Text = "Academic";
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

        private void genre_Click(object sender, EventArgs e)
        {
            genreDropdown.Text = ((ToolStripMenuItem)sender).Text;
        }
        
        private void SetAcademicGenres()
        {
            genreDropdown.Text = "English";
            SetGenreDropdown(new string[] { "English", "Filipino", "History", "Mathematics", "Philosophy", "Science" });
        }

        private void SetNonFictionGenres()
        {
            genreDropdown.Text = "Autobiography";
            SetGenreDropdown(new string[] { "Autobiography", "Food and Cooking", "Health and Wellness", "Self Help", "Technology", "Travel and Exploration"});
        }

        private void SetFictionGenres()
        {
            genreDropdown.Text = "Fantasy";
            SetGenreDropdown(new string[] { "Fantasy", "Mystery", "Thriller", "Romance", "Horror", "Children's Literature", "Science Fiction", "Historical Fiction", "Young Adult", "Action", "Adventure", "Supernatural", "Comedy/Satire", "Psychological Fiction", "Apocalyptic/Post-Apocalyptic"});
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

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            if(AllInfoUnchanged(book))
            {
                FORM_ALERT alert = new FORM_ALERT(3, "UNCHANGED INFO", "You cannot save info without changing any information.");
                alert.TopMost = true;
                alert.Show();
                return;
            }
            if (CheckIfTextBoxesAreEmpty())
            {
                FORM_ALERT alert = new FORM_ALERT(3, "EMPTY TEXT", "You cannot save info with empty textboxes.");
                alert.TopMost = true;
                alert.Show();
                return;
            }
            UpdateBookInfo();
            this.Close();
            bookInfo.Close();
        }

        private bool AllInfoUnchanged(Book bookAdded)
        {
            string[] nameParts = SplitName(bookAdded.BookAuthor);
            return titleTextbox.Text.Equals(bookAdded.BookTitle) &&
                   ISBNTextbox.Text.Equals(bookAdded.BookISBN) &&
                   publisherTextbox.Text.Equals(bookAdded.BookPublisher) &&
                   authorLNTextbox.Text.Equals(nameParts[0]) &&
                   authorFNTextbox.Text.Equals(nameParts[1]) &&
                   authorMITextbox.Text.Equals(nameParts[2]) &&
                   copyrightTextbox.Text.Equals(bookAdded.BookCopyright) &&
                   aisleTextbox.Text.Equals(bookAdded.BookAisle.ToString()) &&
                   shelfTextbox.Text.Equals(bookAdded.BookShelf.ToString()) &&
                   categoryDropdown.Text.Equals(bookAdded.BookCategory.ToString()) &&
                   genreDropdown.Text.Equals(bookAdded.BookGenre.ToString()) &&
                   imageFileLocation.Equals(bookAdded.BookImage);
        }

        private bool CheckIfTextBoxesAreEmpty()
        {
            return string.IsNullOrEmpty(titleTextbox.Text) ||
                   string.IsNullOrEmpty(ISBNTextbox.Text) ||
                   string.IsNullOrEmpty(publisherTextbox.Text) ||
                   string.IsNullOrEmpty(authorLNTextbox.Text) ||
                   string.IsNullOrEmpty(authorFNTextbox.Text) ||
                   string.IsNullOrEmpty(authorMITextbox.Text) ||
                   string.IsNullOrEmpty(copyrightTextbox.Text) ||
                   string.IsNullOrEmpty(aisleTextbox.Text) ||
                   string.IsNullOrEmpty(shelfTextbox.Text);
        }

        private async void UpdateBookInfo()
        {
            using (MySqlConnection conn = new MySqlConnection(Archivary.BACKEND.DATABASE.DatabaseConnection.ConnectionDetails()))
            {
                conn.Open();
                string query = "UPDATE books SET author = @Author, genre = @Genre, isbn = @Isbn, category = @Category, title = @Title, copyright = @Copyright, publisher = @Publisher, aisle = @Aisle, shelf = @Shelf, book_img_path = @Book_img_path where id = @Id";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    string authorMiddleInitial = authorMITextbox.Text.Equals("N/A") ? "" : authorMITextbox.Text;
                    string author = $"{authorLNTextbox.Text}, {authorFNTextbox.Text} {authorMiddleInitial}"; 
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Genre", genreDropdown.Text);
                    command.Parameters.AddWithValue("@Isbn", ISBNTextbox.Text);
                    command.Parameters.AddWithValue("@Category", categoryDropdown.Text);
                    command.Parameters.AddWithValue("@Title", titleTextbox.Text);
                    command.Parameters.AddWithValue("@Copyright", copyrightTextbox.Text);
                    command.Parameters.AddWithValue("@Publisher", publisherTextbox.Text);
                    command.Parameters.AddWithValue("@Aisle", aisleTextbox.Text);
                    command.Parameters.AddWithValue("@Shelf", shelfTextbox.Text);
                    command.Parameters.AddWithValue("@Book_img_path", imageFileLocation == null ? "NO_IMAGE" : imageFileLocation);
                    command.Parameters.AddWithValue("@Id", book.BookId);
                    try
                    {
                        command.ExecuteNonQuery();
                        library.libraryList.Controls.Clear();
                        await library.FilterBooks();
                        FORM_ALERT success = new FORM_ALERT(3, "Book updated!", $"Successfully updated {titleTextbox.Text}!");
                        success.TopMost = true;
                        success.Show();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error updating book info: {ex.Message}");
                    }
                }
            }
        }

        private void ISBNTextbox_TextChanged(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            foreach (char letter in ISBNTextbox.Text)
            {
                if (char.IsDigit(letter))
                {
                    result.Append(letter);
                }
            }

            ISBNTextbox.Text = result.ToString();
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
    }
}

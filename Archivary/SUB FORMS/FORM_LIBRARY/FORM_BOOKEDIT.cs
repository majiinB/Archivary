using Archivary.BACKEND.OBJECTS;
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
        public FORM_BOOKEDIT(Book bookAdded)
        {
            InitializeComponent();
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


        }
        static string[] SplitName(string input)
        {
            // Split the input string using ',' as the delimiter
            string[] parts = input.Split(',');

            // Extract the Last Name (trimmed to remove leading/trailing spaces)
            string lastName = parts[0].Trim();

            // Extract the First Name and Middle Initial
            string[] firstNameMiddleInitial = parts[1].Trim().Split(' ');

            // If there's no middle initial, set it to "N/A"
            string middleInitial = firstNameMiddleInitial.Length > 1 ? firstNameMiddleInitial[1] : "N/A";

            // Return the result as an array
            return new string[] { lastName, firstNameMiddleInitial[0], middleInitial };
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
            this.Close();
        }
    }
}

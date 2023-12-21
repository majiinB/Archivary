using Archivary.BACKEND.OBJECTS;
using Archivary.PARENT_FORMS;
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
    public partial class FORM_BOOKINFO : Form
    {

        private FORM_BOOKEDIT FormsBookEdit;

        public FORM_BOOKINFO(Book bookAdded)
        {
            InitializeComponent();
            booktitleLabel.Text = bookAdded.BookTitle;
            categoryLabel.Text = bookAdded.BookCategory;
            genreLabel.Text = bookAdded.BookGenre;
            availableLabel.Text = bookAdded.BookStatus;
            ISBNTextbox.Text = bookAdded.BookISBN;
            authorTextbox.Text = bookAdded.BookAuthor;
            publisherTextbox.Text = bookAdded.BookPublisher;
            copyrightTextbox.Text = bookAdded.BookCopyright;
            aisleTextbox.Text = bookAdded.BookAisle.ToString();
            shelfTextbox.Text = bookAdded.BookShelf.ToString();
            SetPictureBoxImage(bookAdded.BookImage);
            FormsBookEdit = new FORM_BOOKEDIT(bookAdded);
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

        private void editInfoButton_Click(object sender, EventArgs e)
        {
            FormsBookEdit.ShowDialog(this);
            this.Show();               
        }
    }
}

using Archivary._1500X1000.FORM_LIBRARY;
using Archivary.BACKEND.OBJECTS;
using Archivary.PARENT_FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary.Archivary_Components
{
    public partial class bookDetails : UserControl
    {

        public bookDetails(Book bookAdded, Archivary.PARENT_FORMS.FORM_LIBRARY library)
        {
            InitializeComponent();
            bookTitleLabel.Text = bookAdded.BookTitle;
            authorLabel.Text = bookAdded.BookAuthor;
            isbnLabel.Text = bookAdded.BookISBN;
            SetPictureBoxImage(bookAdded.BookImage);
            FormsBookInfo = new FORM_BOOKINFO(bookAdded, library);
        }

        public bookDetails(Book bookAdded)
        {
            InitializeComponent();
            isbnLabel.Hide();
            viewButton.Hide();
            this.Click += new EventHandler(bookDetails_Click);
        }

        private void bookDetails_Click(object sender, EventArgs e)
        {

        }

        #region Properties

        private FORM_BOOKINFO FormsBookInfo;
        private string _title;
        private string _author;
        private string _isbn;
        private Image _image;
        private Button _button;


        [Browsable(false)]
        public string AuthorHolder
        {
            get { return "Author: "; }
        }

        [Browsable(false)]
        public string ISBNHolder
        {
            get { return "ISBN: "; }
        }

        [Category("Book Information")]
        public string Title
        {
            get { return _title; }
            set { _title = value;  bookTitleLabel.Text = value; }
        }

        [Category("Book Information")]
        public string Author
        {
            get { return _author; }
            set { _author = value;  authorLabel.Text = value; }
        }

        [Category("Book Information")]
        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; isbnLabel.Text = value; }
        }

        [Category("Book Information")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; bookPicture.Image = value; }
        }

        [Category("Book Information")]
        public Button Button
        {
            get { return _button; }
            set { _button = value; }
        }

        #endregion

        private void SetPictureBoxImage(string imagePath)
        {
            try
            {
                // Load the image from the file
                var image = Image.FromFile(imagePath);

                // Set the image to the PictureBox
                bookPicture.Image = image;

                // Optionally, adjust the PictureBox size to fit the image
                bookPicture.SizeMode = PictureBoxSizeMode.Zoom;
                bookPicture.Size = image.Size;
            }
            catch (System.IO.FileNotFoundException)
            {
                // Handle the case when the file is not found
                // Load a default image from resources and set it to the PictureBox
                bookPicture.Image = Properties.Resources.ArchivaryLogoGreen;

                // Optionally, adjust the PictureBox size to fit the default image
                bookPicture.SizeMode = PictureBoxSizeMode.Zoom;
                bookPicture.Size = Properties.Resources.ArchivaryLogoGreen.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void viewButton_Click(object sender, EventArgs e)
        {
            FormsBookInfo.ShowDialog();
        }

    }
}

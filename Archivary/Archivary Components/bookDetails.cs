using Archivary._1500X1000.FORM_LIBRARY;
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


        public bookDetails()
        {
            InitializeComponent();
        }

        #region Properties

        private FORM_BOOKINFO FormsBookInfo = new FORM_BOOKINFO();
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

        private void viewButton_Click(object sender, EventArgs e)
        {

        }
    }
}

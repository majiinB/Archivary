using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private string _title;
        private string _author;
        private string _isbn;
        private Image _image;
        private Button _button;

        [Category("Book Information")]
        public string Title
        {
            get { return _title; }
            set { _title = value; bookTitleLabel.Text = value; }
        }

        [Category("Book Information")]
        public string Author
        {
            get { return _author; }
            set { _author = value; authorLabel.Text = value; }
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


    }
}

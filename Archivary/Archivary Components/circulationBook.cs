using Archivary._1500X1000.FORM_LIBRARY;
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
    public partial class circulationBook : UserControl
    {
        public circulationBook()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private Image _image;
        private Button _button;

        [Category("Book Information")]
        public string Title
        {
            get { return _title; }
            set { _title = value; bookTitleLabel.Text = value; }
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

        private void selectButton_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary.MAIN_FORMS
{
    public partial class FORM_BLUR : Form
    {
        public FORM_BLUR()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromRectangle(this.Bounds).WorkingArea;
        }
    }
}

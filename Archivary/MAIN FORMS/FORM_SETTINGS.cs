using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_SETTINGS : Form
    {
        private int panelWidth;

        public FORM_SETTINGS()
        {
            InitializeComponent();
        }

        private void FORM_SETTINGS_Load(object sender, EventArgs e)
        {

        }

        private void FORM_SETTINGS_Resize(object sender, EventArgs e)
        {

        }

        private void LoadPanels()
        {
            panelWidth = (PANEL_CONTAINER.ClientSize.Width / 1) - 20; //( -20 <-- this is padding size)

            leftPanel.Width = panelWidth;
            rightPanel.Width = panelWidth;
        }


    }
}

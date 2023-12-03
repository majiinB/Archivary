using Archivary.PARENT_FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary
{
    public partial class FORM_SIDEBAR1 : Form
    {
        private FORM_ROOT FormsRoot;
        private FORM_LOGIN FormsLogin;
        private FORM_LIBRARY FormsLibrary = new FORM_LIBRARY();

        private bool isToggled = false;

        public FORM_SIDEBAR1(FORM_ROOT showFormsRoot)
        {
            InitializeComponent();
            FormsRoot = showFormsRoot;
        }

        private void sidebarButton_Click(object sender, EventArgs e)
        {
            isToggled = !isToggled;
            collapseSidebar();
        }

        private void collapseSidebar()
        {
            if (isToggled)
            {
                PANEL_SIDEBAR.Size = new System.Drawing.Size(220, 540);
            }
            else
            {
                PANEL_SIDEBAR.Size = new System.Drawing.Size(70, 540);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PANEL_HEADER_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.FormsRoot.Handle, 0x112, 0xf012, 0);
        }
    }
}

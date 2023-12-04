using Archivary.PARENT_FORMS;
using Archivary.Properties;
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

        private readonly Size minimumSize = new Size(960, 650);

        public FORM_SIDEBAR1(FORM_ROOT showFormsRoot)
        {
            InitializeComponent();
            FormsRoot = showFormsRoot;

            this.Size = new Size(960, 650);
            this.MinimumSize = minimumSize;

            sidebarControlsSize();
        }

        private void sidebarControlsSize()
        {
            PANEL_SIDEBAR.Size = new System.Drawing.Size(70, 650);
            PANEL_SIDEBAR.Padding = new System.Windows.Forms.Padding(10);
            LAYOUT_sidebarButton.Size = new System.Drawing.Size(50, 50);
            LAYOUT_LOGO.Size = new System.Drawing.Size(50, 60);
            LAYOUT_ACCOUNT.Size = new System.Drawing.Size(50, 50);

            sidebarButton.Size = new System.Drawing.Size(50, 50);
            accountPictureBox.Size = new System.Drawing.Size(50, 50);
            libraryButton.Size = new System.Drawing.Size(50, 50);
            circulationsButton.Size = new System.Drawing.Size(50, 50);
            usersButton.Size = new System.Drawing.Size(50, 50);
            reportsButton.Size = new System.Drawing.Size(50, 50);
            settingsButton.Size = new System.Drawing.Size(50, 50);
            logoutButton.Size = new System.Drawing.Size(50, 50);
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
                PANEL_SIDEBAR.Size = new System.Drawing.Size(220, 650);
            }
            else
            {
                PANEL_SIDEBAR.Size = new System.Drawing.Size(70, 650);
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

        private void PANEL_headerContents_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.FormsRoot.Handle, 0x112, 0xf012, 0);
        }

        //
        // CONTROL BOX EVENT METHODS
        //
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (FormsRoot.WindowState == System.Windows.Forms.FormWindowState.Normal)
            {
                FormsRoot.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                this.maximizeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_MAXIMIZE_TOGGLE;
            }
            else
            {
                FormsRoot.WindowState = System.Windows.Forms.FormWindowState.Normal;
                this.maximizeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_MAXIMIZE;
            }
            
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            FormsRoot.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        //
        // CONTROL BOX HOVER EFFECTS
        //
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.closeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_CLOSE_WHITE;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.closeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_CLOSE;
        }

        private void maximizeButton_MouseEnter(object sender, EventArgs e)
        {
            if (FormsRoot.WindowState == System.Windows.Forms.FormWindowState.Normal) this.maximizeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_MAXIMIZE_WHITE;
            else this.maximizeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_MAXIMIZE_TOGGLE_WHITE;
        }

        private void maximizeButton_MouseLeave(object sender, EventArgs e)
        {
            if (FormsRoot.WindowState == System.Windows.Forms.FormWindowState.Normal) this.maximizeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_MAXIMIZE;
            else this.maximizeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_MAXIMIZE_TOGGLE;
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            this.minimizeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_MINIMIZE_WHITE;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            this.minimizeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_MINIMIZE;
        }
    }
}

using Archivary.PARENT_FORMS;
using Archivary.Properties;
using sidebarComponents;
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
    public partial class FORM_SIDEBAR : Form
    {
        private FORM_ROOT FormsRoot;
        private FORM_LOGIN FormsLogin;
        private FORM_LIBRARY FormsLibrary = new FORM_LIBRARY();
        private FORM_CIRCULATION FormsCirculation = new FORM_CIRCULATION();
        private FORM_USERS FormsUsers = new FORM_USERS();
        private FORM_REPORTS FormsReports = new FORM_REPORTS();
        private FORM_SETTINGS FormsSettings = new FORM_SETTINGS();

        private bool isToggled = false;

        private readonly Size minimumSize = new Size(960, 650);

        public FORM_SIDEBAR(FORM_ROOT showFormsRoot)
        {
            InitializeComponent();
            FormsRoot = showFormsRoot;

            this.Size = new Size(960, 650);
            this.MinimumSize = minimumSize;

            sidebarControlsSize();
        }

        //
        // SIDEBAR FIXED SIZES FOR OVERRIDE DO NOT TOUCH JEBAL
        //
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

        //
        // SIDEBAR BUTTON
        //
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
                this.sidebarButton.ButtonImage = global::Archivary.Properties.Resources.ICON_SIDEBAR_CLOSE;
                this.logoPictureBox.Image = global::Archivary.Properties.Resources.ArchivaryLogoBannerPNG;
            }
            else
            {
                PANEL_SIDEBAR.Size = new System.Drawing.Size(70, 650);
                this.sidebarButton.ButtonImage = global::Archivary.Properties.Resources.ICON_SIDEBAR_OPEN;
                this.logoPictureBox.Image = global::Archivary.Properties.Resources.ArchivaryLogoGreen;
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
            closeButton.BackColor = archivaryRed();
            this.closeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_CLOSE_WHITE;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = archivaryBlack();
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
        


        // HOVER EFFECTS OF BUTTON (MOUSE ENTER MOUSE LEAVE EVENT HANDLERS)
        //
        // LIBRARY BUTTON
        //
        private void libraryButton_MouseEnter(object sender, EventArgs e)
        {
            libraryButton.ButtonImage = global::Archivary.Properties.Resources.ICON_LIBRARY_GREEN;
        }

        private void libraryButton_MouseLeave(object sender, EventArgs e)
        {
            libraryButton.ButtonImage = global::Archivary.Properties.Resources.ICON_LIBRARY;
        }

        //
        // CIRCULATIONS BUTTON
        //
        private void circulationsButton_MouseEnter(object sender, EventArgs e)
        {
            circulationsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_CIRCULATION_GREEN;
        }

        private void circulationsButton_MouseLeave(object sender, EventArgs e)
        {
            circulationsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_CIRCULATION;
        }

        //
        // USERS BUTTON
        //
        private void usersButton_MouseEnter(object sender, EventArgs e)
        {
            usersButton.ButtonImage = global::Archivary.Properties.Resources.ICON_USER_GREEN;
        }

        private void usersButton_MouseLeave(object sender, EventArgs e)
        {
            usersButton.ButtonImage = global::Archivary.Properties.Resources.ICON_USER;
        }

        //
        // REPORTS BUTTON
        //
        private void reportsButton_MouseEnter(object sender, EventArgs e)
        {
            reportsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_REPORT_GREEN;
        }

        private void reportsButton_MouseLeave(object sender, EventArgs e)
        {
            reportsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_REPORT;
        }

        //
        // SETTINGS BUTTON
        //
        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_SETTING_GREEN;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_SETTING;
        }

        //
        // LOGOUT BUTTON
        //
        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.ButtonImage = global::Archivary.Properties.Resources.ICON_LOGOUT_GREEN;
            logoutButton.ForeColor = archivaryGreen();
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.ButtonImage = global::Archivary.Properties.Resources.ICON_LOGOUT;
            logoutButton.ForeColor = archivaryWhite();
        }


        //
        // SIDEBAR CLICK METHODS
        //
        private sidebarButton clickedButton = null;

        private void libraryButton_Click(object sender, EventArgs e)
        {
            selectedButton(sender, archivaryGreen());
            showMainForms(FormsLibrary);
        }

        private void circulationsButton_Click(object sender, EventArgs e)
        {
            selectedButton(sender, archivaryGreen());
            showMainForms(FormsCirculation);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            selectedButton(sender, archivaryGreen());
            showMainForms(FormsUsers);
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            selectedButton(sender, archivaryGreen());
            showMainForms(FormsReports);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            selectedButton(sender, archivaryGreen());
            showMainForms(FormsSettings);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FormsRoot.loadParentForm(new FORM_LOGIN(FormsRoot));
            FormsRoot.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }


        //
        // SHOW MAIN FORMS IN PANEL_CONTENTS
        //
        private void showMainForms(Form showChildForm)
        {
            showChildForm.TopLevel = false;
            PANEL_CONTENTS.Controls.Add(showChildForm);
            showChildForm.Dock = DockStyle.Fill;
            showChildForm.BringToFront();
            showChildForm.Show();
        }


        //
        // COLOR METHODS
        //
        private Color archivaryGreen()
        {
            return Color.FromArgb(37, 211, 102);
        }

        private Color archivaryWhite()
        {
            return Color.FromArgb(244, 244, 244);
        }

        private Color archivaryBlack()
        {
            return Color.FromArgb(20, 18, 18);
        }

        private Color archivaryGray()
        {
            return Color.FromArgb(40, 40, 40);
        }

        private Color archivaryCream()
        {
            return Color.FromArgb(208, 190, 143);
        }

        private Color archivaryRed()
        {
            return Color.FromArgb(227, 25, 55);
        }


        //
        // BUTTON STAYS COLOR WHEN CLICKED
        //
        private sidebarButton currentButton;
        private void selectedButton(object btn, Color color)
        {
            if (btn != null)
            {
                disableButton();
                currentButton = (sidebarButton)btn;
                currentButton.BackColor = archivaryGreen();
                currentButton.ForeColor = color;
            }
        }

        private void disableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = archivaryBlack();
                currentButton.ForeColor = archivaryWhite();
            }
        }


    }
}

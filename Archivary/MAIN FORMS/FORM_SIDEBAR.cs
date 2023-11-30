using Archivary.PARENT_FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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

        private bool isToggled = false;

        public FORM_SIDEBAR(FORM_ROOT showFormsRoot)
        {
            InitializeComponent();
            FormsRoot = showFormsRoot;
        }

        private void FORM_SIDEBAR_Load(object sender, EventArgs e)
        {

        }


        //
        // SIDEBAR BUTTON
        //
        private void collapseSidebar()
        {
            if (isToggled)
            {
                PANEL_SIDEBAR.Size = new System.Drawing.Size(320, 1080);
                dashboardLabel.Visible = true;
                sidebarButton.ButtonImage = global::Archivary.Properties.Resources.ICON_SIDEBAR_CLOSE;
                logoPictureBox.Image = global::Archivary.Properties.Resources.ArchivaryLogoBannerPNG;
            }
            else
            {
                PANEL_SIDEBAR.Size = new System.Drawing.Size(80, 1080);
                dashboardLabel.Visible = false;
                sidebarButton.ButtonImage = global::Archivary.Properties.Resources.ICON_SIDEBAR_OPEN;
                logoPictureBox.Image = global::Archivary.Properties.Resources.ArchivaryLogoGreen;
            }
        }
        private void sidebarButton_Click(object sender, EventArgs e)
        {
            isToggled = !isToggled;
            collapseSidebar();
        }

        //
        // LOGOUT BUTTON
        //
        private void logoutButton_Click(object sender, EventArgs e)
        {
            FormsRoot.loadParentForm(new FORM_LOGIN(FormsRoot));
        }

        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            logoutButton.ButtonImage = global::Archivary.Properties.Resources.ICON_LOGOUT_GREEN;
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            logoutButton.ButtonImage = global::Archivary.Properties.Resources.ICON_LOGOUT;
        }

        //
        // LIBRARY BUTTON
        //
        private void libraryButton_Click(object sender, EventArgs e)
        {
            
            FormsLibrary.TopLevel = false;
            PANEL_CONTENTS.Controls.Add( FormsLibrary );
            FormsLibrary.Dock = DockStyle.Fill;
            FormsLibrary.BringToFront();
            FormsLibrary.Show();
        }

        private void libraryButton_MouseEnter(object sender, EventArgs e)
        {
            libraryButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            libraryButton.ButtonImage = global::Archivary.Properties.Resources.ICON_LIBRARY_GREEN;
        }

        private void libraryButton_MouseLeave(object sender, EventArgs e)
        {
            libraryButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            libraryButton.ButtonImage = global::Archivary.Properties.Resources.ICON_LIBRARY;
        }

        //
        // CIRCULATION BUTTON
        //
        private void circulationButton_Click(object sender, EventArgs e)
        {

        }

        private void circulationButton_MouseEnter(object sender, EventArgs e)
        {
            circulationButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            circulationButton.ButtonImage = global::Archivary.Properties.Resources.ICON_CIRCULATION_GREEN;
        }

        private void circulationButton_MouseLeave(object sender, EventArgs e)
        {
            circulationButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            circulationButton.ButtonImage = global::Archivary.Properties.Resources.ICON_CIRCULATION;
        }

        //
        // USER BUTTON
        //
        private void usersButton_Click(object sender, EventArgs e)
        {

        }

        private void usersButton_MouseEnter(object sender, EventArgs e)
        {
            usersButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            usersButton.ButtonImage = global::Archivary.Properties.Resources.ICON_USER_GREEN;
        }

        private void usersButton_MouseLeave(object sender, EventArgs e)
        {
            usersButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            usersButton.ButtonImage = global::Archivary.Properties.Resources.ICON_USER;
        }

        //
        // REPORTS BUTTON
        //
        private void reportsButton_Click(object sender, EventArgs e)
        {

        }

        private void reportsButton_MouseEnter(object sender, EventArgs e)
        {
            reportsButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            reportsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_REPORT_GREEN;
        }

        private void reportsButton_MouseLeave(object sender, EventArgs e)
        {
            reportsButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            reportsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_REPORT;
        }

        //
        // SETTINGS BUTTON
        //
        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            settingsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_SETTING_GREEN;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            settingsButton.ButtonImage = global::Archivary.Properties.Resources.ICON_SETTING;
        }
    }
}

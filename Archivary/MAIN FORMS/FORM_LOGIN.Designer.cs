namespace Archivary.PARENT_FORMS
{
    partial class FORM_LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_LOGIN));
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginSubLabel = new System.Windows.Forms.Label();
            this.usernamePicturebox = new System.Windows.Forms.PictureBox();
            this.passwordPicturebox = new System.Windows.Forms.PictureBox();
            this.logoTitlePictureBox = new System.Windows.Forms.PictureBox();
            this.PANEL_TOPBAR = new System.Windows.Forms.Panel();
            this.PANEL_BACKGROUND = new System.Windows.Forms.Panel();
            this.LAYOUT_EYE = new System.Windows.Forms.Panel();
            this.backButton = new sidebarComponents.sidebarButton();
            this.closeButton = new sidebarComponents.sidebarButton();
            this.eyeButton = new sidebarComponents.sidebarButton();
            this.usernameTextbox = new RoundedCorners.RoundedTextBox();
            this.passwordTextbox = new RoundedCorners.RoundedTextBox();
            this.loginButton = new roundedCorners.roundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTitlePictureBox)).BeginInit();
            this.PANEL_TOPBAR.SuspendLayout();
            this.PANEL_BACKGROUND.SuspendLayout();
            this.LAYOUT_EYE.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Montserrat Black", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.loginLabel.Location = new System.Drawing.Point(57, 193);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(324, 87);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "LOG IN";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginSubLabel
            // 
            this.loginSubLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSubLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.loginSubLabel.Location = new System.Drawing.Point(75, 269);
            this.loginSubLabel.Name = "loginSubLabel";
            this.loginSubLabel.Size = new System.Drawing.Size(376, 36);
            this.loginSubLabel.TabIndex = 0;
            this.loginSubLabel.Text = "Please enter your username and password";
            this.loginSubLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernamePicturebox
            // 
            this.usernamePicturebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.usernamePicturebox.Image = global::Archivary.Properties.Resources.ICON_USER_GREEN;
            this.usernamePicturebox.Location = new System.Drawing.Point(73, 332);
            this.usernamePicturebox.Name = "usernamePicturebox";
            this.usernamePicturebox.Size = new System.Drawing.Size(50, 50);
            this.usernamePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernamePicturebox.TabIndex = 3;
            this.usernamePicturebox.TabStop = false;
            // 
            // passwordPicturebox
            // 
            this.passwordPicturebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.passwordPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("passwordPicturebox.Image")));
            this.passwordPicturebox.Location = new System.Drawing.Point(73, 405);
            this.passwordPicturebox.Name = "passwordPicturebox";
            this.passwordPicturebox.Size = new System.Drawing.Size(50, 50);
            this.passwordPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPicturebox.TabIndex = 3;
            this.passwordPicturebox.TabStop = false;
            // 
            // logoTitlePictureBox
            // 
            this.logoTitlePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoTitlePictureBox.Image = global::Archivary.Properties.Resources.ArchivaryLogo9;
            this.logoTitlePictureBox.Location = new System.Drawing.Point(5, 5);
            this.logoTitlePictureBox.Name = "logoTitlePictureBox";
            this.logoTitlePictureBox.Size = new System.Drawing.Size(950, 50);
            this.logoTitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoTitlePictureBox.TabIndex = 4;
            this.logoTitlePictureBox.TabStop = false;
            this.logoTitlePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoTitlePictureBox_MouseDown);
            // 
            // PANEL_TOPBAR
            // 
            this.PANEL_TOPBAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PANEL_TOPBAR.Controls.Add(this.backButton);
            this.PANEL_TOPBAR.Controls.Add(this.closeButton);
            this.PANEL_TOPBAR.Controls.Add(this.logoTitlePictureBox);
            this.PANEL_TOPBAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_TOPBAR.Location = new System.Drawing.Point(0, 0);
            this.PANEL_TOPBAR.Name = "PANEL_TOPBAR";
            this.PANEL_TOPBAR.Padding = new System.Windows.Forms.Padding(5);
            this.PANEL_TOPBAR.Size = new System.Drawing.Size(960, 60);
            this.PANEL_TOPBAR.TabIndex = 7;
            this.PANEL_TOPBAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PANEL_TOPBAR_MouseDown);
            // 
            // PANEL_BACKGROUND
            // 
            this.PANEL_BACKGROUND.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PANEL_BACKGROUND.BackgroundImage")));
            this.PANEL_BACKGROUND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PANEL_BACKGROUND.Controls.Add(this.LAYOUT_EYE);
            this.PANEL_BACKGROUND.Controls.Add(this.usernameTextbox);
            this.PANEL_BACKGROUND.Controls.Add(this.passwordTextbox);
            this.PANEL_BACKGROUND.Controls.Add(this.loginButton);
            this.PANEL_BACKGROUND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_BACKGROUND.Location = new System.Drawing.Point(0, 0);
            this.PANEL_BACKGROUND.Name = "PANEL_BACKGROUND";
            this.PANEL_BACKGROUND.Size = new System.Drawing.Size(960, 650);
            this.PANEL_BACKGROUND.TabIndex = 8;
            // 
            // LAYOUT_EYE
            // 
            this.LAYOUT_EYE.Controls.Add(this.eyeButton);
            this.LAYOUT_EYE.Location = new System.Drawing.Point(786, 405);
            this.LAYOUT_EYE.Name = "LAYOUT_EYE";
            this.LAYOUT_EYE.Size = new System.Drawing.Size(50, 50);
            this.LAYOUT_EYE.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.backButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.backButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.backButton.BorderRadius = 10;
            this.backButton.BorderSize = 0;
            this.backButton.ButtonImage = global::Archivary.Properties.Resources.ICON_SIDEBAR_CLOSE_GREEN;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.backButton.Location = new System.Drawing.Point(5, 5);
            this.backButton.Margin = new System.Windows.Forms.Padding(1);
            this.backButton.Name = "backButton";
            this.backButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 5;
            this.backButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.closeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.closeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeButton.BorderRadius = 10;
            this.closeButton.BorderSize = 0;
            this.closeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_CLOSE;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(905, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
            this.closeButton.TabIndex = 6;
            this.closeButton.TextColor = System.Drawing.Color.White;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // eyeButton
            // 
            this.eyeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.eyeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.eyeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.eyeButton.BorderRadius = 10;
            this.eyeButton.BorderSize = 0;
            this.eyeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_EYE_SLASH;
            this.eyeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eyeButton.FlatAppearance.BorderSize = 0;
            this.eyeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeButton.ForeColor = System.Drawing.Color.White;
            this.eyeButton.Location = new System.Drawing.Point(0, 0);
            this.eyeButton.Name = "eyeButton";
            this.eyeButton.Size = new System.Drawing.Size(50, 50);
            this.eyeButton.TabIndex = 3;
            this.eyeButton.TextColor = System.Drawing.Color.White;
            this.eyeButton.UseVisualStyleBackColor = false;
            this.eyeButton.Click += new System.EventHandler(this.eyeButton_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.usernameTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.usernameTextbox.BorderColor = System.Drawing.Color.Black;
            this.usernameTextbox.BorderThickness = 0;
            this.usernameTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.usernameTextbox.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.usernameTextbox.Location = new System.Drawing.Point(129, 332);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Radius = 15;
            this.usernameTextbox.Size = new System.Drawing.Size(656, 50);
            this.usernameTextbox.TabIndex = 2;
            this.usernameTextbox.Text = "Enter Username";
            this.usernameTextbox.UseSystemPasswordChar = false;
            this.usernameTextbox.Enter += new System.EventHandler(this.usernameTextbox_Enter);
            this.usernameTextbox.Leave += new System.EventHandler(this.usernameTextbox_Leave);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.passwordTextbox.BorderColor = System.Drawing.Color.Black;
            this.passwordTextbox.BorderThickness = 0;
            this.passwordTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.passwordTextbox.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.passwordTextbox.Location = new System.Drawing.Point(129, 405);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Radius = 15;
            this.passwordTextbox.Size = new System.Drawing.Size(656, 50);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.Text = "Enter Password";
            this.passwordTextbox.UseSystemPasswordChar = true;
            this.passwordTextbox.Enter += new System.EventHandler(this.passwordTextbox_Enter);
            this.passwordTextbox.Leave += new System.EventHandler(this.passwordTextbox_Leave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.loginButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.loginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.loginButton.BorderRadius = 15;
            this.loginButton.BorderSize = 0;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.loginButton.Location = new System.Drawing.Point(293, 480);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(258, 67);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Log In";
            this.loginButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // FORM_LOGIN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.ControlBox = false;
            this.Controls.Add(this.PANEL_TOPBAR);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordPicturebox);
            this.Controls.Add(this.usernamePicturebox);
            this.Controls.Add(this.loginSubLabel);
            this.Controls.Add(this.PANEL_BACKGROUND);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FORM_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTitlePictureBox)).EndInit();
            this.PANEL_TOPBAR.ResumeLayout(false);
            this.PANEL_BACKGROUND.ResumeLayout(false);
            this.LAYOUT_EYE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label loginSubLabel;
        private roundedCorners.roundedButton loginButton;
        private RoundedCorners.RoundedTextBox passwordTextbox;
        private System.Windows.Forms.PictureBox usernamePicturebox;
        private System.Windows.Forms.PictureBox passwordPicturebox;
        private System.Windows.Forms.PictureBox logoTitlePictureBox;
        private sidebarComponents.sidebarButton backButton;
        private sidebarComponents.sidebarButton closeButton;
        private System.Windows.Forms.Panel PANEL_TOPBAR;
        private RoundedCorners.RoundedTextBox usernameTextbox;
        private System.Windows.Forms.Panel PANEL_BACKGROUND;
        private sidebarComponents.sidebarButton eyeButton;
        private System.Windows.Forms.Panel LAYOUT_EYE;
    }
}
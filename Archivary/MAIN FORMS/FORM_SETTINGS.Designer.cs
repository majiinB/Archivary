namespace Archivary.PARENT_FORMS
{
    partial class FORM_SETTINGS
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
            this.LAYOUT_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.PANEL_CONTAINER = new System.Windows.Forms.Panel();
            this.LAYOUT_centerPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.accountPictureBox = new System.Windows.Forms.PictureBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.systemSettingsLabel = new System.Windows.Forms.Label();
            this.borrowingCapacityLabel = new System.Windows.Forms.Label();
            this.reserveLimitLabel = new System.Windows.Forms.Label();
            this.borrowingDurationLabel = new System.Windows.Forms.Label();
            this.borrowingDurationTextbox = new RoundedCorners.RoundedTextBox();
            this.reserveLimitTextbox = new RoundedCorners.RoundedTextBox();
            this.borrowingCapacityTextbox = new RoundedCorners.RoundedTextBox();
            this.cityTextbox = new RoundedCorners.RoundedTextBox();
            this.streetTextbox = new RoundedCorners.RoundedTextBox();
            this.barangayTextbox = new RoundedCorners.RoundedTextBox();
            this.houseNumberTextbox = new RoundedCorners.RoundedTextBox();
            this.contactNumberTextbox = new RoundedCorners.RoundedTextBox();
            this.emailTextbox = new RoundedCorners.RoundedTextBox();
            this.middleNameTextbox = new RoundedCorners.RoundedTextBox();
            this.firstNameTextbox = new RoundedCorners.RoundedTextBox();
            this.lastNameTextbox = new RoundedCorners.RoundedTextBox();
            this.saveButton = new roundedCorners.roundedButton();
            this.editButton = new roundedCorners.roundedButton();
            this.LAYOUT_buttons.SuspendLayout();
            this.PANEL_CONTAINER.SuspendLayout();
            this.LAYOUT_centerPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LAYOUT_buttons
            // 
            this.LAYOUT_buttons.ColumnCount = 2;
            this.LAYOUT_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_buttons.Controls.Add(this.saveButton, 1, 0);
            this.LAYOUT_buttons.Controls.Add(this.editButton, 0, 0);
            this.LAYOUT_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LAYOUT_buttons.Location = new System.Drawing.Point(0, 570);
            this.LAYOUT_buttons.Name = "LAYOUT_buttons";
            this.LAYOUT_buttons.Padding = new System.Windows.Forms.Padding(10);
            this.LAYOUT_buttons.RowCount = 1;
            this.LAYOUT_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_buttons.Size = new System.Drawing.Size(960, 100);
            this.LAYOUT_buttons.TabIndex = 1;
            // 
            // PANEL_CONTAINER
            // 
            this.PANEL_CONTAINER.Controls.Add(this.LAYOUT_centerPanel);
            this.PANEL_CONTAINER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTAINER.Location = new System.Drawing.Point(0, 0);
            this.PANEL_CONTAINER.Name = "PANEL_CONTAINER";
            this.PANEL_CONTAINER.Size = new System.Drawing.Size(960, 570);
            this.PANEL_CONTAINER.TabIndex = 2;
            // 
            // LAYOUT_centerPanel
            // 
            this.LAYOUT_centerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAYOUT_centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LAYOUT_centerPanel.Controls.Add(this.centerPanel);
            this.LAYOUT_centerPanel.Location = new System.Drawing.Point(13, 12);
            this.LAYOUT_centerPanel.Name = "LAYOUT_centerPanel";
            this.LAYOUT_centerPanel.Padding = new System.Windows.Forms.Padding(3);
            this.LAYOUT_centerPanel.Size = new System.Drawing.Size(934, 534);
            this.LAYOUT_centerPanel.TabIndex = 0;
            // 
            // centerPanel
            // 
            this.centerPanel.AutoScroll = true;
            this.centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.centerPanel.Controls.Add(this.borrowingDurationTextbox);
            this.centerPanel.Controls.Add(this.borrowingDurationLabel);
            this.centerPanel.Controls.Add(this.reserveLimitTextbox);
            this.centerPanel.Controls.Add(this.reserveLimitLabel);
            this.centerPanel.Controls.Add(this.borrowingCapacityTextbox);
            this.centerPanel.Controls.Add(this.borrowingCapacityLabel);
            this.centerPanel.Controls.Add(this.systemSettingsLabel);
            this.centerPanel.Controls.Add(this.cityTextbox);
            this.centerPanel.Controls.Add(this.streetTextbox);
            this.centerPanel.Controls.Add(this.barangayTextbox);
            this.centerPanel.Controls.Add(this.houseNumberTextbox);
            this.centerPanel.Controls.Add(this.addressLabel);
            this.centerPanel.Controls.Add(this.contactNumberTextbox);
            this.centerPanel.Controls.Add(this.contactNumberLabel);
            this.centerPanel.Controls.Add(this.emailTextbox);
            this.centerPanel.Controls.Add(this.emailLabel);
            this.centerPanel.Controls.Add(this.middleNameTextbox);
            this.centerPanel.Controls.Add(this.middleNameLabel);
            this.centerPanel.Controls.Add(this.accountPictureBox);
            this.centerPanel.Controls.Add(this.firstNameTextbox);
            this.centerPanel.Controls.Add(this.firstNameLabel);
            this.centerPanel.Controls.Add(this.lastNameTextbox);
            this.centerPanel.Controls.Add(this.lastNameLabel);
            this.centerPanel.Controls.Add(this.userID);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(3, 3);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(928, 528);
            this.centerPanel.TabIndex = 0;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.middleNameLabel.Location = new System.Drawing.Point(25, 327);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(129, 24);
            this.middleNameLabel.TabIndex = 6;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // accountPictureBox
            // 
            this.accountPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.accountPictureBox.Location = new System.Drawing.Point(585, 113);
            this.accountPictureBox.Name = "accountPictureBox";
            this.accountPictureBox.Size = new System.Drawing.Size(300, 300);
            this.accountPictureBox.TabIndex = 5;
            this.accountPictureBox.TabStop = false;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.firstNameLabel.Location = new System.Drawing.Point(25, 214);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(107, 24);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.lastNameLabel.Location = new System.Drawing.Point(25, 104);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(104, 24);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // userID
            // 
            this.userID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userID.Font = new System.Drawing.Font("Montserrat Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.userID.Location = new System.Drawing.Point(25, 18);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(866, 71);
            this.userID.TabIndex = 0;
            this.userID.Text = "E1436969143";
            this.userID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.emailLabel.Location = new System.Drawing.Point(25, 435);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 24);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.contactNumberLabel.Location = new System.Drawing.Point(502, 435);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(158, 24);
            this.contactNumberLabel.TabIndex = 10;
            this.contactNumberLabel.Text = "Contact Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.addressLabel.Location = new System.Drawing.Point(25, 535);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(142, 24);
            this.addressLabel.TabIndex = 12;
            this.addressLabel.Text = "Home Address";
            // 
            // systemSettingsLabel
            // 
            this.systemSettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemSettingsLabel.Font = new System.Drawing.Font("Montserrat Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.systemSettingsLabel.Location = new System.Drawing.Point(19, 698);
            this.systemSettingsLabel.Name = "systemSettingsLabel";
            this.systemSettingsLabel.Size = new System.Drawing.Size(866, 61);
            this.systemSettingsLabel.TabIndex = 17;
            this.systemSettingsLabel.Text = "System Settings";
            this.systemSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // borrowingCapacityLabel
            // 
            this.borrowingCapacityLabel.AutoSize = true;
            this.borrowingCapacityLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingCapacityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.borrowingCapacityLabel.Location = new System.Drawing.Point(22, 768);
            this.borrowingCapacityLabel.Name = "borrowingCapacityLabel";
            this.borrowingCapacityLabel.Size = new System.Drawing.Size(185, 24);
            this.borrowingCapacityLabel.TabIndex = 18;
            this.borrowingCapacityLabel.Text = "Borrowing Capacity";
            // 
            // reserveLimitLabel
            // 
            this.reserveLimitLabel.AutoSize = true;
            this.reserveLimitLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLimitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.reserveLimitLabel.Location = new System.Drawing.Point(25, 868);
            this.reserveLimitLabel.Name = "reserveLimitLabel";
            this.reserveLimitLabel.Size = new System.Drawing.Size(131, 24);
            this.reserveLimitLabel.TabIndex = 20;
            this.reserveLimitLabel.Text = "Reserve Limit";
            // 
            // borrowingDurationLabel
            // 
            this.borrowingDurationLabel.AutoSize = true;
            this.borrowingDurationLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingDurationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.borrowingDurationLabel.Location = new System.Drawing.Point(25, 970);
            this.borrowingDurationLabel.Name = "borrowingDurationLabel";
            this.borrowingDurationLabel.Size = new System.Drawing.Size(186, 24);
            this.borrowingDurationLabel.TabIndex = 22;
            this.borrowingDurationLabel.Text = "Borrowing Duration";
            // 
            // borrowingDurationTextbox
            // 
            this.borrowingDurationTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowingDurationTextbox.BackColor = System.Drawing.Color.Transparent;
            this.borrowingDurationTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.borrowingDurationTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.borrowingDurationTextbox.BorderThickness = 0;
            this.borrowingDurationTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.borrowingDurationTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingDurationTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.borrowingDurationTextbox.Location = new System.Drawing.Point(26, 1006);
            this.borrowingDurationTextbox.Name = "borrowingDurationTextbox";
            this.borrowingDurationTextbox.Radius = 10;
            this.borrowingDurationTextbox.Size = new System.Drawing.Size(862, 50);
            this.borrowingDurationTextbox.TabIndex = 23;
            this.borrowingDurationTextbox.Text = "<0000>";
            this.borrowingDurationTextbox.UseSystemPasswordChar = false;
            // 
            // reserveLimitTextbox
            // 
            this.reserveLimitTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reserveLimitTextbox.BackColor = System.Drawing.Color.Transparent;
            this.reserveLimitTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.reserveLimitTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.reserveLimitTextbox.BorderThickness = 0;
            this.reserveLimitTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.reserveLimitTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLimitTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.reserveLimitTextbox.Location = new System.Drawing.Point(26, 904);
            this.reserveLimitTextbox.Name = "reserveLimitTextbox";
            this.reserveLimitTextbox.Radius = 10;
            this.reserveLimitTextbox.Size = new System.Drawing.Size(862, 50);
            this.reserveLimitTextbox.TabIndex = 21;
            this.reserveLimitTextbox.Text = "<0000>";
            this.reserveLimitTextbox.UseSystemPasswordChar = false;
            // 
            // borrowingCapacityTextbox
            // 
            this.borrowingCapacityTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowingCapacityTextbox.BackColor = System.Drawing.Color.Transparent;
            this.borrowingCapacityTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.borrowingCapacityTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.borrowingCapacityTextbox.BorderThickness = 0;
            this.borrowingCapacityTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.borrowingCapacityTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingCapacityTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.borrowingCapacityTextbox.Location = new System.Drawing.Point(23, 804);
            this.borrowingCapacityTextbox.Name = "borrowingCapacityTextbox";
            this.borrowingCapacityTextbox.Radius = 10;
            this.borrowingCapacityTextbox.Size = new System.Drawing.Size(862, 50);
            this.borrowingCapacityTextbox.TabIndex = 19;
            this.borrowingCapacityTextbox.Text = "<0000>";
            this.borrowingCapacityTextbox.UseSystemPasswordChar = false;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextbox.BackColor = System.Drawing.Color.Transparent;
            this.cityTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cityTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cityTextbox.BorderThickness = 0;
            this.cityTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cityTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cityTextbox.Location = new System.Drawing.Point(443, 632);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Radius = 10;
            this.cityTextbox.Size = new System.Drawing.Size(442, 50);
            this.cityTextbox.TabIndex = 16;
            this.cityTextbox.Text = "Makati";
            this.cityTextbox.UseSystemPasswordChar = false;
            // 
            // streetTextbox
            // 
            this.streetTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.streetTextbox.BackColor = System.Drawing.Color.Transparent;
            this.streetTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.streetTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.streetTextbox.BorderThickness = 0;
            this.streetTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.streetTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.streetTextbox.Location = new System.Drawing.Point(443, 571);
            this.streetTextbox.Name = "streetTextbox";
            this.streetTextbox.Radius = 10;
            this.streetTextbox.Size = new System.Drawing.Size(442, 50);
            this.streetTextbox.TabIndex = 15;
            this.streetTextbox.Text = "Ayala St.";
            this.streetTextbox.UseSystemPasswordChar = false;
            // 
            // barangayTextbox
            // 
            this.barangayTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barangayTextbox.BackColor = System.Drawing.Color.Transparent;
            this.barangayTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.barangayTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.barangayTextbox.BorderThickness = 0;
            this.barangayTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.barangayTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangayTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.barangayTextbox.Location = new System.Drawing.Point(26, 632);
            this.barangayTextbox.Name = "barangayTextbox";
            this.barangayTextbox.Radius = 10;
            this.barangayTextbox.Size = new System.Drawing.Size(405, 50);
            this.barangayTextbox.TabIndex = 14;
            this.barangayTextbox.Text = "Comembo";
            this.barangayTextbox.UseSystemPasswordChar = false;
            // 
            // houseNumberTextbox
            // 
            this.houseNumberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.houseNumberTextbox.BackColor = System.Drawing.Color.Transparent;
            this.houseNumberTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.houseNumberTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.houseNumberTextbox.BorderThickness = 0;
            this.houseNumberTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.houseNumberTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseNumberTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.houseNumberTextbox.Location = new System.Drawing.Point(26, 571);
            this.houseNumberTextbox.Name = "houseNumberTextbox";
            this.houseNumberTextbox.Radius = 10;
            this.houseNumberTextbox.Size = new System.Drawing.Size(405, 50);
            this.houseNumberTextbox.TabIndex = 13;
            this.houseNumberTextbox.Text = "143 - A";
            this.houseNumberTextbox.UseSystemPasswordChar = false;
            // 
            // contactNumberTextbox
            // 
            this.contactNumberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contactNumberTextbox.BackColor = System.Drawing.Color.Transparent;
            this.contactNumberTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.contactNumberTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.contactNumberTextbox.BorderThickness = 0;
            this.contactNumberTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.contactNumberTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.contactNumberTextbox.Location = new System.Drawing.Point(502, 471);
            this.contactNumberTextbox.Name = "contactNumberTextbox";
            this.contactNumberTextbox.Radius = 10;
            this.contactNumberTextbox.Size = new System.Drawing.Size(383, 50);
            this.contactNumberTextbox.TabIndex = 11;
            this.contactNumberTextbox.Text = "09691436969";
            this.contactNumberTextbox.UseSystemPasswordChar = false;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextbox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.emailTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.emailTextbox.BorderThickness = 0;
            this.emailTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.emailTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.emailTextbox.Location = new System.Drawing.Point(26, 471);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Radius = 10;
            this.emailTextbox.Size = new System.Drawing.Size(463, 50);
            this.emailTextbox.TabIndex = 9;
            this.emailTextbox.Text = "arthurpogi69@gmail.com";
            this.emailTextbox.UseSystemPasswordChar = false;
            // 
            // middleNameTextbox
            // 
            this.middleNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.middleNameTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.middleNameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.middleNameTextbox.BorderThickness = 0;
            this.middleNameTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.middleNameTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.middleNameTextbox.Location = new System.Drawing.Point(26, 363);
            this.middleNameTextbox.Name = "middleNameTextbox";
            this.middleNameTextbox.Radius = 10;
            this.middleNameTextbox.Size = new System.Drawing.Size(539, 50);
            this.middleNameTextbox.TabIndex = 7;
            this.middleNameTextbox.Text = "Montenegromayora";
            this.middleNameTextbox.UseSystemPasswordChar = false;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.firstNameTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.firstNameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.firstNameTextbox.BorderThickness = 0;
            this.firstNameTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.firstNameTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.firstNameTextbox.Location = new System.Drawing.Point(26, 251);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Radius = 10;
            this.firstNameTextbox.Size = new System.Drawing.Size(539, 50);
            this.firstNameTextbox.TabIndex = 4;
            this.firstNameTextbox.Text = "Arthur Morgan";
            this.firstNameTextbox.UseSystemPasswordChar = false;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.lastNameTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lastNameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lastNameTextbox.BorderThickness = 0;
            this.lastNameTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lastNameTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lastNameTextbox.Location = new System.Drawing.Point(26, 140);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Radius = 10;
            this.lastNameTextbox.Size = new System.Drawing.Size(539, 50);
            this.lastNameTextbox.TabIndex = 2;
            this.lastNameTextbox.Text = "Artugue";
            this.lastNameTextbox.UseSystemPasswordChar = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.saveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.saveButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveButton.BorderRadius = 20;
            this.saveButton.BorderSize = 0;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Montserrat Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(483, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(464, 74);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.TextColor = System.Drawing.Color.White;
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editButton.BorderRadius = 20;
            this.editButton.BorderSize = 0;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Montserrat Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(13, 13);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(464, 74);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.TextColor = System.Drawing.Color.White;
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // FORM_SETTINGS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.PANEL_CONTAINER);
            this.Controls.Add(this.LAYOUT_buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_SETTINGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_SETTINGS";
            this.Load += new System.EventHandler(this.FORM_SETTINGS_Load);
            this.Resize += new System.EventHandler(this.FORM_SETTINGS_Resize);
            this.LAYOUT_buttons.ResumeLayout(false);
            this.PANEL_CONTAINER.ResumeLayout(false);
            this.LAYOUT_centerPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private roundedCorners.roundedButton saveButton;
        private roundedCorners.roundedButton editButton;
        private System.Windows.Forms.TableLayoutPanel LAYOUT_buttons;
        private System.Windows.Forms.Panel PANEL_CONTAINER;
        private System.Windows.Forms.Panel LAYOUT_centerPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label userID;
        private RoundedCorners.RoundedTextBox lastNameTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private RoundedCorners.RoundedTextBox firstNameTextbox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.PictureBox accountPictureBox;
        private RoundedCorners.RoundedTextBox middleNameTextbox;
        private System.Windows.Forms.Label middleNameLabel;
        private RoundedCorners.RoundedTextBox emailTextbox;
        private System.Windows.Forms.Label emailLabel;
        private RoundedCorners.RoundedTextBox contactNumberTextbox;
        private System.Windows.Forms.Label contactNumberLabel;
        private RoundedCorners.RoundedTextBox cityTextbox;
        private RoundedCorners.RoundedTextBox streetTextbox;
        private RoundedCorners.RoundedTextBox barangayTextbox;
        private RoundedCorners.RoundedTextBox houseNumberTextbox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label systemSettingsLabel;
        private RoundedCorners.RoundedTextBox reserveLimitTextbox;
        private System.Windows.Forms.Label reserveLimitLabel;
        private RoundedCorners.RoundedTextBox borrowingCapacityTextbox;
        private System.Windows.Forms.Label borrowingCapacityLabel;
        private RoundedCorners.RoundedTextBox borrowingDurationTextbox;
        private System.Windows.Forms.Label borrowingDurationLabel;
    }
}
namespace Archivary._1200X800.FORM_USERS
{
    partial class FORM_EDITEMPLOYEE
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
            this.PANEL_CONTENTS = new System.Windows.Forms.Panel();
            this.contents_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.middleInitialLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new RoundedCorners.RoundedTextBox();
            this.firstNameTextBox = new RoundedCorners.RoundedTextBox();
            this.middleInitialTextBox = new RoundedCorners.RoundedTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.houseNumberLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new RoundedCorners.RoundedTextBox();
            this.contactNumberTextBox = new RoundedCorners.RoundedTextBox();
            this.barangayLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new RoundedCorners.RoundedTextBox();
            this.barangayTextBox = new RoundedCorners.RoundedTextBox();
            this.cityTextBox = new RoundedCorners.RoundedTextBox();
            this.houseNumberTextBox = new RoundedCorners.RoundedTextBox();
            this.buttons_Container = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new roundedCorners.roundedButton();
            this.saveButton = new roundedCorners.roundedButton();
            this.uploadImageButton = new roundedCorners.roundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmployeeRoleLabel = new System.Windows.Forms.Label();
            this.editInformationLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PANEL_CONTENTS.SuspendLayout();
            this.contents_TableLayoutPanel.SuspendLayout();
            this.buttons_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_CONTENTS
            // 
            this.PANEL_CONTENTS.AutoScroll = true;
            this.PANEL_CONTENTS.Controls.Add(this.contents_TableLayoutPanel);
            this.PANEL_CONTENTS.Controls.Add(this.EmployeeRoleLabel);
            this.PANEL_CONTENTS.Controls.Add(this.editInformationLabel);
            this.PANEL_CONTENTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTENTS.Location = new System.Drawing.Point(2, 2);
            this.PANEL_CONTENTS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PANEL_CONTENTS.Name = "PANEL_CONTENTS";
            this.PANEL_CONTENTS.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PANEL_CONTENTS.Size = new System.Drawing.Size(716, 540);
            this.PANEL_CONTENTS.TabIndex = 0;
            this.PANEL_CONTENTS.Paint += new System.Windows.Forms.PaintEventHandler(this.PANEL_CONTENTS_Paint);
            // 
            // contents_TableLayoutPanel
            // 
            this.contents_TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contents_TableLayoutPanel.ColumnCount = 7;
            this.contents_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.54054F));
            this.contents_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.48648F));
            this.contents_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.432431F));
            this.contents_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.432431F));
            this.contents_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.81081F));
            this.contents_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.486486F));
            this.contents_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.81081F));
            this.contents_TableLayoutPanel.Controls.Add(this.middleInitialLabel, 4, 0);
            this.contents_TableLayoutPanel.Controls.Add(this.firstNameLabel, 1, 0);
            this.contents_TableLayoutPanel.Controls.Add(this.lastNameLabel, 0, 0);
            this.contents_TableLayoutPanel.Controls.Add(this.lastNameTextBox, 0, 1);
            this.contents_TableLayoutPanel.Controls.Add(this.firstNameTextBox, 1, 1);
            this.contents_TableLayoutPanel.Controls.Add(this.middleInitialTextBox, 4, 1);
            this.contents_TableLayoutPanel.Controls.Add(this.emailLabel, 0, 2);
            this.contents_TableLayoutPanel.Controls.Add(this.houseNumberLabel, 0, 4);
            this.contents_TableLayoutPanel.Controls.Add(this.cityLabel, 4, 4);
            this.contents_TableLayoutPanel.Controls.Add(this.contactNumberLabel, 2, 2);
            this.contents_TableLayoutPanel.Controls.Add(this.emailTextBox, 0, 3);
            this.contents_TableLayoutPanel.Controls.Add(this.contactNumberTextBox, 2, 3);
            this.contents_TableLayoutPanel.Controls.Add(this.barangayLabel, 2, 4);
            this.contents_TableLayoutPanel.Controls.Add(this.streetLabel, 1, 4);
            this.contents_TableLayoutPanel.Controls.Add(this.streetTextBox, 1, 5);
            this.contents_TableLayoutPanel.Controls.Add(this.barangayTextBox, 2, 5);
            this.contents_TableLayoutPanel.Controls.Add(this.cityTextBox, 4, 5);
            this.contents_TableLayoutPanel.Controls.Add(this.houseNumberTextBox, 0, 5);
            this.contents_TableLayoutPanel.Controls.Add(this.buttons_Container, 0, 6);
            this.contents_TableLayoutPanel.Controls.Add(this.uploadImageButton, 6, 5);
            this.contents_TableLayoutPanel.Controls.Add(this.pictureBox1, 6, 0);
            this.contents_TableLayoutPanel.Location = new System.Drawing.Point(3, 159);
            this.contents_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contents_TableLayoutPanel.Name = "contents_TableLayoutPanel";
            this.contents_TableLayoutPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.contents_TableLayoutPanel.RowCount = 7;
            this.contents_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.81531F));
            this.contents_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69371F));
            this.contents_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7726F));
            this.contents_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69242F));
            this.contents_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.81982F));
            this.contents_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69242F));
            this.contents_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.51372F));
            this.contents_TableLayoutPanel.Size = new System.Drawing.Size(705, 349);
            this.contents_TableLayoutPanel.TabIndex = 5;
            // 
            // middleInitialLabel
            // 
            this.middleInitialLabel.AutoSize = true;
            this.middleInitialLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleInitialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleInitialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.middleInitialLabel.Location = new System.Drawing.Point(366, 8);
            this.middleInitialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.middleInitialLabel.Name = "middleInitialLabel";
            this.middleInitialLabel.Size = new System.Drawing.Size(125, 42);
            this.middleInitialLabel.TabIndex = 13;
            this.middleInitialLabel.Text = "M.I";
            this.middleInitialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.contents_TableLayoutPanel.SetColumnSpan(this.firstNameLabel, 3);
            this.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.firstNameLabel.Location = new System.Drawing.Point(151, 8);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(211, 42);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lastNameLabel.Location = new System.Drawing.Point(10, 8);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(137, 42);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.lastNameTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lastNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lastNameTextBox.BorderThickness = 0;
            this.lastNameTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(10, 52);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Radius = 10;
            this.lastNameTextBox.Size = new System.Drawing.Size(137, 34);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Text = "Swift";
            this.lastNameTextBox.UseSystemPasswordChar = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.firstNameTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.firstNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.firstNameTextBox.BorderThickness = 0;
            this.firstNameTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.contents_TableLayoutPanel.SetColumnSpan(this.firstNameTextBox, 3);
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(151, 52);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Radius = 10;
            this.firstNameTextBox.Size = new System.Drawing.Size(211, 34);
            this.firstNameTextBox.TabIndex = 4;
            this.firstNameTextBox.Text = "Taylor";
            this.firstNameTextBox.UseSystemPasswordChar = false;
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.BackColor = System.Drawing.Color.Transparent;
            this.middleInitialTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.middleInitialTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.middleInitialTextBox.BorderThickness = 0;
            this.middleInitialTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.middleInitialTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleInitialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleInitialTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.middleInitialTextBox.Location = new System.Drawing.Point(366, 52);
            this.middleInitialTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.Radius = 10;
            this.middleInitialTextBox.Size = new System.Drawing.Size(125, 34);
            this.middleInitialTextBox.TabIndex = 14;
            this.middleInitialTextBox.Text = "A.";
            this.middleInitialTextBox.UseSystemPasswordChar = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.contents_TableLayoutPanel.SetColumnSpan(this.emailLabel, 2);
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.emailLabel.Location = new System.Drawing.Point(10, 88);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(236, 42);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // houseNumberLabel
            // 
            this.houseNumberLabel.AutoSize = true;
            this.houseNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.houseNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.houseNumberLabel.Location = new System.Drawing.Point(10, 168);
            this.houseNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.houseNumberLabel.Name = "houseNumberLabel";
            this.houseNumberLabel.Size = new System.Drawing.Size(137, 42);
            this.houseNumberLabel.TabIndex = 19;
            this.houseNumberLabel.Text = "House No.";
            this.houseNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cityLabel.Location = new System.Drawing.Point(366, 168);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(125, 42);
            this.cityLabel.TabIndex = 23;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contents_TableLayoutPanel.SetColumnSpan(this.contactNumberLabel, 3);
            this.contactNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.contactNumberLabel.Location = new System.Drawing.Point(250, 88);
            this.contactNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(241, 42);
            this.contactNumberLabel.TabIndex = 17;
            this.contactNumberLabel.Text = "Contact No.";
            this.contactNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.emailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.emailTextBox.BorderThickness = 0;
            this.emailTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.contents_TableLayoutPanel.SetColumnSpan(this.emailTextBox, 2);
            this.emailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.emailTextBox.Location = new System.Drawing.Point(10, 132);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Radius = 10;
            this.emailTextBox.Size = new System.Drawing.Size(236, 34);
            this.emailTextBox.TabIndex = 30;
            this.emailTextBox.Text = "someone@example.com";
            this.emailTextBox.UseSystemPasswordChar = false;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.BackColor = System.Drawing.Color.Transparent;
            this.contactNumberTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.contactNumberTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.contactNumberTextBox.BorderThickness = 0;
            this.contactNumberTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.contents_TableLayoutPanel.SetColumnSpan(this.contactNumberTextBox, 3);
            this.contactNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.contactNumberTextBox.Location = new System.Drawing.Point(250, 132);
            this.contactNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Radius = 10;
            this.contactNumberTextBox.Size = new System.Drawing.Size(241, 34);
            this.contactNumberTextBox.TabIndex = 31;
            this.contactNumberTextBox.Text = "09XXXXXXXXX";
            this.contactNumberTextBox.UseSystemPasswordChar = false;
            // 
            // barangayLabel
            // 
            this.barangayLabel.AutoSize = true;
            this.contents_TableLayoutPanel.SetColumnSpan(this.barangayLabel, 2);
            this.barangayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barangayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.barangayLabel.Location = new System.Drawing.Point(250, 168);
            this.barangayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.barangayLabel.Name = "barangayLabel";
            this.barangayLabel.Size = new System.Drawing.Size(112, 42);
            this.barangayLabel.TabIndex = 22;
            this.barangayLabel.Text = "Barangay";
            this.barangayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.streetLabel.Location = new System.Drawing.Point(151, 168);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(95, 42);
            this.streetLabel.TabIndex = 32;
            this.streetLabel.Text = "Street";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // streetTextBox
            // 
            this.streetTextBox.BackColor = System.Drawing.Color.Transparent;
            this.streetTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.streetTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.streetTextBox.BorderThickness = 0;
            this.streetTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.streetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.streetTextBox.Location = new System.Drawing.Point(151, 212);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Radius = 10;
            this.streetTextBox.Size = new System.Drawing.Size(95, 34);
            this.streetTextBox.TabIndex = 36;
            this.streetTextBox.Text = "Cornelia";
            this.streetTextBox.UseSystemPasswordChar = false;
            // 
            // barangayTextBox
            // 
            this.barangayTextBox.BackColor = System.Drawing.Color.Transparent;
            this.barangayTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.barangayTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.barangayTextBox.BorderThickness = 0;
            this.barangayTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.contents_TableLayoutPanel.SetColumnSpan(this.barangayTextBox, 2);
            this.barangayTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barangayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangayTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.barangayTextBox.Location = new System.Drawing.Point(250, 212);
            this.barangayTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barangayTextBox.Name = "barangayTextBox";
            this.barangayTextBox.Radius = 10;
            this.barangayTextBox.Size = new System.Drawing.Size(112, 34);
            this.barangayTextBox.TabIndex = 37;
            this.barangayTextBox.Text = "Camden";
            this.barangayTextBox.UseSystemPasswordChar = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.Color.Transparent;
            this.cityTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cityTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cityTextBox.BorderThickness = 0;
            this.cityTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cityTextBox.Location = new System.Drawing.Point(366, 212);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Radius = 10;
            this.cityTextBox.Size = new System.Drawing.Size(125, 34);
            this.cityTextBox.TabIndex = 38;
            this.cityTextBox.Text = "London";
            this.cityTextBox.UseSystemPasswordChar = false;
            // 
            // houseNumberTextBox
            // 
            this.houseNumberTextBox.BackColor = System.Drawing.Color.Transparent;
            this.houseNumberTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.houseNumberTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.houseNumberTextBox.BorderThickness = 0;
            this.houseNumberTextBox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.houseNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.houseNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.houseNumberTextBox.Location = new System.Drawing.Point(10, 212);
            this.houseNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.houseNumberTextBox.Name = "houseNumberTextBox";
            this.houseNumberTextBox.Radius = 10;
            this.houseNumberTextBox.Size = new System.Drawing.Size(137, 34);
            this.houseNumberTextBox.TabIndex = 35;
            this.houseNumberTextBox.Text = "21st Avenue";
            this.houseNumberTextBox.UseSystemPasswordChar = false;
            // 
            // buttons_Container
            // 
            this.buttons_Container.ColumnCount = 3;
            this.contents_TableLayoutPanel.SetColumnSpan(this.buttons_Container, 7);
            this.buttons_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.56522F));
            this.buttons_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8695652F));
            this.buttons_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.56522F));
            this.buttons_Container.Controls.Add(this.cancelButton, 0, 0);
            this.buttons_Container.Controls.Add(this.saveButton, 2, 0);
            this.buttons_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons_Container.Location = new System.Drawing.Point(10, 250);
            this.buttons_Container.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttons_Container.Name = "buttons_Container";
            this.buttons_Container.RowCount = 1;
            this.buttons_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttons_Container.Size = new System.Drawing.Size(685, 89);
            this.buttons_Container.TabIndex = 40;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cancelButton.BorderRadius = 10;
            this.cancelButton.BorderSize = 2;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cancelButton.Location = new System.Drawing.Point(2, 40);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(335, 47);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.saveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.saveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.saveButton.BorderRadius = 10;
            this.saveButton.BorderSize = 0;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.saveButton.Location = new System.Drawing.Point(346, 40);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(337, 47);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // uploadImageButton
            // 
            this.uploadImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.uploadImageButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.uploadImageButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.uploadImageButton.BorderRadius = 10;
            this.uploadImageButton.BorderSize = 0;
            this.uploadImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadImageButton.FlatAppearance.BorderSize = 0;
            this.uploadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uploadImageButton.Location = new System.Drawing.Point(512, 212);
            this.uploadImageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadImageButton.Name = "uploadImageButton";
            this.uploadImageButton.Size = new System.Drawing.Size(183, 34);
            this.uploadImageButton.TabIndex = 34;
            this.uploadImageButton.Text = "Upload Image";
            this.uploadImageButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uploadImageButton.UseVisualStyleBackColor = false;
            this.uploadImageButton.Click += new System.EventHandler(this.uploadImageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(512, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.contents_TableLayoutPanel.SetRowSpan(this.pictureBox1, 5);
            this.pictureBox1.Size = new System.Drawing.Size(183, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeRoleLabel
            // 
            this.EmployeeRoleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.EmployeeRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EmployeeRoleLabel.Location = new System.Drawing.Point(16, 124);
            this.EmployeeRoleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeRoleLabel.Name = "EmployeeRoleLabel";
            this.EmployeeRoleLabel.Size = new System.Drawing.Size(172, 24);
            this.EmployeeRoleLabel.TabIndex = 4;
            this.EmployeeRoleLabel.Text = "Employee";
            this.EmployeeRoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editInformationLabel
            // 
            this.editInformationLabel.AutoSize = true;
            this.editInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInformationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editInformationLabel.Location = new System.Drawing.Point(2, 49);
            this.editInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editInformationLabel.Name = "editInformationLabel";
            this.editInformationLabel.Size = new System.Drawing.Size(497, 55);
            this.editInformationLabel.TabIndex = 3;
            this.editInformationLabel.Text = "EDIT INFORMATION";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FORM_EDITEMPLOYEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(720, 544);
            this.Controls.Add(this.PANEL_CONTENTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FORM_EDITEMPLOYEE";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_EDITEMPLYEE";
            this.Load += new System.EventHandler(this.FORM_EDITEMPLYEE_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FORM_EDITEMPLYEE_Paint);
            this.PANEL_CONTENTS.ResumeLayout(false);
            this.PANEL_CONTENTS.PerformLayout();
            this.contents_TableLayoutPanel.ResumeLayout(false);
            this.contents_TableLayoutPanel.PerformLayout();
            this.buttons_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_CONTENTS;
        private System.Windows.Forms.Label EmployeeRoleLabel;
        private System.Windows.Forms.Label editInformationLabel;
        private System.Windows.Forms.TableLayoutPanel contents_TableLayoutPanel;
        private System.Windows.Forms.Label middleInitialLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private RoundedCorners.RoundedTextBox lastNameTextBox;
        private RoundedCorners.RoundedTextBox firstNameTextBox;
        private RoundedCorners.RoundedTextBox middleInitialTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label houseNumberLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label contactNumberLabel;
        private RoundedCorners.RoundedTextBox emailTextBox;
        private RoundedCorners.RoundedTextBox contactNumberTextBox;
        private System.Windows.Forms.Label barangayLabel;
        private System.Windows.Forms.Label streetLabel;
        private RoundedCorners.RoundedTextBox streetTextBox;
        private RoundedCorners.RoundedTextBox barangayTextBox;
        private RoundedCorners.RoundedTextBox cityTextBox;
        private RoundedCorners.RoundedTextBox houseNumberTextBox;
        private roundedCorners.roundedButton uploadImageButton;
        private System.Windows.Forms.TableLayoutPanel buttons_Container;
        private roundedCorners.roundedButton cancelButton;
        private roundedCorners.roundedButton saveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
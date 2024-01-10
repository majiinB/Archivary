namespace Archivary._1500X1000.FORM_LIBRARY
{
    partial class FORM_BOOKINFO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_BOOKINFO));
            this.PANEL_CONTENTS = new System.Windows.Forms.Panel();
            this.cancelButton = new roundedCorners.roundedButton();
            this.editInfoButton = new roundedCorners.roundedButton();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.ISBNTextbox = new RoundedCorners.RoundedTextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorTextbox = new RoundedCorners.RoundedTextBox();
            this.shelfLabel = new System.Windows.Forms.Label();
            this.aisleLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publisherTextbox = new RoundedCorners.RoundedTextBox();
            this.copyrightTextbox = new RoundedCorners.RoundedTextBox();
            this.aisleTextbox = new RoundedCorners.RoundedTextBox();
            this.shelfTextbox = new RoundedCorners.RoundedTextBox();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            this.booktitleLabel = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PANEL_CONTENTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_CONTENTS
            // 
            this.PANEL_CONTENTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PANEL_CONTENTS.Controls.Add(this.tableLayoutPanel1);
            this.PANEL_CONTENTS.Controls.Add(this.cancelButton);
            this.PANEL_CONTENTS.Controls.Add(this.editInfoButton);
            this.PANEL_CONTENTS.Controls.Add(this.booktitleLabel);
            this.PANEL_CONTENTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTENTS.Location = new System.Drawing.Point(3, 2);
            this.PANEL_CONTENTS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PANEL_CONTENTS.Name = "PANEL_CONTENTS";
            this.PANEL_CONTENTS.Size = new System.Drawing.Size(954, 666);
            this.PANEL_CONTENTS.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cancelButton.BorderRadius = 15;
            this.cancelButton.BorderSize = 3;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(477, 592);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(412, 58);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Back";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editInfoButton
            // 
            this.editInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editInfoButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editInfoButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editInfoButton.BorderRadius = 15;
            this.editInfoButton.BorderSize = 0;
            this.editInfoButton.FlatAppearance.BorderSize = 0;
            this.editInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editInfoButton.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInfoButton.ForeColor = System.Drawing.Color.White;
            this.editInfoButton.Location = new System.Drawing.Point(60, 592);
            this.editInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editInfoButton.Name = "editInfoButton";
            this.editInfoButton.Size = new System.Drawing.Size(412, 58);
            this.editInfoButton.TabIndex = 0;
            this.editInfoButton.Text = "Edit Info";
            this.editInfoButton.TextColor = System.Drawing.Color.White;
            this.editInfoButton.UseVisualStyleBackColor = false;
            this.editInfoButton.Click += new System.EventHandler(this.editInfoButton_Click);
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ISBNLabel, 3);
            this.ISBNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ISBNLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ISBNLabel.Location = new System.Drawing.Point(415, 34);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(407, 34);
            this.ISBNLabel.TabIndex = 0;
            this.ISBNLabel.Text = "ISBN";
            this.ISBNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ISBNTextbox
            // 
            this.ISBNTextbox.BackColor = System.Drawing.Color.Transparent;
            this.ISBNTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ISBNTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ISBNTextbox.BorderThickness = 0;
            this.ISBNTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tableLayoutPanel1.SetColumnSpan(this.ISBNTextbox, 3);
            this.ISBNTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ISBNTextbox.Location = new System.Drawing.Point(415, 70);
            this.ISBNTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBNTextbox.Name = "ISBNTextbox";
            this.ISBNTextbox.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ISBNTextbox.Radius = 10;
            this.ISBNTextbox.ReadOnly = false;
            this.ISBNTextbox.Size = new System.Drawing.Size(407, 30);
            this.ISBNTextbox.TabIndex = 1;
            this.ISBNTextbox.Text = "1436969143";
            this.ISBNTextbox.UseSystemPasswordChar = false;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.authorLabel, 3);
            this.authorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorLabel.Location = new System.Drawing.Point(415, 102);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(407, 34);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorTextbox
            // 
            this.authorTextbox.BackColor = System.Drawing.Color.Transparent;
            this.authorTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.authorTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.authorTextbox.BorderThickness = 0;
            this.authorTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tableLayoutPanel1.SetColumnSpan(this.authorTextbox, 3);
            this.authorTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorTextbox.Enabled = false;
            this.authorTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorTextbox.Location = new System.Drawing.Point(415, 138);
            this.authorTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorTextbox.Name = "authorTextbox";
            this.authorTextbox.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.authorTextbox.Radius = 10;
            this.authorTextbox.ReadOnly = false;
            this.authorTextbox.Size = new System.Drawing.Size(407, 30);
            this.authorTextbox.TabIndex = 3;
            this.authorTextbox.Text = "Reach Mound";
            this.authorTextbox.UseSystemPasswordChar = false;
            // 
            // shelfLabel
            // 
            this.shelfLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.shelfLabel, 3);
            this.shelfLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shelfLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.shelfLabel.Location = new System.Drawing.Point(415, 374);
            this.shelfLabel.Name = "shelfLabel";
            this.shelfLabel.Size = new System.Drawing.Size(407, 34);
            this.shelfLabel.TabIndex = 7;
            this.shelfLabel.Text = "Shelf";
            this.shelfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aisleLabel
            // 
            this.aisleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.aisleLabel, 3);
            this.aisleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aisleLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aisleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.aisleLabel.Location = new System.Drawing.Point(415, 306);
            this.aisleLabel.Name = "aisleLabel";
            this.aisleLabel.Size = new System.Drawing.Size(407, 34);
            this.aisleLabel.TabIndex = 6;
            this.aisleLabel.Text = "Aisle";
            this.aisleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.copyrightLabel, 3);
            this.copyrightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyrightLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.copyrightLabel.Location = new System.Drawing.Point(415, 238);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(407, 34);
            this.copyrightLabel.TabIndex = 5;
            this.copyrightLabel.Text = "Copyright";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.publisherLabel, 3);
            this.publisherLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publisherLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.publisherLabel.Location = new System.Drawing.Point(415, 170);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(407, 34);
            this.publisherLabel.TabIndex = 4;
            this.publisherLabel.Text = "Publisher";
            this.publisherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // publisherTextbox
            // 
            this.publisherTextbox.BackColor = System.Drawing.Color.Transparent;
            this.publisherTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.publisherTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.publisherTextbox.BorderThickness = 0;
            this.publisherTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tableLayoutPanel1.SetColumnSpan(this.publisherTextbox, 3);
            this.publisherTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publisherTextbox.Enabled = false;
            this.publisherTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.publisherTextbox.Location = new System.Drawing.Point(415, 206);
            this.publisherTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publisherTextbox.Name = "publisherTextbox";
            this.publisherTextbox.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.publisherTextbox.Radius = 10;
            this.publisherTextbox.ReadOnly = false;
            this.publisherTextbox.Size = new System.Drawing.Size(407, 30);
            this.publisherTextbox.TabIndex = 8;
            this.publisherTextbox.Text = "Gabrielle\'s Books of Revelation";
            this.publisherTextbox.UseSystemPasswordChar = false;
            // 
            // copyrightTextbox
            // 
            this.copyrightTextbox.BackColor = System.Drawing.Color.Transparent;
            this.copyrightTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.copyrightTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.copyrightTextbox.BorderThickness = 0;
            this.copyrightTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tableLayoutPanel1.SetColumnSpan(this.copyrightTextbox, 3);
            this.copyrightTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyrightTextbox.Enabled = false;
            this.copyrightTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.copyrightTextbox.Location = new System.Drawing.Point(415, 274);
            this.copyrightTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.copyrightTextbox.Name = "copyrightTextbox";
            this.copyrightTextbox.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.copyrightTextbox.Radius = 10;
            this.copyrightTextbox.ReadOnly = false;
            this.copyrightTextbox.Size = new System.Drawing.Size(407, 30);
            this.copyrightTextbox.TabIndex = 9;
            this.copyrightTextbox.Text = "© 2017 by Taylor Jenkins Reid";
            this.copyrightTextbox.UseSystemPasswordChar = false;
            // 
            // aisleTextbox
            // 
            this.aisleTextbox.BackColor = System.Drawing.Color.Transparent;
            this.aisleTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.aisleTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.aisleTextbox.BorderThickness = 0;
            this.aisleTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tableLayoutPanel1.SetColumnSpan(this.aisleTextbox, 3);
            this.aisleTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aisleTextbox.Enabled = false;
            this.aisleTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aisleTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.aisleTextbox.Location = new System.Drawing.Point(415, 342);
            this.aisleTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aisleTextbox.Name = "aisleTextbox";
            this.aisleTextbox.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.aisleTextbox.Radius = 10;
            this.aisleTextbox.ReadOnly = false;
            this.aisleTextbox.Size = new System.Drawing.Size(407, 30);
            this.aisleTextbox.TabIndex = 10;
            this.aisleTextbox.Text = "<000>";
            this.aisleTextbox.UseSystemPasswordChar = false;
            // 
            // shelfTextbox
            // 
            this.shelfTextbox.BackColor = System.Drawing.Color.Transparent;
            this.shelfTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.shelfTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.shelfTextbox.BorderThickness = 0;
            this.shelfTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tableLayoutPanel1.SetColumnSpan(this.shelfTextbox, 3);
            this.shelfTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shelfTextbox.Enabled = false;
            this.shelfTextbox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelfTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.shelfTextbox.Location = new System.Drawing.Point(415, 410);
            this.shelfTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shelfTextbox.Name = "shelfTextbox";
            this.shelfTextbox.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.shelfTextbox.Radius = 10;
            this.shelfTextbox.ReadOnly = false;
            this.shelfTextbox.Size = new System.Drawing.Size(407, 38);
            this.shelfTextbox.TabIndex = 11;
            this.shelfTextbox.Text = "<000>";
            this.shelfTextbox.UseSystemPasswordChar = false;
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.bookPictureBox.Location = new System.Drawing.Point(3, 2);
            this.bookPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookPictureBox.Name = "bookPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.bookPictureBox, 13);
            this.bookPictureBox.Size = new System.Drawing.Size(406, 446);
            this.bookPictureBox.TabIndex = 12;
            this.bookPictureBox.TabStop = false;
            // 
            // booktitleLabel
            // 
            this.booktitleLabel.Font = new System.Drawing.Font("Montserrat Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booktitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.booktitleLabel.Location = new System.Drawing.Point(3, 6);
            this.booktitleLabel.Name = "booktitleLabel";
            this.booktitleLabel.Size = new System.Drawing.Size(948, 128);
            this.booktitleLabel.TabIndex = 3;
            this.booktitleLabel.Text = "LORD OF THE RINGS\r\nLORD OF THE RINGS";
            this.booktitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availableLabel
            // 
            this.availableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.availableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableLabel.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.availableLabel.Location = new System.Drawing.Point(689, 0);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(133, 34);
            this.availableLabel.TabIndex = 2;
            this.availableLabel.Text = "Available";
            this.availableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.genreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreLabel.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.genreLabel.Location = new System.Drawing.Point(552, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(131, 34);
            this.genreLabel.TabIndex = 1;
            this.genreLabel.Text = "Genre";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryLabel.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.categoryLabel.Location = new System.Drawing.Point(415, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(131, 34);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.bookPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.shelfLabel, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.authorTextbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.authorLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.shelfTextbox, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.aisleLabel, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.ISBNTextbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ISBNLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.aisleTextbox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.copyrightLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.copyrightTextbox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.categoryLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.publisherLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.publisherTextbox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.genreLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.availableLabel, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 450);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // FORM_BOOKINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.PANEL_CONTENTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FORM_BOOKINFO";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivary | Book Info";
            this.PANEL_CONTENTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_CONTENTS;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.Label booktitleLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private RoundedCorners.RoundedTextBox ISBNTextbox;
        private System.Windows.Forms.Label authorLabel;
        private RoundedCorners.RoundedTextBox authorTextbox;
        private System.Windows.Forms.Label shelfLabel;
        private System.Windows.Forms.Label aisleLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label publisherLabel;
        private RoundedCorners.RoundedTextBox publisherTextbox;
        private RoundedCorners.RoundedTextBox copyrightTextbox;
        private RoundedCorners.RoundedTextBox aisleTextbox;
        private RoundedCorners.RoundedTextBox shelfTextbox;
        private System.Windows.Forms.PictureBox bookPictureBox;
        private roundedCorners.roundedButton editInfoButton;
        private roundedCorners.roundedButton cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
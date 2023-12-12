namespace Archivary.Archivary_Components
{
    partial class bookDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LAYOUT_bookPicture = new System.Windows.Forms.Panel();
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.authorHolder = new System.Windows.Forms.Label();
            this.isbnHolder = new System.Windows.Forms.Label();
            this.viewButton = new roundedCorners.roundedButton();
            this.LAYOUT_bookPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LAYOUT_bookPicture
            // 
            this.LAYOUT_bookPicture.Controls.Add(this.bookPicture);
            this.LAYOUT_bookPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.LAYOUT_bookPicture.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_bookPicture.Name = "LAYOUT_bookPicture";
            this.LAYOUT_bookPicture.Padding = new System.Windows.Forms.Padding(10);
            this.LAYOUT_bookPicture.Size = new System.Drawing.Size(150, 200);
            this.LAYOUT_bookPicture.TabIndex = 0;
            // 
            // bookPicture
            // 
            this.bookPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.bookPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookPicture.Location = new System.Drawing.Point(10, 10);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(130, 180);
            this.bookPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookPicture.TabIndex = 0;
            this.bookPicture.TabStop = false;
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTitleLabel.Font = new System.Drawing.Font("Montserrat Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.bookTitleLabel.Location = new System.Drawing.Point(152, 10);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(255, 55);
            this.bookTitleLabel.TabIndex = 1;
            this.bookTitleLabel.Text = "LORD OF THE RINGS";
            this.bookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorLabel.Location = new System.Drawing.Point(228, 81);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(192, 23);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "<LASTNAME>, <FN> <MI>";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isbnLabel
            // 
            this.isbnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.isbnLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.isbnLabel.Location = new System.Drawing.Point(228, 104);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(192, 29);
            this.isbnLabel.TabIndex = 3;
            this.isbnLabel.Text = "1436969143";
            this.isbnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorHolder
            // 
            this.authorHolder.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorHolder.Location = new System.Drawing.Point(153, 81);
            this.authorHolder.Name = "authorHolder";
            this.authorHolder.Size = new System.Drawing.Size(74, 23);
            this.authorHolder.TabIndex = 2;
            this.authorHolder.Text = "Author: <LASTNAME>, <FN> <MI>";
            this.authorHolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isbnHolder
            // 
            this.isbnHolder.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.isbnHolder.Location = new System.Drawing.Point(153, 106);
            this.isbnHolder.Name = "isbnHolder";
            this.isbnHolder.Size = new System.Drawing.Size(74, 29);
            this.isbnHolder.TabIndex = 3;
            this.isbnHolder.Text = "ISBN: 1436969143";
            this.isbnHolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewButton
            // 
            this.viewButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.viewButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.viewButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.viewButton.BorderRadius = 40;
            this.viewButton.BorderSize = 0;
            this.viewButton.FlatAppearance.BorderSize = 0;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.Location = new System.Drawing.Point(249, 144);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(150, 40);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "View Book";
            this.viewButton.TextColor = System.Drawing.Color.White;
            this.viewButton.UseVisualStyleBackColor = false;
            // 
            // bookDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.isbnHolder);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.authorHolder);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.bookTitleLabel);
            this.Controls.Add(this.LAYOUT_bookPicture);
            this.Name = "bookDetails";
            this.Size = new System.Drawing.Size(420, 200);
            this.LAYOUT_bookPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LAYOUT_bookPicture;
        private System.Windows.Forms.PictureBox bookPicture;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label isbnLabel;
        private roundedCorners.roundedButton viewButton;
        private System.Windows.Forms.Label authorHolder;
        private System.Windows.Forms.Label isbnHolder;
    }
}

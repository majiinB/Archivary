namespace Archivary.Archivary_Components
{
    partial class circulationBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.selectButton = new roundedCorners.roundedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(150, 200);
            this.panel1.TabIndex = 0;
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTitleLabel.Font = new System.Drawing.Font("Montserrat Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.bookTitleLabel.Location = new System.Drawing.Point(142, 56);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(255, 55);
            this.bookTitleLabel.TabIndex = 2;
            this.bookTitleLabel.Text = "LORD OF THE RINGS";
            this.bookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookPicture
            // 
            this.bookPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.bookPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookPicture.Location = new System.Drawing.Point(10, 10);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(130, 180);
            this.bookPicture.TabIndex = 0;
            this.bookPicture.TabStop = false;
            // 
            // selectButton
            // 
            this.selectButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.selectButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.selectButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.selectButton.BorderRadius = 40;
            this.selectButton.BorderSize = 0;
            this.selectButton.FlatAppearance.BorderSize = 0;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.Color.White;
            this.selectButton.Location = new System.Drawing.Point(238, 150);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(150, 40);
            this.selectButton.TabIndex = 5;
            this.selectButton.Text = "Select Book";
            this.selectButton.TextColor = System.Drawing.Color.White;
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // circulationBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.bookTitleLabel);
            this.Controls.Add(this.panel1);
            this.Name = "circulationBook";
            this.Size = new System.Drawing.Size(400, 200);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bookPicture;
        private System.Windows.Forms.Label bookTitleLabel;
        private roundedCorners.roundedButton selectButton;
    }
}

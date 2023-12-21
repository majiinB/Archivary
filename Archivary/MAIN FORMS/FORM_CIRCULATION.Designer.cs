namespace Archivary.PARENT_FORMS
{
    partial class FORM_CIRCULATION
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
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.selectTransactionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.borrowButton = new roundedCorners.roundedButton();
            this.returnButton = new roundedCorners.roundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPictureBox.Image = global::Archivary.Properties.Resources.BACKGROUND_CIRCULATION;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(960, 670);
            this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backgroundPictureBox.TabIndex = 0;
            this.backgroundPictureBox.TabStop = false;
            // 
            // selectTransactionLabel
            // 
            this.selectTransactionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectTransactionLabel.AutoSize = true;
            this.selectTransactionLabel.Font = new System.Drawing.Font("Montserrat Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTransactionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.selectTransactionLabel.Location = new System.Drawing.Point(145, 128);
            this.selectTransactionLabel.Name = "selectTransactionLabel";
            this.selectTransactionLabel.Size = new System.Drawing.Size(639, 83);
            this.selectTransactionLabel.TabIndex = 1;
            this.selectTransactionLabel.Text = "Select Transaction";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.borrowButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.returnButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 240);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 250);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // borrowButton
            // 
            this.borrowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.borrowButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.borrowButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borrowButton.BorderRadius = 40;
            this.borrowButton.BorderSize = 0;
            this.borrowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowButton.FlatAppearance.BorderSize = 0;
            this.borrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowButton.Font = new System.Drawing.Font("Montserrat Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowButton.ForeColor = System.Drawing.Color.White;
            this.borrowButton.Location = new System.Drawing.Point(3, 3);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(433, 244);
            this.borrowButton.TabIndex = 2;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.TextColor = System.Drawing.Color.White;
            this.borrowButton.UseVisualStyleBackColor = false;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.returnButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.returnButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.returnButton.BorderRadius = 40;
            this.returnButton.BorderSize = 0;
            this.returnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Montserrat Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(442, 3);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(433, 244);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return";
            this.returnButton.TextColor = System.Drawing.Color.White;
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // FORM_CIRCULATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.selectTransactionLabel);
            this.Controls.Add(this.backgroundPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_CIRCULATION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_CIRCULATION";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private System.Windows.Forms.Label selectTransactionLabel;
        private roundedCorners.roundedButton borrowButton;
        private roundedCorners.roundedButton returnButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
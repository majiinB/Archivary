namespace Archivary._900X500
{
    partial class FORM_ALERT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_ALERT));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.continueButton = new roundedCorners.roundedButton();
            this.cancelButton = new roundedCorners.roundedButton();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.alertTitleLabel = new System.Windows.Forms.Label();
            this.descriptionContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.alertMessageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.descriptionContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.continueButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 330);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 69);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.continueButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.continueButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.continueButton.BorderRadius = 10;
            this.continueButton.BorderSize = 0;
            this.continueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.continueButton.FlatAppearance.BorderSize = 0;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(3, 2);
            this.continueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(299, 65);
            this.continueButton.TabIndex = 0;
            this.continueButton.Text = "Continue";
            this.continueButton.TextColor = System.Drawing.Color.White;
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cancelButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cancelButton.BorderColor = System.Drawing.Color.Empty;
            this.cancelButton.BorderRadius = 10;
            this.cancelButton.BorderSize = 3;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cancelButton.Location = new System.Drawing.Point(308, 2);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(299, 65);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.Image")));
            this.iconPictureBox.Location = new System.Drawing.Point(11, 10);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(610, 100);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 3;
            this.iconPictureBox.TabStop = false;
            // 
            // alertTitleLabel
            // 
            this.alertTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.alertTitleLabel.Font = new System.Drawing.Font("Montserrat Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.alertTitleLabel.Location = new System.Drawing.Point(11, 110);
            this.alertTitleLabel.Name = "alertTitleLabel";
            this.alertTitleLabel.Size = new System.Drawing.Size(610, 98);
            this.alertTitleLabel.TabIndex = 4;
            this.alertTitleLabel.Text = "Type of Alert";
            this.alertTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionContainer
            // 
            this.descriptionContainer.AutoScroll = true;
            this.descriptionContainer.Controls.Add(this.alertMessageLabel);
            this.descriptionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionContainer.Location = new System.Drawing.Point(11, 208);
            this.descriptionContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionContainer.MaximumSize = new System.Drawing.Size(611, 94);
            this.descriptionContainer.MinimumSize = new System.Drawing.Size(611, 94);
            this.descriptionContainer.Name = "descriptionContainer";
            this.descriptionContainer.Size = new System.Drawing.Size(611, 94);
            this.descriptionContainer.TabIndex = 5;
            // 
            // alertMessageLabel
            // 
            this.alertMessageLabel.AutoSize = true;
            this.alertMessageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.alertMessageLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.alertMessageLabel.Location = new System.Drawing.Point(3, 0);
            this.alertMessageLabel.Name = "alertMessageLabel";
            this.alertMessageLabel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.alertMessageLabel.Size = new System.Drawing.Size(600, 130);
            this.alertMessageLabel.TabIndex = 6;
            this.alertMessageLabel.Text = resources.GetString("alertMessageLabel.Text");
            this.alertMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FORM_ALERT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(632, 409);
            this.Controls.Add(this.descriptionContainer);
            this.Controls.Add(this.alertTitleLabel);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FORM_ALERT";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_ALERT";
            this.Load += new System.EventHandler(this.FORM_ALERT_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FORM_ALERT_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.descriptionContainer.ResumeLayout(false);
            this.descriptionContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private roundedCorners.roundedButton continueButton;
        private roundedCorners.roundedButton cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label alertTitleLabel;
        private System.Windows.Forms.FlowLayoutPanel descriptionContainer;
        private System.Windows.Forms.Label alertMessageLabel;
    }
}
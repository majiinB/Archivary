namespace Archivary.PARENT_FORMS
{
    partial class FORM_LIBRARY
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
            this.roundedButton1 = new roundedCorners.roundedButton();
            this.LAYOUT_searchBar = new RoundedCorners.RoundedPanel();
            this.searchBar = new WHYWHYWHYW.RoundedTextBox();
            this.LAYOUT_searchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 40;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(646, 13);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(128, 64);
            this.roundedButton1.TabIndex = 1;
            this.roundedButton1.Text = "roundedButton1";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // LAYOUT_searchBar
            // 
            this.LAYOUT_searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAYOUT_searchBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchBar.BorderWidth = 1F;
            this.LAYOUT_searchBar.Controls.Add(this.searchBar);
            this.LAYOUT_searchBar.Location = new System.Drawing.Point(13, 13);
            this.LAYOUT_searchBar.Name = "LAYOUT_searchBar";
            this.LAYOUT_searchBar.Padding = new System.Windows.Forms.Padding(2);
            this.LAYOUT_searchBar.Radius = 10;
            this.LAYOUT_searchBar.Size = new System.Drawing.Size(618, 64);
            this.LAYOUT_searchBar.TabIndex = 0;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.Transparent;
            this.searchBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.searchBar.BorderThickness = 0;
            this.searchBar.Br = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.searchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.searchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.searchBar.Location = new System.Drawing.Point(2, 2);
            this.searchBar.Name = "searchBar";
            this.searchBar.Radius = 9;
            this.searchBar.Size = new System.Drawing.Size(614, 60);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "l";
            this.searchBar.UseSystemPasswordChar = false;
            // 
            // FORM_LIBRARY
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.LAYOUT_searchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_LIBRARY";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORM_LIBRARY_Load);
            this.Resize += new System.EventHandler(this.FORM_LIBRARY_Resize);
            this.LAYOUT_searchBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedCorners.RoundedPanel LAYOUT_searchBar;
        private WHYWHYWHYW.RoundedTextBox searchBar;
        private roundedCorners.roundedButton roundedButton1;
    }
}
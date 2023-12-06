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
            this.roundedTextBox1 = new WHYWHYWHYW.RoundedTextBox();
            this.roundedPanel1 = new RoundedCorners.RoundedPanel();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextBox1.BackgroundColor = System.Drawing.Color.White;
            this.roundedTextBox1.BorderColor = System.Drawing.Color.Black;
            this.roundedTextBox1.BorderThickness = 0;
            this.roundedTextBox1.Br = System.Drawing.Color.White;
            this.roundedTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roundedTextBox1.ForeColor = System.Drawing.Color.Black;
            this.roundedTextBox1.Location = new System.Drawing.Point(3, 3);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Radius = 30;
            this.roundedTextBox1.Size = new System.Drawing.Size(397, 57);
            this.roundedTextBox1.TabIndex = 0;
            this.roundedTextBox1.Text = "roundedTextBox1";
            this.roundedTextBox1.UseSystemPasswordChar = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.roundedPanel1.BorderColor = System.Drawing.SystemColors.Control;
            this.roundedPanel1.BorderWidth = 1F;
            this.roundedPanel1.Controls.Add(this.roundedTextBox1);
            this.roundedPanel1.Location = new System.Drawing.Point(368, 146);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.roundedPanel1.Radius = 30;
            this.roundedPanel1.Size = new System.Drawing.Size(403, 63);
            this.roundedPanel1.TabIndex = 1;
            // 
            // FORM_LIBRARY
            // 
            this.ClientSize = new System.Drawing.Size(1073, 386);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "FORM_LIBRARY";
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WHYWHYWHYW.RoundedTextBox roundedTextBox1;
        private RoundedCorners.RoundedPanel roundedPanel1;
    }
}
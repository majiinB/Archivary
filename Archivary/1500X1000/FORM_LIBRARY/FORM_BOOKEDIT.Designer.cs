namespace Archivary._1500X1000.FORM_LIBRARY
{
    partial class FORM_BOOKEDIT
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.roundedButton1 = new roundedCorners.roundedButton();
            this.editInfoButton = new roundedCorners.roundedButton();
            this.PANEL_CONTENTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_CONTENTS
            // 
            this.PANEL_CONTENTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PANEL_CONTENTS.Controls.Add(this.listBox1);
            this.PANEL_CONTENTS.Controls.Add(this.roundedButton1);
            this.PANEL_CONTENTS.Controls.Add(this.editInfoButton);
            this.PANEL_CONTENTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTENTS.Location = new System.Drawing.Point(3, 3);
            this.PANEL_CONTENTS.Name = "PANEL_CONTENTS";
            this.PANEL_CONTENTS.Size = new System.Drawing.Size(954, 664);
            this.PANEL_CONTENTS.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "asdf",
            "asd",
            "asd",
            "asd",
            "asd",
            "asd",
            "asd",
            "as",
            "asd"});
            this.listBox1.Location = new System.Drawing.Point(640, 256);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 9;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.roundedButton1.BorderRadius = 15;
            this.roundedButton1.BorderSize = 3;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(473, 591);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(412, 58);
            this.roundedButton1.TabIndex = 8;
            this.roundedButton1.Text = "Cancel";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
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
            this.editInfoButton.Location = new System.Drawing.Point(55, 591);
            this.editInfoButton.Name = "editInfoButton";
            this.editInfoButton.Size = new System.Drawing.Size(412, 58);
            this.editInfoButton.TabIndex = 7;
            this.editInfoButton.Text = "Edit Info";
            this.editInfoButton.TextColor = System.Drawing.Color.White;
            this.editInfoButton.UseVisualStyleBackColor = false;
            // 
            // FORM_BOOKEDIT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.PANEL_CONTENTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_BOOKEDIT";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_BOOKEDIT";
            this.PANEL_CONTENTS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_CONTENTS;
        private roundedCorners.roundedButton roundedButton1;
        private roundedCorners.roundedButton editInfoButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}
using System.Windows.Forms;

namespace Archivary
{
    partial class FORM_ROOT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_ROOT));
            this.PANEL_HOLDER = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PANEL_HOLDER
            // 
            this.PANEL_HOLDER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_HOLDER.Location = new System.Drawing.Point(0, 0);
            this.PANEL_HOLDER.Name = "PANEL_HOLDER";
            this.PANEL_HOLDER.Size = new System.Drawing.Size(1902, 1033);
            this.PANEL_HOLDER.TabIndex = 0;
            // 
            // FORM_ROOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.PANEL_HOLDER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "FORM_ROOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FORM_ROOT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PANEL_HOLDER;
    }
}
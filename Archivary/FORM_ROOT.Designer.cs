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
            this.PANEL_HOLDER.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_HOLDER.MinimumSize = new System.Drawing.Size(1200, 675);
            this.PANEL_HOLDER.Name = "PANEL_HOLDER";
            this.PANEL_HOLDER.Size = new System.Drawing.Size(1200, 675);
            this.PANEL_HOLDER.TabIndex = 0;
            // 
            // FORM_ROOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1180, 626);
            this.Controls.Add(this.PANEL_HOLDER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1196, 663);
            this.Name = "FORM_ROOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivary";
            this.Load += new System.EventHandler(this.FORM_ROOT_Load);
            this.DpiChanged += new System.Windows.Forms.DpiChangedEventHandler(this.FORM_ROOT_DpiChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PANEL_HOLDER;
    }
}
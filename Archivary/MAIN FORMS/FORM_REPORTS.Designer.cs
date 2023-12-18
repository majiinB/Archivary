namespace Archivary.PARENT_FORMS
{
    partial class FORM_REPORTS
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
            this.LAYOUT_REPORT = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LAYOUT_REPORT
            // 
            this.LAYOUT_REPORT.AutoScroll = true;
            this.LAYOUT_REPORT.AutoSize = true;
            this.LAYOUT_REPORT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LAYOUT_REPORT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_REPORT.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_REPORT.Margin = new System.Windows.Forms.Padding(0);
            this.LAYOUT_REPORT.Name = "LAYOUT_REPORT";
            this.LAYOUT_REPORT.Padding = new System.Windows.Forms.Padding(15, 15, 15, 25);
            this.LAYOUT_REPORT.Size = new System.Drawing.Size(800, 450);
            this.LAYOUT_REPORT.TabIndex = 0;
            // 
            // FORM_REPORTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LAYOUT_REPORT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_REPORTS";
            this.Text = "FORM_REPORTS";
            this.Load += new System.EventHandler(this.FORM_REPORTS_Load);
            this.Resize += new System.EventHandler(this.FORM_REPORTS_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LAYOUT_REPORT;
    }
}
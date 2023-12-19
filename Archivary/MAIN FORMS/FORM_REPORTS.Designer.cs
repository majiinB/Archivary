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
            this.monthlyOverview1 = new Archivary.Archivary_Components.monthlyOverview();
            this.booksBorrowed1 = new Archivary.Archivary_Components.booksBorrowed();
            this.booksReserved1 = new Archivary.Archivary_Components.booksReserved();
            this.LAYOUT_REPORT.SuspendLayout();
            this.SuspendLayout();
            // 
            // LAYOUT_REPORT
            // 
            this.LAYOUT_REPORT.AutoScroll = true;
            this.LAYOUT_REPORT.AutoSize = true;
            this.LAYOUT_REPORT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LAYOUT_REPORT.Controls.Add(this.monthlyOverview1);
            this.LAYOUT_REPORT.Controls.Add(this.booksBorrowed1);
            this.LAYOUT_REPORT.Controls.Add(this.booksReserved1);
            this.LAYOUT_REPORT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_REPORT.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_REPORT.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.LAYOUT_REPORT.Name = "LAYOUT_REPORT";
            this.LAYOUT_REPORT.Padding = new System.Windows.Forms.Padding(15, 15, 15, 30);
            this.LAYOUT_REPORT.Size = new System.Drawing.Size(800, 450);
            this.LAYOUT_REPORT.TabIndex = 0;
            // 
            // monthlyOverview1
            // 
            this.monthlyOverview1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthlyOverview1.BackColor = System.Drawing.Color.Transparent;
            this.monthlyOverview1.CopiesCount = "999";
            this.LAYOUT_REPORT.SetFlowBreak(this.monthlyOverview1, true);
            this.monthlyOverview1.LoanedCount = "999";
            this.monthlyOverview1.Location = new System.Drawing.Point(18, 18);
            this.monthlyOverview1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.monthlyOverview1.Name = "monthlyOverview1";
            this.monthlyOverview1.ReservedCount = "999";
            this.monthlyOverview1.ReturnedCount = "999";
            this.monthlyOverview1.Size = new System.Drawing.Size(744, 626);
            this.monthlyOverview1.TabIndex = 0;
            this.monthlyOverview1.UserCount = "999";
            // 
            // booksBorrowed1
            // 
            this.booksBorrowed1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksBorrowed1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.booksBorrowed1.BackColor = System.Drawing.Color.Transparent;
            this.LAYOUT_REPORT.SetFlowBreak(this.booksBorrowed1, true);
            this.booksBorrowed1.Location = new System.Drawing.Point(18, 652);
            this.booksBorrowed1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.booksBorrowed1.Name = "booksBorrowed1";
            this.booksBorrowed1.Size = new System.Drawing.Size(750, 521);
            this.booksBorrowed1.TabIndex = 1;
            // 
            // booksReserved1
            // 
            this.booksReserved1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksReserved1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.booksReserved1.BackColor = System.Drawing.Color.Transparent;
            this.LAYOUT_REPORT.SetFlowBreak(this.booksReserved1, true);
            this.booksReserved1.Location = new System.Drawing.Point(18, 1181);
            this.booksReserved1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.booksReserved1.Name = "booksReserved1";
            this.booksReserved1.Size = new System.Drawing.Size(750, 521);
            this.booksReserved1.TabIndex = 2;
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
            this.LAYOUT_REPORT.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LAYOUT_REPORT;
        private Archivary_Components.monthlyOverview monthlyOverview1;
        private Archivary_Components.booksBorrowed booksBorrowed1;
        private Archivary_Components.booksReserved booksReserved1;
    }
}
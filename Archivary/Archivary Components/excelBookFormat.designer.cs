namespace Archivary.Archivary_Components
{
    partial class excelBookFormat
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
            this.format1Label = new System.Windows.Forms.Label();
            this.format2Label = new System.Windows.Forms.Label();
            this.PANEL_HEADERFORMAT = new System.Windows.Forms.TableLayoutPanel();
            this.PANEL_RIGHTCOLUMN = new System.Windows.Forms.FlowLayoutPanel();
            this.aisleHeaderLabel = new System.Windows.Forms.Label();
            this.aisleDescriptionLabel = new System.Windows.Forms.Label();
            this.shelfHeaderLabel = new System.Windows.Forms.Label();
            this.shelfDescriptionLabel = new System.Windows.Forms.Label();
            this.categoryHeaderLabel = new System.Windows.Forms.Label();
            this.categoryDescriptionLabel = new System.Windows.Forms.Label();
            this.genreHeaderLabel = new System.Windows.Forms.Label();
            this.genreDescriptionLabel = new System.Windows.Forms.Label();
            this.coverHeaderLabel = new System.Windows.Forms.Label();
            this.coverDescriptionLabel = new System.Windows.Forms.Label();
            this.PANEL_LEFTCOLUMN = new System.Windows.Forms.FlowLayoutPanel();
            this.titleHeaderLabel = new System.Windows.Forms.Label();
            this.isbnHeaderLabel = new System.Windows.Forms.Label();
            this.isbnDescriptionLabel = new System.Windows.Forms.Label();
            this.publisherHeaderLabel = new System.Windows.Forms.Label();
            this.authorHeaderLabel = new System.Windows.Forms.Label();
            this.authorDescriptionLabel = new System.Windows.Forms.Label();
            this.authorFormatLabel = new System.Windows.Forms.Label();
            this.copyrightHeaderLabel = new System.Windows.Forms.Label();
            this.copyrightDescriptionLabel = new System.Windows.Forms.Label();
            this.copyrightFormatLabel = new System.Windows.Forms.Label();
            this.PANEL_SAMPLEFORMAT = new System.Windows.Forms.FlowLayoutPanel();
            this.sampleFormatPictureBox = new System.Windows.Forms.PictureBox();
            this.sampleFormatLabel = new System.Windows.Forms.Label();
            this.PANEL_HEADERFORMAT.SuspendLayout();
            this.PANEL_RIGHTCOLUMN.SuspendLayout();
            this.PANEL_LEFTCOLUMN.SuspendLayout();
            this.PANEL_SAMPLEFORMAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleFormatPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // format1Label
            // 
            this.format1Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.format1Label.Font = new System.Drawing.Font("Montserrat", 9F);
            this.format1Label.ForeColor = System.Drawing.SystemColors.Control;
            this.format1Label.Location = new System.Drawing.Point(0, 0);
            this.format1Label.Margin = new System.Windows.Forms.Padding(0);
            this.format1Label.Name = "format1Label";
            this.format1Label.Size = new System.Drawing.Size(703, 18);
            this.format1Label.TabIndex = 0;
            this.format1Label.Text = "1. Ensure your Excel file includes the following column headers to represent the " +
    "data: ";
            this.format1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // format2Label
            // 
            this.format2Label.AutoSize = true;
            this.format2Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.format2Label.Font = new System.Drawing.Font("Montserrat", 9F);
            this.format2Label.ForeColor = System.Drawing.SystemColors.Control;
            this.format2Label.Location = new System.Drawing.Point(0, 418);
            this.format2Label.Margin = new System.Windows.Forms.Padding(0);
            this.format2Label.MaximumSize = new System.Drawing.Size(706, 0);
            this.format2Label.Name = "format2Label";
            this.format2Label.Size = new System.Drawing.Size(683, 42);
            this.format2Label.TabIndex = 3;
            this.format2Label.Text = "2. Ensure that no cell is left blank. If certain information is unavailable, plea" +
    "se use ‘N/A’ as a placeholder.";
            this.format2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PANEL_HEADERFORMAT
            // 
            this.PANEL_HEADERFORMAT.ColumnCount = 2;
            this.PANEL_HEADERFORMAT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PANEL_HEADERFORMAT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PANEL_HEADERFORMAT.Controls.Add(this.PANEL_RIGHTCOLUMN, 1, 0);
            this.PANEL_HEADERFORMAT.Controls.Add(this.PANEL_LEFTCOLUMN, 0, 0);
            this.PANEL_HEADERFORMAT.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_HEADERFORMAT.Location = new System.Drawing.Point(0, 18);
            this.PANEL_HEADERFORMAT.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_HEADERFORMAT.MaximumSize = new System.Drawing.Size(706, 400);
            this.PANEL_HEADERFORMAT.MinimumSize = new System.Drawing.Size(706, 370);
            this.PANEL_HEADERFORMAT.Name = "PANEL_HEADERFORMAT";
            this.PANEL_HEADERFORMAT.RowCount = 1;
            this.PANEL_HEADERFORMAT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PANEL_HEADERFORMAT.Size = new System.Drawing.Size(706, 400);
            this.PANEL_HEADERFORMAT.TabIndex = 2;
            // 
            // PANEL_RIGHTCOLUMN
            // 
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.aisleHeaderLabel);
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.aisleDescriptionLabel);
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.shelfHeaderLabel);
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.shelfDescriptionLabel);
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.categoryHeaderLabel);
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.categoryDescriptionLabel);
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.genreHeaderLabel);
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.genreDescriptionLabel);
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.coverHeaderLabel);
            this.PANEL_RIGHTCOLUMN.Controls.Add(this.coverDescriptionLabel);
            this.PANEL_RIGHTCOLUMN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_RIGHTCOLUMN.Location = new System.Drawing.Point(353, 0);
            this.PANEL_RIGHTCOLUMN.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_RIGHTCOLUMN.MinimumSize = new System.Drawing.Size(338, 100);
            this.PANEL_RIGHTCOLUMN.Name = "PANEL_RIGHTCOLUMN";
            this.PANEL_RIGHTCOLUMN.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.PANEL_RIGHTCOLUMN.Size = new System.Drawing.Size(353, 400);
            this.PANEL_RIGHTCOLUMN.TabIndex = 1;
            // 
            // aisleHeaderLabel
            // 
            this.aisleHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.aisleHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.aisleHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.aisleHeaderLabel.Location = new System.Drawing.Point(15, 10);
            this.aisleHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.aisleHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.aisleHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.aisleHeaderLabel.Name = "aisleHeaderLabel";
            this.aisleHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.aisleHeaderLabel.TabIndex = 12;
            this.aisleHeaderLabel.Text = "- Aisle Number";
            this.aisleHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aisleDescriptionLabel
            // 
            this.aisleDescriptionLabel.AutoSize = true;
            this.aisleDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.aisleDescriptionLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Italic);
            this.aisleDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.aisleDescriptionLabel.Location = new System.Drawing.Point(15, 35);
            this.aisleDescriptionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.aisleDescriptionLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.aisleDescriptionLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.aisleDescriptionLabel.Name = "aisleDescriptionLabel";
            this.aisleDescriptionLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.aisleDescriptionLabel.Size = new System.Drawing.Size(320, 40);
            this.aisleDescriptionLabel.TabIndex = 13;
            this.aisleDescriptionLabel.Text = "Please encode the information in a numeric format.";
            this.aisleDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shelfHeaderLabel
            // 
            this.shelfHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shelfHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.shelfHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.shelfHeaderLabel.Location = new System.Drawing.Point(15, 80);
            this.shelfHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.shelfHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.shelfHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.shelfHeaderLabel.Name = "shelfHeaderLabel";
            this.shelfHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.shelfHeaderLabel.TabIndex = 15;
            this.shelfHeaderLabel.Text = "- Shelf Number";
            this.shelfHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shelfDescriptionLabel
            // 
            this.shelfDescriptionLabel.AutoSize = true;
            this.shelfDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shelfDescriptionLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Italic);
            this.shelfDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.shelfDescriptionLabel.Location = new System.Drawing.Point(15, 105);
            this.shelfDescriptionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.shelfDescriptionLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.shelfDescriptionLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.shelfDescriptionLabel.Name = "shelfDescriptionLabel";
            this.shelfDescriptionLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.shelfDescriptionLabel.Size = new System.Drawing.Size(320, 40);
            this.shelfDescriptionLabel.TabIndex = 16;
            this.shelfDescriptionLabel.Text = "Please encode the information in a numeric format.";
            this.shelfDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryHeaderLabel
            // 
            this.categoryHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.categoryHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.categoryHeaderLabel.Location = new System.Drawing.Point(15, 150);
            this.categoryHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.categoryHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.categoryHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.categoryHeaderLabel.Name = "categoryHeaderLabel";
            this.categoryHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.categoryHeaderLabel.TabIndex = 20;
            this.categoryHeaderLabel.Text = "- Book Category";
            this.categoryHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryDescriptionLabel
            // 
            this.categoryDescriptionLabel.AutoSize = true;
            this.categoryDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryDescriptionLabel.Font = new System.Drawing.Font("Montserrat", 8F);
            this.categoryDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.categoryDescriptionLabel.Location = new System.Drawing.Point(15, 175);
            this.categoryDescriptionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.categoryDescriptionLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.categoryDescriptionLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.categoryDescriptionLabel.Name = "categoryDescriptionLabel";
            this.categoryDescriptionLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.categoryDescriptionLabel.Size = new System.Drawing.Size(320, 40);
            this.categoryDescriptionLabel.TabIndex = 21;
            this.categoryDescriptionLabel.Text = "Please encode the category as either Academic, Fiction, or Nonfiction.";
            this.categoryDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genreHeaderLabel
            // 
            this.genreHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.genreHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.genreHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.genreHeaderLabel.Location = new System.Drawing.Point(15, 220);
            this.genreHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.genreHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.genreHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.genreHeaderLabel.Name = "genreHeaderLabel";
            this.genreHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.genreHeaderLabel.TabIndex = 22;
            this.genreHeaderLabel.Text = "- Book Genre";
            this.genreHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genreDescriptionLabel
            // 
            this.genreDescriptionLabel.AutoSize = true;
            this.genreDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.genreDescriptionLabel.Font = new System.Drawing.Font("Montserrat", 8F);
            this.genreDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.genreDescriptionLabel.Location = new System.Drawing.Point(15, 245);
            this.genreDescriptionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.genreDescriptionLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.genreDescriptionLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.genreDescriptionLabel.Name = "genreDescriptionLabel";
            this.genreDescriptionLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.genreDescriptionLabel.Size = new System.Drawing.Size(320, 60);
            this.genreDescriptionLabel.TabIndex = 23;
            this.genreDescriptionLabel.Text = "Please encode the genre corresponding to the chosen category. Refer to the system" +
    " settings for the list.";
            this.genreDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // coverHeaderLabel
            // 
            this.coverHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.coverHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.coverHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.coverHeaderLabel.Location = new System.Drawing.Point(15, 310);
            this.coverHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.coverHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.coverHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.coverHeaderLabel.Name = "coverHeaderLabel";
            this.coverHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.coverHeaderLabel.TabIndex = 24;
            this.coverHeaderLabel.Text = "- Book Cover";
            this.coverHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // coverDescriptionLabel
            // 
            this.coverDescriptionLabel.AutoSize = true;
            this.coverDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.coverDescriptionLabel.Font = new System.Drawing.Font("Montserrat", 8F);
            this.coverDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.coverDescriptionLabel.Location = new System.Drawing.Point(15, 335);
            this.coverDescriptionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.coverDescriptionLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.coverDescriptionLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.coverDescriptionLabel.Name = "coverDescriptionLabel";
            this.coverDescriptionLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.coverDescriptionLabel.Size = new System.Drawing.Size(320, 40);
            this.coverDescriptionLabel.TabIndex = 25;
            this.coverDescriptionLabel.Text = "Please encode the file location of the image.";
            this.coverDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PANEL_LEFTCOLUMN
            // 
            this.PANEL_LEFTCOLUMN.Controls.Add(this.titleHeaderLabel);
            this.PANEL_LEFTCOLUMN.Controls.Add(this.isbnHeaderLabel);
            this.PANEL_LEFTCOLUMN.Controls.Add(this.isbnDescriptionLabel);
            this.PANEL_LEFTCOLUMN.Controls.Add(this.publisherHeaderLabel);
            this.PANEL_LEFTCOLUMN.Controls.Add(this.authorHeaderLabel);
            this.PANEL_LEFTCOLUMN.Controls.Add(this.authorDescriptionLabel);
            this.PANEL_LEFTCOLUMN.Controls.Add(this.authorFormatLabel);
            this.PANEL_LEFTCOLUMN.Controls.Add(this.copyrightHeaderLabel);
            this.PANEL_LEFTCOLUMN.Controls.Add(this.copyrightDescriptionLabel);
            this.PANEL_LEFTCOLUMN.Controls.Add(this.copyrightFormatLabel);
            this.PANEL_LEFTCOLUMN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_LEFTCOLUMN.Location = new System.Drawing.Point(0, 0);
            this.PANEL_LEFTCOLUMN.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_LEFTCOLUMN.MinimumSize = new System.Drawing.Size(338, 100);
            this.PANEL_LEFTCOLUMN.Name = "PANEL_LEFTCOLUMN";
            this.PANEL_LEFTCOLUMN.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.PANEL_LEFTCOLUMN.Size = new System.Drawing.Size(353, 400);
            this.PANEL_LEFTCOLUMN.TabIndex = 0;
            // 
            // titleHeaderLabel
            // 
            this.titleHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.titleHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleHeaderLabel.Location = new System.Drawing.Point(15, 10);
            this.titleHeaderLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.titleHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.titleHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.titleHeaderLabel.Name = "titleHeaderLabel";
            this.titleHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.titleHeaderLabel.TabIndex = 6;
            this.titleHeaderLabel.Text = "- Book Title";
            this.titleHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isbnHeaderLabel
            // 
            this.isbnHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.isbnHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.isbnHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.isbnHeaderLabel.Location = new System.Drawing.Point(15, 40);
            this.isbnHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.isbnHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.isbnHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.isbnHeaderLabel.Name = "isbnHeaderLabel";
            this.isbnHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.isbnHeaderLabel.TabIndex = 12;
            this.isbnHeaderLabel.Text = "- Book ISBN";
            this.isbnHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isbnDescriptionLabel
            // 
            this.isbnDescriptionLabel.AutoSize = true;
            this.isbnDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.isbnDescriptionLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Italic);
            this.isbnDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.isbnDescriptionLabel.Location = new System.Drawing.Point(15, 65);
            this.isbnDescriptionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.isbnDescriptionLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.isbnDescriptionLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.isbnDescriptionLabel.Name = "isbnDescriptionLabel";
            this.isbnDescriptionLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.isbnDescriptionLabel.Size = new System.Drawing.Size(320, 40);
            this.isbnDescriptionLabel.TabIndex = 13;
            this.isbnDescriptionLabel.Text = "Please encode the information in either a 10-digit or 13-digit ISBN.";
            this.isbnDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // publisherHeaderLabel
            // 
            this.publisherHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.publisherHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.publisherHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.publisherHeaderLabel.Location = new System.Drawing.Point(15, 110);
            this.publisherHeaderLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.publisherHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.publisherHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.publisherHeaderLabel.Name = "publisherHeaderLabel";
            this.publisherHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.publisherHeaderLabel.TabIndex = 14;
            this.publisherHeaderLabel.Text = "- Publisher";
            this.publisherHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorHeaderLabel
            // 
            this.authorHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.authorHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.authorHeaderLabel.Location = new System.Drawing.Point(15, 140);
            this.authorHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.authorHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.authorHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.authorHeaderLabel.Name = "authorHeaderLabel";
            this.authorHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.authorHeaderLabel.TabIndex = 15;
            this.authorHeaderLabel.Text = "- Author\'s Name";
            this.authorHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorDescriptionLabel
            // 
            this.authorDescriptionLabel.AutoSize = true;
            this.authorDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorDescriptionLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Italic);
            this.authorDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.authorDescriptionLabel.Location = new System.Drawing.Point(15, 165);
            this.authorDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.authorDescriptionLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.authorDescriptionLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.authorDescriptionLabel.Name = "authorDescriptionLabel";
            this.authorDescriptionLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.authorDescriptionLabel.Size = new System.Drawing.Size(320, 40);
            this.authorDescriptionLabel.TabIndex = 16;
            this.authorDescriptionLabel.Text = "Please encode the information in the following format:";
            this.authorDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorFormatLabel
            // 
            this.authorFormatLabel.AutoSize = true;
            this.authorFormatLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorFormatLabel.Font = new System.Drawing.Font("Montserrat", 7.79F, System.Drawing.FontStyle.Bold);
            this.authorFormatLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.authorFormatLabel.Location = new System.Drawing.Point(15, 205);
            this.authorFormatLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.authorFormatLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.authorFormatLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.authorFormatLabel.Name = "authorFormatLabel";
            this.authorFormatLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.authorFormatLabel.Size = new System.Drawing.Size(320, 25);
            this.authorFormatLabel.TabIndex = 19;
            this.authorFormatLabel.Text = "[First Name] [Middle Initial] [Surname]";
            this.authorFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyrightHeaderLabel
            // 
            this.copyrightHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyrightHeaderLabel.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.copyrightHeaderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.copyrightHeaderLabel.Location = new System.Drawing.Point(15, 235);
            this.copyrightHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.copyrightHeaderLabel.MaximumSize = new System.Drawing.Size(320, 30);
            this.copyrightHeaderLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.copyrightHeaderLabel.Name = "copyrightHeaderLabel";
            this.copyrightHeaderLabel.Size = new System.Drawing.Size(320, 25);
            this.copyrightHeaderLabel.TabIndex = 20;
            this.copyrightHeaderLabel.Text = "- Copyright";
            this.copyrightHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyrightDescriptionLabel
            // 
            this.copyrightDescriptionLabel.AutoSize = true;
            this.copyrightDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyrightDescriptionLabel.Font = new System.Drawing.Font("Montserrat", 8F);
            this.copyrightDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.copyrightDescriptionLabel.Location = new System.Drawing.Point(15, 260);
            this.copyrightDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.copyrightDescriptionLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.copyrightDescriptionLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.copyrightDescriptionLabel.Name = "copyrightDescriptionLabel";
            this.copyrightDescriptionLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.copyrightDescriptionLabel.Size = new System.Drawing.Size(320, 40);
            this.copyrightDescriptionLabel.TabIndex = 21;
            this.copyrightDescriptionLabel.Text = "Please encode the information in the following format:  ";
            this.copyrightDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyrightFormatLabel
            // 
            this.copyrightFormatLabel.AutoSize = true;
            this.copyrightFormatLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyrightFormatLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 7.79F, System.Drawing.FontStyle.Bold);
            this.copyrightFormatLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.copyrightFormatLabel.Location = new System.Drawing.Point(15, 300);
            this.copyrightFormatLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.copyrightFormatLabel.MaximumSize = new System.Drawing.Size(320, 0);
            this.copyrightFormatLabel.MinimumSize = new System.Drawing.Size(320, 25);
            this.copyrightFormatLabel.Name = "copyrightFormatLabel";
            this.copyrightFormatLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.copyrightFormatLabel.Size = new System.Drawing.Size(320, 25);
            this.copyrightFormatLabel.TabIndex = 22;
            this.copyrightFormatLabel.Text = "© [Year of Publication] [Copyright Owner]";
            this.copyrightFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PANEL_SAMPLEFORMAT
            // 
            this.PANEL_SAMPLEFORMAT.AutoScroll = true;
            this.PANEL_SAMPLEFORMAT.BackColor = System.Drawing.Color.White;
            this.PANEL_SAMPLEFORMAT.Controls.Add(this.sampleFormatPictureBox);
            this.PANEL_SAMPLEFORMAT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PANEL_SAMPLEFORMAT.Location = new System.Drawing.Point(0, 511);
            this.PANEL_SAMPLEFORMAT.Name = "PANEL_SAMPLEFORMAT";
            this.PANEL_SAMPLEFORMAT.Size = new System.Drawing.Size(703, 87);
            this.PANEL_SAMPLEFORMAT.TabIndex = 22;
            // 
            // sampleFormatPictureBox
            // 
            this.sampleFormatPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sampleFormatPictureBox.Image = global::Archivary.Properties.Resources.FORMAT_BOOK;
            this.sampleFormatPictureBox.Location = new System.Drawing.Point(0, 0);
            this.sampleFormatPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.sampleFormatPictureBox.MaximumSize = new System.Drawing.Size(1700, 65);
            this.sampleFormatPictureBox.MinimumSize = new System.Drawing.Size(1700, 65);
            this.sampleFormatPictureBox.Name = "sampleFormatPictureBox";
            this.sampleFormatPictureBox.Size = new System.Drawing.Size(1700, 65);
            this.sampleFormatPictureBox.TabIndex = 0;
            this.sampleFormatPictureBox.TabStop = false;
            // 
            // sampleFormatLabel
            // 
            this.sampleFormatLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sampleFormatLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.sampleFormatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.sampleFormatLabel.Location = new System.Drawing.Point(0, 483);
            this.sampleFormatLabel.Margin = new System.Windows.Forms.Padding(0);
            this.sampleFormatLabel.Name = "sampleFormatLabel";
            this.sampleFormatLabel.Size = new System.Drawing.Size(703, 28);
            this.sampleFormatLabel.TabIndex = 23;
            this.sampleFormatLabel.Text = "Sample Format";
            this.sampleFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // excelBookFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sampleFormatLabel);
            this.Controls.Add(this.PANEL_SAMPLEFORMAT);
            this.Controls.Add(this.format2Label);
            this.Controls.Add(this.PANEL_HEADERFORMAT);
            this.Controls.Add(this.format1Label);
            this.Name = "excelBookFormat";
            this.Size = new System.Drawing.Size(703, 598);
            this.PANEL_HEADERFORMAT.ResumeLayout(false);
            this.PANEL_RIGHTCOLUMN.ResumeLayout(false);
            this.PANEL_RIGHTCOLUMN.PerformLayout();
            this.PANEL_LEFTCOLUMN.ResumeLayout(false);
            this.PANEL_LEFTCOLUMN.PerformLayout();
            this.PANEL_SAMPLEFORMAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleFormatPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label format1Label;
        private System.Windows.Forms.Label format2Label;
        private System.Windows.Forms.TableLayoutPanel PANEL_HEADERFORMAT;
        private System.Windows.Forms.FlowLayoutPanel PANEL_LEFTCOLUMN;
        private System.Windows.Forms.Label titleHeaderLabel;
        private System.Windows.Forms.Label isbnHeaderLabel;
        private System.Windows.Forms.Label isbnDescriptionLabel;
        private System.Windows.Forms.Label publisherHeaderLabel;
        private System.Windows.Forms.Label authorHeaderLabel;
        private System.Windows.Forms.Label authorDescriptionLabel;
        private System.Windows.Forms.Label authorFormatLabel;
        private System.Windows.Forms.Label copyrightHeaderLabel;
        private System.Windows.Forms.Label copyrightDescriptionLabel;
        private System.Windows.Forms.Label copyrightFormatLabel;
        private System.Windows.Forms.FlowLayoutPanel PANEL_RIGHTCOLUMN;
        private System.Windows.Forms.Label aisleHeaderLabel;
        private System.Windows.Forms.Label aisleDescriptionLabel;
        private System.Windows.Forms.Label shelfHeaderLabel;
        private System.Windows.Forms.Label shelfDescriptionLabel;
        private System.Windows.Forms.Label categoryHeaderLabel;
        private System.Windows.Forms.Label categoryDescriptionLabel;
        private System.Windows.Forms.Label genreHeaderLabel;
        private System.Windows.Forms.Label genreDescriptionLabel;
        private System.Windows.Forms.Label coverHeaderLabel;
        private System.Windows.Forms.Label coverDescriptionLabel;
        private System.Windows.Forms.FlowLayoutPanel PANEL_SAMPLEFORMAT;
        private System.Windows.Forms.PictureBox sampleFormatPictureBox;
        private System.Windows.Forms.Label sampleFormatLabel;
    }
}

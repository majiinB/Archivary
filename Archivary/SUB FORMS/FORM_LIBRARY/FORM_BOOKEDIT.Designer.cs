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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label shelfLabel;
            this.PANEL_CONTENTS = new System.Windows.Forms.Panel();
            this.LAYOUT_RightSide = new System.Windows.Forms.TableLayoutPanel();
            this.shelfTextbox = new RoundedCorners.RoundedTextBox();
            this.aisleTextbox = new RoundedCorners.RoundedTextBox();
            this.aisleLabel = new System.Windows.Forms.Label();
            this.copyrightTextbox = new RoundedCorners.RoundedTextBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.authorMITextbox = new RoundedCorners.RoundedTextBox();
            this.authorFNTextbox = new RoundedCorners.RoundedTextBox();
            this.authorLNTextbox = new RoundedCorners.RoundedTextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherTextbox = new RoundedCorners.RoundedTextBox();
            this.ISBNTextbox = new RoundedCorners.RoundedTextBox();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new RoundedCorners.RoundedTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.LAYOUT_LeftSide = new System.Windows.Forms.TableLayoutPanel();
            this.genreDropdown = new sidebarComponents.RoundedPictureButtonRight();
            this.bookPictureBox = new System.Windows.Forms.PictureBox();
            this.uploadImageButton = new roundedCorners.roundedButton();
            this.categoryDropdown = new sidebarComponents.RoundedPictureButtonRight();
            this.cancelButton = new roundedCorners.roundedButton();
            this.saveInfoButton = new roundedCorners.roundedButton();
            this.dropdownMenu1 = new CustomDropdown.DropdownMenu(this.components);
            this.academicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonfictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropdownMenu2 = new CustomDropdown.DropdownMenu(this.components);
            shelfLabel = new System.Windows.Forms.Label();
            this.PANEL_CONTENTS.SuspendLayout();
            this.LAYOUT_RightSide.SuspendLayout();
            this.LAYOUT_LeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.dropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shelfLabel
            // 
            this.LAYOUT_RightSide.SetColumnSpan(shelfLabel, 7);
            shelfLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            shelfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shelfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            shelfLabel.Location = new System.Drawing.Point(3, 420);
            shelfLabel.Name = "shelfLabel";
            shelfLabel.Size = new System.Drawing.Size(624, 42);
            shelfLabel.TabIndex = 18;
            shelfLabel.Text = "Shelf";
            shelfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PANEL_CONTENTS
            // 
            this.PANEL_CONTENTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PANEL_CONTENTS.Controls.Add(this.LAYOUT_RightSide);
            this.PANEL_CONTENTS.Controls.Add(this.LAYOUT_LeftSide);
            this.PANEL_CONTENTS.Controls.Add(this.cancelButton);
            this.PANEL_CONTENTS.Controls.Add(this.saveInfoButton);
            this.PANEL_CONTENTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTENTS.Location = new System.Drawing.Point(3, 3);
            this.PANEL_CONTENTS.Name = "PANEL_CONTENTS";
            this.PANEL_CONTENTS.Size = new System.Drawing.Size(954, 664);
            this.PANEL_CONTENTS.TabIndex = 0;
            // 
            // LAYOUT_RightSide
            // 
            this.LAYOUT_RightSide.ColumnCount = 7;
            this.LAYOUT_RightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LAYOUT_RightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LAYOUT_RightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LAYOUT_RightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LAYOUT_RightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LAYOUT_RightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LAYOUT_RightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LAYOUT_RightSide.Controls.Add(this.shelfTextbox, 0, 11);
            this.LAYOUT_RightSide.Controls.Add(shelfLabel, 0, 10);
            this.LAYOUT_RightSide.Controls.Add(this.aisleTextbox, 0, 9);
            this.LAYOUT_RightSide.Controls.Add(this.aisleLabel, 0, 8);
            this.LAYOUT_RightSide.Controls.Add(this.copyrightTextbox, 0, 7);
            this.LAYOUT_RightSide.Controls.Add(this.copyrightLabel, 0, 6);
            this.LAYOUT_RightSide.Controls.Add(this.authorMITextbox, 6, 5);
            this.LAYOUT_RightSide.Controls.Add(this.authorFNTextbox, 3, 5);
            this.LAYOUT_RightSide.Controls.Add(this.authorLNTextbox, 0, 5);
            this.LAYOUT_RightSide.Controls.Add(this.authorLabel, 0, 4);
            this.LAYOUT_RightSide.Controls.Add(this.publisherTextbox, 3, 3);
            this.LAYOUT_RightSide.Controls.Add(this.ISBNTextbox, 0, 3);
            this.LAYOUT_RightSide.Controls.Add(this.PublisherLabel, 3, 2);
            this.LAYOUT_RightSide.Controls.Add(this.ISBNLabel, 0, 2);
            this.LAYOUT_RightSide.Controls.Add(this.titleTextbox, 0, 1);
            this.LAYOUT_RightSide.Controls.Add(this.titleLabel, 0, 0);
            this.LAYOUT_RightSide.Location = new System.Drawing.Point(286, 40);
            this.LAYOUT_RightSide.Name = "LAYOUT_RightSide";
            this.LAYOUT_RightSide.RowCount = 12;
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.LAYOUT_RightSide.Size = new System.Drawing.Size(630, 511);
            this.LAYOUT_RightSide.TabIndex = 10;
            // 
            // shelfTextbox
            // 
            this.shelfTextbox.BackColor = System.Drawing.Color.Transparent;
            this.shelfTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.shelfTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.shelfTextbox.BorderThickness = 0;
            this.shelfTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LAYOUT_RightSide.SetColumnSpan(this.shelfTextbox, 7);
            this.shelfTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shelfTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelfTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.shelfTextbox.Location = new System.Drawing.Point(3, 465);
            this.shelfTextbox.Name = "shelfTextbox";
            this.shelfTextbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.shelfTextbox.Radius = 10;
            this.shelfTextbox.Size = new System.Drawing.Size(624, 43);
            this.shelfTextbox.TabIndex = 19;
            this.shelfTextbox.Text = "69";
            this.shelfTextbox.UseSystemPasswordChar = false;
            this.shelfTextbox.TextChanged += new System.EventHandler(this.shelfTextbox_TextChanged);
            // 
            // aisleTextbox
            // 
            this.aisleTextbox.BackColor = System.Drawing.Color.Transparent;
            this.aisleTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.aisleTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.aisleTextbox.BorderThickness = 0;
            this.aisleTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LAYOUT_RightSide.SetColumnSpan(this.aisleTextbox, 7);
            this.aisleTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aisleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aisleTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.aisleTextbox.Location = new System.Drawing.Point(3, 381);
            this.aisleTextbox.Name = "aisleTextbox";
            this.aisleTextbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.aisleTextbox.Radius = 10;
            this.aisleTextbox.Size = new System.Drawing.Size(624, 36);
            this.aisleTextbox.TabIndex = 17;
            this.aisleTextbox.Text = "1";
            this.aisleTextbox.UseSystemPasswordChar = false;
            this.aisleTextbox.TextChanged += new System.EventHandler(this.aisleTextbox_TextChanged);
            // 
            // aisleLabel
            // 
            this.LAYOUT_RightSide.SetColumnSpan(this.aisleLabel, 7);
            this.aisleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aisleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aisleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.aisleLabel.Location = new System.Drawing.Point(3, 336);
            this.aisleLabel.Name = "aisleLabel";
            this.aisleLabel.Size = new System.Drawing.Size(624, 42);
            this.aisleLabel.TabIndex = 16;
            this.aisleLabel.Text = "Aisle";
            this.aisleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyrightTextbox
            // 
            this.copyrightTextbox.BackColor = System.Drawing.Color.Transparent;
            this.copyrightTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.copyrightTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.copyrightTextbox.BorderThickness = 0;
            this.copyrightTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LAYOUT_RightSide.SetColumnSpan(this.copyrightTextbox, 7);
            this.copyrightTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyrightTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.copyrightTextbox.Location = new System.Drawing.Point(3, 297);
            this.copyrightTextbox.Name = "copyrightTextbox";
            this.copyrightTextbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.copyrightTextbox.Radius = 10;
            this.copyrightTextbox.Size = new System.Drawing.Size(624, 36);
            this.copyrightTextbox.TabIndex = 15;
            this.copyrightTextbox.Text = "<1969>";
            this.copyrightTextbox.UseSystemPasswordChar = false;
            // 
            // copyrightLabel
            // 
            this.LAYOUT_RightSide.SetColumnSpan(this.copyrightLabel, 7);
            this.copyrightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.copyrightLabel.Location = new System.Drawing.Point(3, 252);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(624, 42);
            this.copyrightLabel.TabIndex = 14;
            this.copyrightLabel.Text = "Copyright";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorMITextbox
            // 
            this.authorMITextbox.BackColor = System.Drawing.Color.Transparent;
            this.authorMITextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.authorMITextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.authorMITextbox.BorderThickness = 0;
            this.authorMITextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.authorMITextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorMITextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorMITextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorMITextbox.Location = new System.Drawing.Point(537, 213);
            this.authorMITextbox.Name = "authorMITextbox";
            this.authorMITextbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.authorMITextbox.Radius = 10;
            this.authorMITextbox.Size = new System.Drawing.Size(90, 36);
            this.authorMITextbox.TabIndex = 13;
            this.authorMITextbox.Text = "R";
            this.authorMITextbox.UseSystemPasswordChar = false;
            // 
            // authorFNTextbox
            // 
            this.authorFNTextbox.BackColor = System.Drawing.Color.Transparent;
            this.authorFNTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.authorFNTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.authorFNTextbox.BorderThickness = 0;
            this.authorFNTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LAYOUT_RightSide.SetColumnSpan(this.authorFNTextbox, 3);
            this.authorFNTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorFNTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorFNTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorFNTextbox.Location = new System.Drawing.Point(270, 213);
            this.authorFNTextbox.Name = "authorFNTextbox";
            this.authorFNTextbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.authorFNTextbox.Radius = 10;
            this.authorFNTextbox.Size = new System.Drawing.Size(261, 36);
            this.authorFNTextbox.TabIndex = 11;
            this.authorFNTextbox.Text = "Andrei";
            this.authorFNTextbox.UseSystemPasswordChar = false;
            // 
            // authorLNTextbox
            // 
            this.authorLNTextbox.BackColor = System.Drawing.Color.Transparent;
            this.authorLNTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.authorLNTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.authorLNTextbox.BorderThickness = 0;
            this.authorLNTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LAYOUT_RightSide.SetColumnSpan(this.authorLNTextbox, 3);
            this.authorLNTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorLNTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLNTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorLNTextbox.Location = new System.Drawing.Point(3, 213);
            this.authorLNTextbox.Name = "authorLNTextbox";
            this.authorLNTextbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.authorLNTextbox.Radius = 10;
            this.authorLNTextbox.Size = new System.Drawing.Size(261, 36);
            this.authorLNTextbox.TabIndex = 10;
            this.authorLNTextbox.Text = "Ayala";
            this.authorLNTextbox.UseSystemPasswordChar = false;
            // 
            // authorLabel
            // 
            this.LAYOUT_RightSide.SetColumnSpan(this.authorLabel, 7);
            this.authorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.authorLabel.Location = new System.Drawing.Point(3, 168);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(624, 42);
            this.authorLabel.TabIndex = 9;
            this.authorLabel.Text = "Author";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // publisherTextbox
            // 
            this.publisherTextbox.BackColor = System.Drawing.Color.Transparent;
            this.publisherTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.publisherTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.publisherTextbox.BorderThickness = 0;
            this.publisherTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LAYOUT_RightSide.SetColumnSpan(this.publisherTextbox, 4);
            this.publisherTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publisherTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.publisherTextbox.Location = new System.Drawing.Point(270, 129);
            this.publisherTextbox.Name = "publisherTextbox";
            this.publisherTextbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.publisherTextbox.Radius = 10;
            this.publisherTextbox.Size = new System.Drawing.Size(357, 36);
            this.publisherTextbox.TabIndex = 8;
            this.publisherTextbox.Text = "Lampara Books";
            this.publisherTextbox.UseSystemPasswordChar = false;
            // 
            // ISBNTextbox
            // 
            this.ISBNTextbox.BackColor = System.Drawing.Color.Transparent;
            this.ISBNTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ISBNTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ISBNTextbox.BorderThickness = 0;
            this.ISBNTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LAYOUT_RightSide.SetColumnSpan(this.ISBNTextbox, 3);
            this.ISBNTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ISBNTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ISBNTextbox.Location = new System.Drawing.Point(3, 129);
            this.ISBNTextbox.Name = "ISBNTextbox";
            this.ISBNTextbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ISBNTextbox.Radius = 10;
            this.ISBNTextbox.Size = new System.Drawing.Size(261, 36);
            this.ISBNTextbox.TabIndex = 6;
            this.ISBNTextbox.Text = "1436969143";
            this.ISBNTextbox.UseSystemPasswordChar = false;
            this.ISBNTextbox.TextChanged += new System.EventHandler(this.ISBNTextbox_TextChanged);
            // 
            // PublisherLabel
            // 
            this.LAYOUT_RightSide.SetColumnSpan(this.PublisherLabel, 4);
            this.PublisherLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PublisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.PublisherLabel.Location = new System.Drawing.Point(270, 84);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(357, 42);
            this.PublisherLabel.TabIndex = 5;
            this.PublisherLabel.Text = "Publisher";
            this.PublisherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ISBNLabel
            // 
            this.LAYOUT_RightSide.SetColumnSpan(this.ISBNLabel, 3);
            this.ISBNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ISBNLabel.Location = new System.Drawing.Point(3, 84);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(261, 42);
            this.ISBNLabel.TabIndex = 3;
            this.ISBNLabel.Text = "ISBN";
            this.ISBNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleTextbox
            // 
            this.titleTextbox.BackColor = System.Drawing.Color.Transparent;
            this.titleTextbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.titleTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.titleTextbox.BorderThickness = 0;
            this.titleTextbox.Br = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LAYOUT_RightSide.SetColumnSpan(this.titleTextbox, 7);
            this.titleTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.titleTextbox.Location = new System.Drawing.Point(3, 45);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.titleTextbox.Radius = 10;
            this.titleTextbox.Size = new System.Drawing.Size(624, 36);
            this.titleTextbox.TabIndex = 2;
            this.titleTextbox.Text = "Lord of the Rings";
            this.titleTextbox.UseSystemPasswordChar = false;
            // 
            // titleLabel
            // 
            this.LAYOUT_RightSide.SetColumnSpan(this.titleLabel, 7);
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(624, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LAYOUT_LeftSide
            // 
            this.LAYOUT_LeftSide.ColumnCount = 1;
            this.LAYOUT_LeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_LeftSide.Controls.Add(this.genreDropdown, 0, 6);
            this.LAYOUT_LeftSide.Controls.Add(this.bookPictureBox, 0, 0);
            this.LAYOUT_LeftSide.Controls.Add(this.uploadImageButton, 0, 2);
            this.LAYOUT_LeftSide.Controls.Add(this.categoryDropdown, 0, 4);
            this.LAYOUT_LeftSide.Location = new System.Drawing.Point(36, 40);
            this.LAYOUT_LeftSide.Name = "LAYOUT_LeftSide";
            this.LAYOUT_LeftSide.RowCount = 7;
            this.LAYOUT_LeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.LAYOUT_LeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.157895F));
            this.LAYOUT_LeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.63158F));
            this.LAYOUT_LeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.157895F));
            this.LAYOUT_LeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.63158F));
            this.LAYOUT_LeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.157895F));
            this.LAYOUT_LeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.63158F));
            this.LAYOUT_LeftSide.Size = new System.Drawing.Size(219, 511);
            this.LAYOUT_LeftSide.TabIndex = 9;
            // 
            // genreDropdown
            // 
            this.genreDropdown.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.genreDropdown.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.genreDropdown.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.genreDropdown.BorderRadius = 10;
            this.genreDropdown.BorderSize = 0;
            this.genreDropdown.ButtonImage = global::Archivary.Properties.Resources.ICON_DROPDOWN;
            this.genreDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreDropdown.FlatAppearance.BorderSize = 0;
            this.genreDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genreDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreDropdown.ForeColor = System.Drawing.Color.White;
            this.genreDropdown.Location = new System.Drawing.Point(3, 447);
            this.genreDropdown.Name = "genreDropdown";
            this.genreDropdown.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.genreDropdown.Size = new System.Drawing.Size(213, 61);
            this.genreDropdown.TabIndex = 3;
            this.genreDropdown.Text = "Genre";
            this.genreDropdown.TextColor = System.Drawing.Color.White;
            this.genreDropdown.UseVisualStyleBackColor = false;
            this.genreDropdown.Click += new System.EventHandler(this.genreDropdown_Click);
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.bookPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookPictureBox.Location = new System.Drawing.Point(3, 3);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(213, 262);
            this.bookPictureBox.TabIndex = 0;
            this.bookPictureBox.TabStop = false;
            // 
            // uploadImageButton
            // 
            this.uploadImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.uploadImageButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.uploadImageButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.uploadImageButton.BorderRadius = 20;
            this.uploadImageButton.BorderSize = 0;
            this.uploadImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadImageButton.FlatAppearance.BorderSize = 0;
            this.uploadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImageButton.ForeColor = System.Drawing.Color.White;
            this.uploadImageButton.Location = new System.Drawing.Point(3, 287);
            this.uploadImageButton.Name = "uploadImageButton";
            this.uploadImageButton.Size = new System.Drawing.Size(213, 58);
            this.uploadImageButton.TabIndex = 1;
            this.uploadImageButton.Text = "Upload Image";
            this.uploadImageButton.TextColor = System.Drawing.Color.White;
            this.uploadImageButton.UseVisualStyleBackColor = false;
            this.uploadImageButton.Click += new System.EventHandler(this.uploadImageButton_Click);
            // 
            // categoryDropdown
            // 
            this.categoryDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.categoryDropdown.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.categoryDropdown.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.categoryDropdown.BorderRadius = 10;
            this.categoryDropdown.BorderSize = 0;
            this.categoryDropdown.ButtonImage = global::Archivary.Properties.Resources.ICON_DROPDOWN;
            this.categoryDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryDropdown.FlatAppearance.BorderSize = 0;
            this.categoryDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDropdown.ForeColor = System.Drawing.Color.White;
            this.categoryDropdown.Location = new System.Drawing.Point(3, 367);
            this.categoryDropdown.Name = "categoryDropdown";
            this.categoryDropdown.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.categoryDropdown.Size = new System.Drawing.Size(213, 58);
            this.categoryDropdown.TabIndex = 2;
            this.categoryDropdown.Text = "Category";
            this.categoryDropdown.TextColor = System.Drawing.Color.White;
            this.categoryDropdown.UseVisualStyleBackColor = false;
            this.categoryDropdown.Click += new System.EventHandler(this.categoryDropdown_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cancelButton.BorderRadius = 15;
            this.cancelButton.BorderSize = 3;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(473, 591);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(412, 58);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.White;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.saveInfoButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.saveInfoButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveInfoButton.BorderRadius = 15;
            this.saveInfoButton.BorderSize = 0;
            this.saveInfoButton.FlatAppearance.BorderSize = 0;
            this.saveInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveInfoButton.ForeColor = System.Drawing.Color.White;
            this.saveInfoButton.Location = new System.Drawing.Point(55, 591);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(412, 58);
            this.saveInfoButton.TabIndex = 7;
            this.saveInfoButton.Text = "Save Info";
            this.saveInfoButton.TextColor = System.Drawing.Color.White;
            this.saveInfoButton.UseVisualStyleBackColor = false;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // dropdownMenu1
            // 
            this.dropdownMenu1.IsMainMenu = false;
            this.dropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.academicToolStripMenuItem,
            this.nonfictionToolStripMenuItem,
            this.fictionToolStripMenuItem});
            this.dropdownMenu1.MenuItemHeight = 25;
            this.dropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropdownMenu1.Name = "dropdownMenu1";
            this.dropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.dropdownMenu1.Size = new System.Drawing.Size(137, 70);
            // 
            // academicToolStripMenuItem
            // 
            this.academicToolStripMenuItem.Name = "academicToolStripMenuItem";
            this.academicToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.academicToolStripMenuItem.Text = "Academic";
            this.academicToolStripMenuItem.Click += new System.EventHandler(this.academicToolStripMenuItem_Click_1);
            // 
            // nonfictionToolStripMenuItem
            // 
            this.nonfictionToolStripMenuItem.Name = "nonfictionToolStripMenuItem";
            this.nonfictionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.nonfictionToolStripMenuItem.Text = "Non-fiction";
            this.nonfictionToolStripMenuItem.Click += new System.EventHandler(this.nonfictionToolStripMenuItem_Click);
            // 
            // fictionToolStripMenuItem
            // 
            this.fictionToolStripMenuItem.Name = "fictionToolStripMenuItem";
            this.fictionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.fictionToolStripMenuItem.Text = "Fiction";
            this.fictionToolStripMenuItem.Click += new System.EventHandler(this.fictionToolStripMenuItem_Click);
            // 
            // dropdownMenu2
            // 
            this.dropdownMenu2.IsMainMenu = false;
            this.dropdownMenu2.MenuItemHeight = 25;
            this.dropdownMenu2.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropdownMenu2.Name = "dropdownMenu2";
            this.dropdownMenu2.PrimaryColor = System.Drawing.Color.Empty;
            this.dropdownMenu2.Size = new System.Drawing.Size(61, 4);
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
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_BOOKEDIT";
            this.PANEL_CONTENTS.ResumeLayout(false);
            this.LAYOUT_RightSide.ResumeLayout(false);
            this.LAYOUT_LeftSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.dropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_CONTENTS;
        private roundedCorners.roundedButton cancelButton;
        private roundedCorners.roundedButton saveInfoButton;
        private System.Windows.Forms.TableLayoutPanel LAYOUT_LeftSide;
        private System.Windows.Forms.TableLayoutPanel LAYOUT_RightSide;
        private System.Windows.Forms.PictureBox bookPictureBox;
        private roundedCorners.roundedButton uploadImageButton;
        private sidebarComponents.RoundedPictureButtonRight categoryDropdown;
        private sidebarComponents.RoundedPictureButtonRight genreDropdown;
        private System.Windows.Forms.Label titleLabel;
        private RoundedCorners.RoundedTextBox publisherTextbox;
        private RoundedCorners.RoundedTextBox ISBNTextbox;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private RoundedCorners.RoundedTextBox titleTextbox;
        private RoundedCorners.RoundedTextBox authorLNTextbox;
        private System.Windows.Forms.Label authorLabel;
        private RoundedCorners.RoundedTextBox shelfTextbox;
        private RoundedCorners.RoundedTextBox aisleTextbox;
        private System.Windows.Forms.Label aisleLabel;
        private RoundedCorners.RoundedTextBox copyrightTextbox;
        private System.Windows.Forms.Label copyrightLabel;
        private RoundedCorners.RoundedTextBox authorMITextbox;
        private RoundedCorners.RoundedTextBox authorFNTextbox;
        private CustomDropdown.DropdownMenu dropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem academicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonfictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fictionToolStripMenuItem;
        private CustomDropdown.DropdownMenu dropdownMenu2;
    }
}
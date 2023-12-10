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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_LIBRARY));
            this.PANEL_libraryListContainer = new System.Windows.Forms.Panel();
            this.libraryList = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filterSearchButton = new sidebarComponents.RoundedPictureButtonRight();
            this.addBookButton = new sidebarComponents.RoundedSidebarButton();
            this.LAYOUT_searchBar = new RoundedCorners.RoundedPanel();
            this.searchBar = new RoundedCorners.RoundedTextBox();
            this.filterDropdown = new CustomDropdown.DropdownMenu(this.components);
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonFictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mikhaelaPatriciaCruzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PANEL_libraryListContainer.SuspendLayout();
            this.LAYOUT_searchBar.SuspendLayout();
            this.filterDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_libraryListContainer
            // 
            this.PANEL_libraryListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_libraryListContainer.Controls.Add(this.libraryList);
            this.PANEL_libraryListContainer.Location = new System.Drawing.Point(0, 90);
            this.PANEL_libraryListContainer.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_libraryListContainer.Name = "PANEL_libraryListContainer";
            this.PANEL_libraryListContainer.Size = new System.Drawing.Size(958, 580);
            this.PANEL_libraryListContainer.TabIndex = 2;
            // 
            // libraryList
            // 
            this.libraryList.AutoScroll = true;
            this.libraryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.libraryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryList.Location = new System.Drawing.Point(0, 0);
            this.libraryList.Name = "libraryList";
            this.libraryList.Size = new System.Drawing.Size(958, 580);
            this.libraryList.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // filterSearchButton
            // 
            this.filterSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.filterSearchButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.filterSearchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.filterSearchButton.BorderRadius = 10;
            this.filterSearchButton.BorderSize = 0;
            this.filterSearchButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("filterSearchButton.ButtonImage")));
            this.filterSearchButton.FlatAppearance.BorderSize = 0;
            this.filterSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterSearchButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterSearchButton.ForeColor = System.Drawing.Color.White;
            this.filterSearchButton.Location = new System.Drawing.Point(641, 12);
            this.filterSearchButton.Name = "filterSearchButton";
            this.filterSearchButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.filterSearchButton.Size = new System.Drawing.Size(150, 54);
            this.filterSearchButton.TabIndex = 6;
            this.filterSearchButton.Text = "Filter";
            this.filterSearchButton.TextColor = System.Drawing.Color.White;
            this.filterSearchButton.UseVisualStyleBackColor = false;
            this.filterSearchButton.Click += new System.EventHandler(this.filterSearchButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.addBookButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.addBookButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.addBookButton.BorderRadius = 10;
            this.addBookButton.BorderSize = 0;
            this.addBookButton.ButtonImage = global::Archivary.Properties.Resources.ICON_ADD;
            this.addBookButton.FlatAppearance.BorderSize = 0;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.ForeColor = System.Drawing.Color.White;
            this.addBookButton.Location = new System.Drawing.Point(797, 12);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addBookButton.Size = new System.Drawing.Size(150, 54);
            this.addBookButton.TabIndex = 5;
            this.addBookButton.Text = "Add";
            this.addBookButton.TextColor = System.Drawing.Color.White;
            this.addBookButton.UseVisualStyleBackColor = false;
            // 
            // LAYOUT_searchBar
            // 
            this.LAYOUT_searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAYOUT_searchBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.LAYOUT_searchBar.BorderWidth = 1F;
            this.LAYOUT_searchBar.Controls.Add(this.searchBar);
            this.LAYOUT_searchBar.Location = new System.Drawing.Point(12, 12);
            this.LAYOUT_searchBar.Name = "LAYOUT_searchBar";
            this.LAYOUT_searchBar.Padding = new System.Windows.Forms.Padding(2);
            this.LAYOUT_searchBar.Radius = 10;
            this.LAYOUT_searchBar.Size = new System.Drawing.Size(623, 54);
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
            this.searchBar.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchBar.Location = new System.Drawing.Point(2, 2);
            this.searchBar.Name = "searchBar";
            this.searchBar.Radius = 9;
            this.searchBar.Size = new System.Drawing.Size(619, 50);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "Search Book";
            this.searchBar.UseSystemPasswordChar = false;
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.Leave += new System.EventHandler(this.searchBar_Leave);
            // 
            // filterDropdown
            // 
            this.filterDropdown.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filterDropdown.IsMainMenu = false;
            this.filterDropdown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem,
            this.fictionToolStripMenuItem,
            this.nonFictionToolStripMenuItem,
            this.mikhaelaPatriciaCruzToolStripMenuItem});
            this.filterDropdown.MenuItemHeight = 25;
            this.filterDropdown.MenuItemTextColor = System.Drawing.Color.Empty;
            this.filterDropdown.Name = "filterDropdown";
            this.filterDropdown.PrimaryColor = System.Drawing.Color.Empty;
            this.filterDropdown.Size = new System.Drawing.Size(157, 124);
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.aZToolStripMenuItem.Text = "A-Z";
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.zAToolStripMenuItem.Text = "Z-A";
            // 
            // fictionToolStripMenuItem
            // 
            this.fictionToolStripMenuItem.Name = "fictionToolStripMenuItem";
            this.fictionToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.fictionToolStripMenuItem.Text = "Fiction";
            // 
            // nonFictionToolStripMenuItem
            // 
            this.nonFictionToolStripMenuItem.Name = "nonFictionToolStripMenuItem";
            this.nonFictionToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.nonFictionToolStripMenuItem.Text = "Non-Fiction";
            // 
            // mikhaelaPatriciaCruzToolStripMenuItem
            // 
            this.mikhaelaPatriciaCruzToolStripMenuItem.Name = "mikhaelaPatriciaCruzToolStripMenuItem";
            this.mikhaelaPatriciaCruzToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.mikhaelaPatriciaCruzToolStripMenuItem.Text = "Academic";
            // 
            // FORM_LIBRARY
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.filterSearchButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.LAYOUT_searchBar);
            this.Controls.Add(this.PANEL_libraryListContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_LIBRARY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORM_LIBRARY_Load);
            this.Resize += new System.EventHandler(this.FORM_LIBRARY_Resize);
            this.PANEL_libraryListContainer.ResumeLayout(false);
            this.LAYOUT_searchBar.ResumeLayout(false);
            this.filterDropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedCorners.RoundedPanel LAYOUT_searchBar;
        private RoundedCorners.RoundedTextBox searchBar;
        private System.Windows.Forms.Panel PANEL_libraryListContainer;
        private System.Windows.Forms.FlowLayoutPanel libraryList;
        private sidebarComponents.RoundedSidebarButton addBookButton;
        private sidebarComponents.RoundedPictureButtonRight filterSearchButton;
        private CustomDropdown.DropdownMenu filterDropdown;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonFictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mikhaelaPatriciaCruzToolStripMenuItem;
    }
}
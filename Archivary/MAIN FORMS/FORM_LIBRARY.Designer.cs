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
            this.PANEL_libraryListContainer = new System.Windows.Forms.Panel();
            this.libraryList = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedSidebarButton1 = new sidebarComponents.RoundedSidebarButton();
            this.roundedButton1 = new roundedCorners.roundedButton();
            this.LAYOUT_searchBar = new RoundedCorners.RoundedPanel();
            this.searchBar = new RoundedCorners.RoundedTextBox();
            this.dropdownMenu1 = new CustomDropdown.DropdownMenu(this.components);
            this.fictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonfictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PANEL_libraryListContainer.SuspendLayout();
            this.LAYOUT_searchBar.SuspendLayout();
            this.dropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_libraryListContainer
            // 
            this.PANEL_libraryListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_libraryListContainer.Controls.Add(this.libraryList);
            this.PANEL_libraryListContainer.Location = new System.Drawing.Point(5, 93);
            this.PANEL_libraryListContainer.Name = "PANEL_libraryListContainer";
            this.PANEL_libraryListContainer.Padding = new System.Windows.Forms.Padding(10);
            this.PANEL_libraryListContainer.Size = new System.Drawing.Size(952, 574);
            this.PANEL_libraryListContainer.TabIndex = 2;
            // 
            // libraryList
            // 
            this.libraryList.AutoScroll = true;
            this.libraryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.libraryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryList.Location = new System.Drawing.Point(10, 10);
            this.libraryList.Name = "libraryList";
            this.libraryList.Size = new System.Drawing.Size(932, 554);
            this.libraryList.TabIndex = 0;
            // 
            // roundedSidebarButton1
            // 
            this.roundedSidebarButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedSidebarButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.roundedSidebarButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.roundedSidebarButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.roundedSidebarButton1.BorderRadius = 20;
            this.roundedSidebarButton1.BorderSize = 0;
            this.roundedSidebarButton1.ButtonImage = global::Archivary.Properties.Resources.ICON_USER;
            this.roundedSidebarButton1.FlatAppearance.BorderSize = 0;
            this.roundedSidebarButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedSidebarButton1.ForeColor = System.Drawing.Color.White;
            this.roundedSidebarButton1.Location = new System.Drawing.Point(756, 12);
            this.roundedSidebarButton1.Name = "roundedSidebarButton1";
            this.roundedSidebarButton1.Size = new System.Drawing.Size(175, 54);
            this.roundedSidebarButton1.TabIndex = 5;
            this.roundedSidebarButton1.Text = "roundedSidebarButton1";
            this.roundedSidebarButton1.TextColor = System.Drawing.Color.White;
            this.roundedSidebarButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 40;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(573, 10);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(150, 54);
            this.roundedButton1.TabIndex = 3;
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
            this.LAYOUT_searchBar.Location = new System.Drawing.Point(12, 12);
            this.LAYOUT_searchBar.Name = "LAYOUT_searchBar";
            this.LAYOUT_searchBar.Padding = new System.Windows.Forms.Padding(2);
            this.LAYOUT_searchBar.Radius = 10;
            this.LAYOUT_searchBar.Size = new System.Drawing.Size(510, 54);
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
            this.searchBar.Size = new System.Drawing.Size(506, 50);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "l";
            this.searchBar.UseSystemPasswordChar = false;
            // 
            // dropdownMenu1
            // 
            this.dropdownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dropdownMenu1.IsMainMenu = false;
            this.dropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fictionToolStripMenuItem,
            this.nonfictionToolStripMenuItem,
            this.academicToolStripMenuItem});
            this.dropdownMenu1.MenuItemHeight = 25;
            this.dropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropdownMenu1.Name = "dropdownMenu1";
            this.dropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.dropdownMenu1.Size = new System.Drawing.Size(146, 76);
            // 
            // fictionToolStripMenuItem
            // 
            this.fictionToolStripMenuItem.Name = "fictionToolStripMenuItem";
            this.fictionToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.fictionToolStripMenuItem.Text = "fiction";
            // 
            // nonfictionToolStripMenuItem
            // 
            this.nonfictionToolStripMenuItem.Name = "nonfictionToolStripMenuItem";
            this.nonfictionToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.nonfictionToolStripMenuItem.Text = "nonfiction";
            // 
            // academicToolStripMenuItem
            // 
            this.academicToolStripMenuItem.Name = "academicToolStripMenuItem";
            this.academicToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.academicToolStripMenuItem.Text = "academic";
            // 
            // FORM_LIBRARY
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.roundedSidebarButton1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.PANEL_libraryListContainer);
            this.Controls.Add(this.LAYOUT_searchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_LIBRARY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORM_LIBRARY_Load);
            this.Resize += new System.EventHandler(this.FORM_LIBRARY_Resize);
            this.PANEL_libraryListContainer.ResumeLayout(false);
            this.LAYOUT_searchBar.ResumeLayout(false);
            this.dropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedCorners.RoundedPanel LAYOUT_searchBar;
        private RoundedCorners.RoundedTextBox searchBar;
        private System.Windows.Forms.Panel PANEL_libraryListContainer;
        private System.Windows.Forms.FlowLayoutPanel libraryList;
        private CustomDropdown.DropdownMenu dropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem fictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonfictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academicToolStripMenuItem;
        private roundedCorners.roundedButton roundedButton1;
        private sidebarComponents.RoundedSidebarButton roundedSidebarButton1;
    }
}
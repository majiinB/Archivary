namespace Archivary.PARENT_FORMS
{
    partial class FORM_USERS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_USERS));
            this.PANEL_userListContainer = new RoundedCorners.RoundedPanel();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterSearchButton = new sidebarComponents.RoundedPictureButtonRight();
            this.addUserButton = new sidebarComponents.RoundedSidebarButton();
            this.LAYOUT_searchBar = new RoundedCorners.RoundedPanel();
            this.searchBar = new RoundedCorners.RoundedTextBox();
            this.filterDropdown = new CustomDropdown.DropdownMenu(this.components);
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PANEL_userListContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.LAYOUT_searchBar.SuspendLayout();
            this.filterDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_userListContainer
            // 
            this.PANEL_userListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_userListContainer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PANEL_userListContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PANEL_userListContainer.BorderWidth = 1F;
            this.PANEL_userListContainer.Controls.Add(this.userDataGridView);
            this.PANEL_userListContainer.Location = new System.Drawing.Point(0, 90);
            this.PANEL_userListContainer.Margin = new System.Windows.Forms.Padding(10);
            this.PANEL_userListContainer.Name = "PANEL_userListContainer";
            this.PANEL_userListContainer.Radius = 10;
            this.PANEL_userListContainer.Size = new System.Drawing.Size(958, 580);
            this.PANEL_userListContainer.TabIndex = 2;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AllowUserToResizeColumns = false;
            this.userDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.userDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.userDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumnHeader,
            this.userIDColumnHeader,
            this.roleColumnHeader,
            this.statusColumnHeader});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userDataGridView.EnableHeadersVisualStyles = false;
            this.userDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userDataGridView.Location = new System.Drawing.Point(0, 0);
            this.userDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.userDataGridView.MultiSelect = false;
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userDataGridView.RowHeadersVisible = false;
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.userDataGridView.RowTemplate.Height = 100;
            this.userDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.Size = new System.Drawing.Size(958, 580);
            this.userDataGridView.TabIndex = 6;
            this.userDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellDoubleClick);
            this.userDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.userDataGridView_CellFormatting);
            this.userDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.userDataGridView_RowsAdded);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumnHeader.HeaderText = "NAME";
            this.nameColumnHeader.MinimumWidth = 6;
            this.nameColumnHeader.Name = "nameColumnHeader";
            this.nameColumnHeader.ReadOnly = true;
            // 
            // userIDColumnHeader
            // 
            this.userIDColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIDColumnHeader.HeaderText = "USER ID";
            this.userIDColumnHeader.MinimumWidth = 6;
            this.userIDColumnHeader.Name = "userIDColumnHeader";
            this.userIDColumnHeader.ReadOnly = true;
            this.userIDColumnHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // roleColumnHeader
            // 
            this.roleColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleColumnHeader.HeaderText = "ROLE";
            this.roleColumnHeader.MinimumWidth = 6;
            this.roleColumnHeader.Name = "roleColumnHeader";
            this.roleColumnHeader.ReadOnly = true;
            // 
            // statusColumnHeader
            // 
            this.statusColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusColumnHeader.HeaderText = "STATUS";
            this.statusColumnHeader.MinimumWidth = 6;
            this.statusColumnHeader.Name = "statusColumnHeader";
            this.statusColumnHeader.ReadOnly = true;
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
            this.filterSearchButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.filterSearchButton.ForeColor = System.Drawing.Color.White;
            this.filterSearchButton.Location = new System.Drawing.Point(642, 12);
            this.filterSearchButton.Name = "filterSearchButton";
            this.filterSearchButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.filterSearchButton.Size = new System.Drawing.Size(150, 54);
            this.filterSearchButton.TabIndex = 6;
            this.filterSearchButton.Text = "Filter";
            this.filterSearchButton.TextColor = System.Drawing.Color.White;
            this.filterSearchButton.UseVisualStyleBackColor = false;
            this.filterSearchButton.Click += new System.EventHandler(this.filterSearchButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.addUserButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.addUserButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.addUserButton.BorderRadius = 10;
            this.addUserButton.BorderSize = 0;
            this.addUserButton.ButtonImage = global::Archivary.Properties.Resources.ICON_ADD;
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.Location = new System.Drawing.Point(798, 12);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addUserButton.Size = new System.Drawing.Size(150, 54);
            this.addUserButton.TabIndex = 9;
            this.addUserButton.Text = "Add";
            this.addUserButton.TextColor = System.Drawing.Color.White;
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
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
            this.LAYOUT_searchBar.Size = new System.Drawing.Size(624, 54);
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
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchBar.Location = new System.Drawing.Point(2, 2);
            this.searchBar.Name = "searchBar";
            this.searchBar.Radius = 9;
            this.searchBar.ReadOnly = false;
            this.searchBar.Size = new System.Drawing.Size(620, 50);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "Search User";
            this.searchBar.UseSystemPasswordChar = false;
            this.searchBar.TextChanged += new System.EventHandler(this.Search);
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.Leave += new System.EventHandler(this.searchBar_Leave);
            // 
            // filterDropdown
            // 
            this.filterDropdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filterDropdown.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filterDropdown.IsMainMenu = false;
            this.filterDropdown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.filterDropdown.MenuItemHeight = 25;
            this.filterDropdown.MenuItemTextColor = System.Drawing.Color.Empty;
            this.filterDropdown.Name = "dropdownMenu1";
            this.filterDropdown.PrimaryColor = System.Drawing.Color.Empty;
            this.filterDropdown.Size = new System.Drawing.Size(145, 100);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.teacherToolStripMenuItem.Text = "Teacher";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.teacherToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // FORM_USERS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.PANEL_userListContainer);
            this.Controls.Add(this.filterSearchButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.LAYOUT_searchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_USERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_USERS";
            this.Load += new System.EventHandler(this.FORM_USERS_Load);
            this.Resize += new System.EventHandler(this.FORM_USERS_Resize);
            this.PANEL_userListContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.LAYOUT_searchBar.ResumeLayout(false);
            this.filterDropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private sidebarComponents.RoundedPictureButtonRight filterSearchButton;
        private sidebarComponents.RoundedSidebarButton addUserButton;
        private RoundedCorners.RoundedPanel LAYOUT_searchBar;
        private RoundedCorners.RoundedTextBox searchBar;
        private CustomDropdown.DropdownMenu filterDropdown;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private RoundedCorners.RoundedPanel PANEL_userListContainer;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumnHeader;
    }
}
namespace Archivary._1500X1000.FORM_USERS
{
    partial class FORM_INFOSTUDENT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookListDataGridView = new System.Windows.Forms.DataGridView();
            this.bookTitleColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBorrowedColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnStatusColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PANEL_collegeAndSection = new System.Windows.Forms.FlowLayoutPanel();
            this.PANEL_college = new RoundedCorners.RoundedPanel();
            this.collegeLabel = new System.Windows.Forms.Label();
            this.PANEL_section = new RoundedCorners.RoundedPanel();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.PANEL_name = new System.Windows.Forms.FlowLayoutPanel();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.LAYOUT_userinfo = new System.Windows.Forms.TableLayoutPanel();
            this.PANEL_address = new System.Windows.Forms.TableLayoutPanel();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressPictureBox = new custom.RoundedPictureBox();
            this.PANEL_contactNumber = new System.Windows.Forms.TableLayoutPanel();
            this.contactNumLabel = new System.Windows.Forms.Label();
            this.contactNumPictureBox = new custom.RoundedPictureBox();
            this.editInfoButton = new roundedCorners.roundedButton();
            this.backButton = new roundedCorners.roundedButton();
            this.changeStatusButton = new roundedCorners.roundedButton();
            this.roundedPictureBox1 = new custom.RoundedPictureBox();
            this.PANEL_role = new RoundedCorners.RoundedPanel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.PANEL_penalty = new RoundedCorners.RoundedPanel();
            this.penaltyCountLabel = new System.Windows.Forms.Label();
            this.penaltyLabel = new System.Windows.Forms.Label();
            this.PANEL_email = new System.Windows.Forms.TableLayoutPanel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailPictureBox = new custom.RoundedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).BeginInit();
            this.PANEL_collegeAndSection.SuspendLayout();
            this.PANEL_college.SuspendLayout();
            this.PANEL_section.SuspendLayout();
            this.PANEL_name.SuspendLayout();
            this.LAYOUT_userinfo.SuspendLayout();
            this.PANEL_address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressPictureBox)).BeginInit();
            this.PANEL_contactNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactNumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.PANEL_role.SuspendLayout();
            this.PANEL_penalty.SuspendLayout();
            this.PANEL_email.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bookListDataGridView
            // 
            this.bookListDataGridView.AllowUserToAddRows = false;
            this.bookListDataGridView.AllowUserToDeleteRows = false;
            this.bookListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookListDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.bookListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookTitleColumnHeader,
            this.dateBorrowedColumnHeader,
            this.returnDateColumnHeader,
            this.dateReturnedColumnHeader,
            this.returnStatusColumnHeader});
            this.LAYOUT_userinfo.SetColumnSpan(this.bookListDataGridView, 5);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookListDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.bookListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bookListDataGridView.EnableHeadersVisualStyles = false;
            this.bookListDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.bookListDataGridView.Location = new System.Drawing.Point(11, 245);
            this.bookListDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.bookListDataGridView.MultiSelect = false;
            this.bookListDataGridView.Name = "bookListDataGridView";
            this.bookListDataGridView.ReadOnly = true;
            this.bookListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookListDataGridView.RowHeadersVisible = false;
            this.bookListDataGridView.RowHeadersWidth = 51;
            this.bookListDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.bookListDataGridView.RowTemplate.Height = 24;
            this.bookListDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookListDataGridView.ShowCellToolTips = false;
            this.bookListDataGridView.ShowEditingIcon = false;
            this.bookListDataGridView.Size = new System.Drawing.Size(694, 213);
            this.bookListDataGridView.TabIndex = 7;
            this.bookListDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.bookListDataGridView_RowsAdded);
            // 
            // bookTitleColumnHeader
            // 
            this.bookTitleColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookTitleColumnHeader.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookTitleColumnHeader.HeaderText = "TITLE";
            this.bookTitleColumnHeader.MinimumWidth = 6;
            this.bookTitleColumnHeader.Name = "bookTitleColumnHeader";
            this.bookTitleColumnHeader.ReadOnly = true;
            // 
            // dateBorrowedColumnHeader
            // 
            this.dateBorrowedColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateBorrowedColumnHeader.HeaderText = "DATE BORROWED";
            this.dateBorrowedColumnHeader.MinimumWidth = 6;
            this.dateBorrowedColumnHeader.Name = "dateBorrowedColumnHeader";
            this.dateBorrowedColumnHeader.ReadOnly = true;
            // 
            // returnDateColumnHeader
            // 
            this.returnDateColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.returnDateColumnHeader.HeaderText = "RETURN DUE DATE";
            this.returnDateColumnHeader.MinimumWidth = 6;
            this.returnDateColumnHeader.Name = "returnDateColumnHeader";
            this.returnDateColumnHeader.ReadOnly = true;
            // 
            // dateReturnedColumnHeader
            // 
            this.dateReturnedColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateReturnedColumnHeader.HeaderText = "DATE RETURNED";
            this.dateReturnedColumnHeader.MinimumWidth = 6;
            this.dateReturnedColumnHeader.Name = "dateReturnedColumnHeader";
            this.dateReturnedColumnHeader.ReadOnly = true;
            // 
            // returnStatusColumnHeader
            // 
            this.returnStatusColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.returnStatusColumnHeader.HeaderText = "STATUS";
            this.returnStatusColumnHeader.MinimumWidth = 6;
            this.returnStatusColumnHeader.Name = "returnStatusColumnHeader";
            this.returnStatusColumnHeader.ReadOnly = true;
            // 
            // PANEL_collegeAndSection
            // 
            this.LAYOUT_userinfo.SetColumnSpan(this.PANEL_collegeAndSection, 3);
            this.PANEL_collegeAndSection.Controls.Add(this.PANEL_college);
            this.PANEL_collegeAndSection.Controls.Add(this.PANEL_section);
            this.PANEL_collegeAndSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_collegeAndSection.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.PANEL_collegeAndSection.Location = new System.Drawing.Point(15, 105);
            this.PANEL_collegeAndSection.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.PANEL_collegeAndSection.Name = "PANEL_collegeAndSection";
            this.PANEL_collegeAndSection.Size = new System.Drawing.Size(492, 34);
            this.PANEL_collegeAndSection.TabIndex = 8;
            // 
            // PANEL_college
            // 
            this.PANEL_college.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PANEL_college.AutoSize = true;
            this.PANEL_college.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PANEL_college.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_college.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PANEL_college.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PANEL_college.BorderWidth = 1F;
            this.PANEL_college.Controls.Add(this.collegeLabel);
            this.PANEL_college.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_college.Location = new System.Drawing.Point(0, 13);
            this.PANEL_college.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.PANEL_college.MaximumSize = new System.Drawing.Size(412, 21);
            this.PANEL_college.MinimumSize = new System.Drawing.Size(0, 21);
            this.PANEL_college.Name = "PANEL_college";
            this.PANEL_college.Radius = 10;
            this.PANEL_college.Size = new System.Drawing.Size(137, 21);
            this.PANEL_college.TabIndex = 9;
            // 
            // collegeLabel
            // 
            this.collegeLabel.AutoSize = true;
            this.collegeLabel.BackColor = System.Drawing.Color.Transparent;
            this.collegeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collegeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collegeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.collegeLabel.Location = new System.Drawing.Point(0, 0);
            this.collegeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.collegeLabel.Name = "collegeLabel";
            this.collegeLabel.Padding = new System.Windows.Forms.Padding(8, 2, 8, 4);
            this.collegeLabel.Size = new System.Drawing.Size(137, 19);
            this.collegeLabel.TabIndex = 0;
            this.collegeLabel.Text = "COLLEGE OF USER";
            this.collegeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.collegeLabel.UseMnemonic = false;
            // 
            // PANEL_section
            // 
            this.PANEL_section.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PANEL_section.AutoSize = true;
            this.PANEL_section.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PANEL_section.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.PANEL_section.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.PANEL_section.BorderWidth = 1F;
            this.PANEL_section.Controls.Add(this.sectionLabel);
            this.PANEL_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_section.Location = new System.Drawing.Point(145, 13);
            this.PANEL_section.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_section.MaximumSize = new System.Drawing.Size(150, 21);
            this.PANEL_section.MinimumSize = new System.Drawing.Size(0, 21);
            this.PANEL_section.Name = "PANEL_section";
            this.PANEL_section.Radius = 10;
            this.PANEL_section.Size = new System.Drawing.Size(114, 21);
            this.PANEL_section.TabIndex = 9;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.sectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sectionLabel.Location = new System.Drawing.Point(0, 0);
            this.sectionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Padding = new System.Windows.Forms.Padding(8, 2, 8, 4);
            this.sectionLabel.Size = new System.Drawing.Size(114, 19);
            this.sectionLabel.TabIndex = 0;
            this.sectionLabel.Text = "YEAR-SECTION";
            this.sectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sectionLabel.UseMnemonic = false;
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoEllipsis = true;
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.LAYOUT_userinfo.SetColumnSpan(this.userIDLabel, 2);
            this.userIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.userIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.userIDLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.userIDLabel.Location = new System.Drawing.Point(11, 12);
            this.userIDLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(316, 59);
            this.userIDLabel.TabIndex = 3;
            this.userIDLabel.Text = "S00000000";
            this.userIDLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PANEL_name
            // 
            this.LAYOUT_userinfo.SetColumnSpan(this.PANEL_name, 3);
            this.PANEL_name.Controls.Add(this.lastNameLabel);
            this.PANEL_name.Controls.Add(this.firstNameLabel);
            this.PANEL_name.Controls.Add(this.middleNameLabel);
            this.PANEL_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_name.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.PANEL_name.Location = new System.Drawing.Point(15, 71);
            this.PANEL_name.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.PANEL_name.Name = "PANEL_name";
            this.PANEL_name.Size = new System.Drawing.Size(492, 34);
            this.PANEL_name.TabIndex = 9;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lastNameLabel.Location = new System.Drawing.Point(0, 9);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 25);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name,";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.firstNameLabel.Location = new System.Drawing.Point(121, 15);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 17);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.middleNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.middleNameLabel.Location = new System.Drawing.Point(207, 15);
            this.middleNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(34, 17);
            this.middleNameLabel.TabIndex = 2;
            this.middleNameLabel.Text = "M.I.";
            this.middleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LAYOUT_userinfo
            // 
            this.LAYOUT_userinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LAYOUT_userinfo.ColumnCount = 5;
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.13799F));
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.62067F));
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.62067F));
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.62067F));
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_address, 0, 5);
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_contactNumber, 0, 4);
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_name, 0, 1);
            this.LAYOUT_userinfo.Controls.Add(this.editInfoButton, 2, 9);
            this.LAYOUT_userinfo.Controls.Add(this.userIDLabel, 0, 0);
            this.LAYOUT_userinfo.Controls.Add(this.backButton, 0, 9);
            this.LAYOUT_userinfo.Controls.Add(this.changeStatusButton, 4, 9);
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_collegeAndSection, 0, 2);
            this.LAYOUT_userinfo.Controls.Add(this.bookListDataGridView, 0, 7);
            this.LAYOUT_userinfo.Controls.Add(this.roundedPictureBox1, 4, 0);
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_role, 2, 0);
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_penalty, 4, 5);
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_email, 0, 3);
            this.LAYOUT_userinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_userinfo.Location = new System.Drawing.Point(2, 2);
            this.LAYOUT_userinfo.Margin = new System.Windows.Forms.Padding(4);
            this.LAYOUT_userinfo.Name = "LAYOUT_userinfo";
            this.LAYOUT_userinfo.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.LAYOUT_userinfo.RowCount = 10;
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LAYOUT_userinfo.Size = new System.Drawing.Size(716, 540);
            this.LAYOUT_userinfo.TabIndex = 7;
            // 
            // PANEL_address
            // 
            this.PANEL_address.ColumnCount = 2;
            this.LAYOUT_userinfo.SetColumnSpan(this.PANEL_address, 3);
            this.PANEL_address.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PANEL_address.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.PANEL_address.Controls.Add(this.addressLabel, 0, 0);
            this.PANEL_address.Controls.Add(this.addressPictureBox, 0, 0);
            this.PANEL_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_address.Location = new System.Drawing.Point(11, 207);
            this.PANEL_address.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_address.Name = "PANEL_address";
            this.PANEL_address.RowCount = 1;
            this.PANEL_address.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_address.Size = new System.Drawing.Size(496, 34);
            this.PANEL_address.TabIndex = 14;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoEllipsis = true;
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.addressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressLabel.Location = new System.Drawing.Point(24, 2);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(472, 30);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressLabel.UseMnemonic = false;
            // 
            // addressPictureBox
            // 
            this.addressPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.addressPictureBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.addressPictureBox.BorderRadius = 3;
            this.addressPictureBox.BorderSize = 1;
            this.addressPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressPictureBox.Location = new System.Drawing.Point(4, 8);
            this.addressPictureBox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.addressPictureBox.Name = "addressPictureBox";
            this.addressPictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.addressPictureBox.Size = new System.Drawing.Size(16, 18);
            this.addressPictureBox.TabIndex = 1;
            this.addressPictureBox.TabStop = false;
            // 
            // PANEL_contactNumber
            // 
            this.PANEL_contactNumber.ColumnCount = 2;
            this.LAYOUT_userinfo.SetColumnSpan(this.PANEL_contactNumber, 3);
            this.PANEL_contactNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PANEL_contactNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.PANEL_contactNumber.Controls.Add(this.contactNumLabel, 0, 0);
            this.PANEL_contactNumber.Controls.Add(this.contactNumPictureBox, 0, 0);
            this.PANEL_contactNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_contactNumber.Location = new System.Drawing.Point(11, 173);
            this.PANEL_contactNumber.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_contactNumber.Name = "PANEL_contactNumber";
            this.PANEL_contactNumber.RowCount = 1;
            this.PANEL_contactNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_contactNumber.Size = new System.Drawing.Size(496, 34);
            this.PANEL_contactNumber.TabIndex = 13;
            // 
            // contactNumLabel
            // 
            this.contactNumLabel.AutoSize = true;
            this.contactNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.contactNumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactNumLabel.Location = new System.Drawing.Point(24, 2);
            this.contactNumLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.contactNumLabel.Name = "contactNumLabel";
            this.contactNumLabel.Size = new System.Drawing.Size(472, 30);
            this.contactNumLabel.TabIndex = 2;
            this.contactNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactNumLabel.UseMnemonic = false;
            // 
            // contactNumPictureBox
            // 
            this.contactNumPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.contactNumPictureBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.contactNumPictureBox.BorderRadius = 3;
            this.contactNumPictureBox.BorderSize = 1;
            this.contactNumPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactNumPictureBox.Location = new System.Drawing.Point(4, 8);
            this.contactNumPictureBox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.contactNumPictureBox.Name = "contactNumPictureBox";
            this.contactNumPictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.contactNumPictureBox.Size = new System.Drawing.Size(16, 18);
            this.contactNumPictureBox.TabIndex = 1;
            this.contactNumPictureBox.TabStop = false;
            // 
            // editInfoButton
            // 
            this.editInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editInfoButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editInfoButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editInfoButton.BorderRadius = 15;
            this.editInfoButton.BorderSize = 0;
            this.editInfoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editInfoButton.FlatAppearance.BorderSize = 0;
            this.editInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInfoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.editInfoButton.Location = new System.Drawing.Point(329, 476);
            this.editInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.editInfoButton.Name = "editInfoButton";
            this.editInfoButton.Size = new System.Drawing.Size(176, 50);
            this.editInfoButton.TabIndex = 0;
            this.editInfoButton.Text = "EDIT INFO";
            this.editInfoButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.editInfoButton.UseVisualStyleBackColor = false;
            this.editInfoButton.Click += new System.EventHandler(this.editInfoButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.backButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.backButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.backButton.BorderRadius = 15;
            this.backButton.BorderSize = 3;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.backButton.Location = new System.Drawing.Point(13, 476);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 50);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "BACK";
            this.backButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backButton_Click);
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.changeStatusButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.changeStatusButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.changeStatusButton.BorderRadius = 15;
            this.changeStatusButton.BorderSize = 0;
            this.changeStatusButton.FlatAppearance.BorderSize = 0;
            this.changeStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.changeStatusButton.Location = new System.Drawing.Point(524, 476);
            this.changeStatusButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(177, 44);
            this.changeStatusButton.TabIndex = 6;
            this.changeStatusButton.Text = "DEACTIVATE";
            this.changeStatusButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.changeStatusButton.UseVisualStyleBackColor = false;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.roundedPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.roundedPictureBox1.BorderRadius = 1;
            this.roundedPictureBox1.BorderSize = 1;
            this.roundedPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPictureBox1.Image = global::Archivary.Properties.Resources.PLACEHOLDER_PICTURE;
            this.roundedPictureBox1.Location = new System.Drawing.Point(524, 14);
            this.roundedPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Padding = new System.Windows.Forms.Padding(1);
            this.LAYOUT_userinfo.SetRowSpan(this.roundedPictureBox1, 5);
            this.roundedPictureBox1.Size = new System.Drawing.Size(179, 191);
            this.roundedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundedPictureBox1.TabIndex = 10;
            this.roundedPictureBox1.TabStop = false;
            // 
            // PANEL_role
            // 
            this.PANEL_role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PANEL_role.AutoSize = true;
            this.PANEL_role.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PANEL_role.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.PANEL_role.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.PANEL_role.BorderWidth = 1F;
            this.PANEL_role.Controls.Add(this.roleLabel);
            this.PANEL_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_role.Location = new System.Drawing.Point(327, 50);
            this.PANEL_role.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_role.MaximumSize = new System.Drawing.Size(150, 21);
            this.PANEL_role.MinimumSize = new System.Drawing.Size(0, 21);
            this.PANEL_role.Name = "PANEL_role";
            this.PANEL_role.Radius = 10;
            this.PANEL_role.Size = new System.Drawing.Size(88, 21);
            this.PANEL_role.TabIndex = 7;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.roleLabel.Location = new System.Drawing.Point(0, 0);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Padding = new System.Windows.Forms.Padding(11, 2, 11, 4);
            this.roleLabel.Size = new System.Drawing.Size(88, 19);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "STUDENT";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roleLabel.UseMnemonic = false;
            // 
            // PANEL_penalty
            // 
            this.PANEL_penalty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PANEL_penalty.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.PANEL_penalty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.PANEL_penalty.BorderWidth = 1F;
            this.PANEL_penalty.Controls.Add(this.penaltyCountLabel);
            this.PANEL_penalty.Controls.Add(this.penaltyLabel);
            this.PANEL_penalty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_penalty.Location = new System.Drawing.Point(522, 211);
            this.PANEL_penalty.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.PANEL_penalty.MaximumSize = new System.Drawing.Size(0, 21);
            this.PANEL_penalty.MinimumSize = new System.Drawing.Size(90, 21);
            this.PANEL_penalty.Name = "PANEL_penalty";
            this.PANEL_penalty.Radius = 10;
            this.PANEL_penalty.Size = new System.Drawing.Size(183, 21);
            this.PANEL_penalty.TabIndex = 11;
            // 
            // penaltyCountLabel
            // 
            this.penaltyCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.penaltyCountLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.penaltyCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.penaltyCountLabel.Location = new System.Drawing.Point(139, 0);
            this.penaltyCountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.penaltyCountLabel.Name = "penaltyCountLabel";
            this.penaltyCountLabel.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.penaltyCountLabel.Size = new System.Drawing.Size(44, 21);
            this.penaltyCountLabel.TabIndex = 1;
            this.penaltyCountLabel.Text = "0";
            this.penaltyCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.penaltyCountLabel.UseMnemonic = false;
            // 
            // penaltyLabel
            // 
            this.penaltyLabel.BackColor = System.Drawing.Color.Transparent;
            this.penaltyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.penaltyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.penaltyLabel.Location = new System.Drawing.Point(0, 0);
            this.penaltyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.penaltyLabel.Name = "penaltyLabel";
            this.penaltyLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.penaltyLabel.Size = new System.Drawing.Size(99, 21);
            this.penaltyLabel.TabIndex = 0;
            this.penaltyLabel.Text = "Penalty Count: ";
            this.penaltyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyLabel.UseMnemonic = false;
            // 
            // PANEL_email
            // 
            this.PANEL_email.ColumnCount = 2;
            this.LAYOUT_userinfo.SetColumnSpan(this.PANEL_email, 3);
            this.PANEL_email.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PANEL_email.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.PANEL_email.Controls.Add(this.emailLabel, 1, 0);
            this.PANEL_email.Controls.Add(this.emailPictureBox, 0, 0);
            this.PANEL_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_email.Location = new System.Drawing.Point(11, 139);
            this.PANEL_email.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_email.Name = "PANEL_email";
            this.PANEL_email.RowCount = 1;
            this.PANEL_email.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_email.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.PANEL_email.Size = new System.Drawing.Size(496, 34);
            this.PANEL_email.TabIndex = 12;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoEllipsis = true;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.emailLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.Location = new System.Drawing.Point(24, 2);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(472, 30);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.UseMnemonic = false;
            // 
            // emailPictureBox
            // 
            this.emailPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.emailPictureBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.emailPictureBox.BorderRadius = 3;
            this.emailPictureBox.BorderSize = 1;
            this.emailPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailPictureBox.Location = new System.Drawing.Point(4, 8);
            this.emailPictureBox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.emailPictureBox.Name = "emailPictureBox";
            this.emailPictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.emailPictureBox.Size = new System.Drawing.Size(16, 18);
            this.emailPictureBox.TabIndex = 0;
            this.emailPictureBox.TabStop = false;
            // 
            // FORM_INFOSTUDENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(720, 544);
            this.Controls.Add(this.LAYOUT_userinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_INFOSTUDENT";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_INFOSTUDENT";
            this.Load += new System.EventHandler(this.FORM_INFOSTUDENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).EndInit();
            this.PANEL_collegeAndSection.ResumeLayout(false);
            this.PANEL_collegeAndSection.PerformLayout();
            this.PANEL_college.ResumeLayout(false);
            this.PANEL_college.PerformLayout();
            this.PANEL_section.ResumeLayout(false);
            this.PANEL_section.PerformLayout();
            this.PANEL_name.ResumeLayout(false);
            this.PANEL_name.PerformLayout();
            this.LAYOUT_userinfo.ResumeLayout(false);
            this.LAYOUT_userinfo.PerformLayout();
            this.PANEL_address.ResumeLayout(false);
            this.PANEL_address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressPictureBox)).EndInit();
            this.PANEL_contactNumber.ResumeLayout(false);
            this.PANEL_contactNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactNumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.PANEL_role.ResumeLayout(false);
            this.PANEL_role.PerformLayout();
            this.PANEL_penalty.ResumeLayout(false);
            this.PANEL_email.ResumeLayout(false);
            this.PANEL_email.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedCorners.RoundedPanel PANEL_penalty;
        private System.Windows.Forms.Label penaltyLabel;
        private RoundedCorners.RoundedPanel PANEL_role;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.DataGridView bookListDataGridView;
        private System.Windows.Forms.TableLayoutPanel LAYOUT_userinfo;
        private System.Windows.Forms.FlowLayoutPanel PANEL_name;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private roundedCorners.roundedButton editInfoButton;
        private System.Windows.Forms.Label userIDLabel;
        private roundedCorners.roundedButton backButton;
        private roundedCorners.roundedButton changeStatusButton;
        private System.Windows.Forms.FlowLayoutPanel PANEL_collegeAndSection;
        private RoundedCorners.RoundedPanel PANEL_college;
        private System.Windows.Forms.Label collegeLabel;
        private RoundedCorners.RoundedPanel PANEL_section;
        private System.Windows.Forms.Label sectionLabel;
        private custom.RoundedPictureBox roundedPictureBox1;
        private System.Windows.Forms.TableLayoutPanel PANEL_email;
        private System.Windows.Forms.Label penaltyCountLabel;
        private System.Windows.Forms.TableLayoutPanel PANEL_address;
        private System.Windows.Forms.TableLayoutPanel PANEL_contactNumber;
        private custom.RoundedPictureBox emailPictureBox;
        private custom.RoundedPictureBox addressPictureBox;
        private custom.RoundedPictureBox contactNumPictureBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactNumLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBorrowedColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnStatusColumnHeader;
    }
}
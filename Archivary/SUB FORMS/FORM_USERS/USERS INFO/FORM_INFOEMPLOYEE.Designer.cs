namespace Archivary._1500X1000.FORM_USERS
{
    partial class FORM_INFOEMPLOYEE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_INFOEMPLOYEE));
            this.emailLabel = new System.Windows.Forms.Label();
            this.contactNumLabel = new System.Windows.Forms.Label();
            this.PANEL_contactNumber = new System.Windows.Forms.TableLayoutPanel();
            this.addressLabel = new System.Windows.Forms.Label();
            this.PANEL_address = new System.Windows.Forms.TableLayoutPanel();
            this.LAYOUT_userinfo = new System.Windows.Forms.TableLayoutPanel();
            this.PANEL_name = new System.Windows.Forms.FlowLayoutPanel();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.bookListDataGridView = new System.Windows.Forms.DataGridView();
            this.bookTitleColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBorrowedColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnStatusColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PANEL_email = new System.Windows.Forms.TableLayoutPanel();
            this.contactNumPictureBox = new custom.RoundedPictureBox();
            this.addressPictureBox = new custom.RoundedPictureBox();
            this.PANEL_role = new RoundedCorners.RoundedPanel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.editInfoButton = new roundedCorners.roundedButton();
            this.backButton = new roundedCorners.roundedButton();
            this.changeStatusButton = new roundedCorners.roundedButton();
            this.userPictureBox = new custom.RoundedPictureBox();
            this.emailPictureBox = new custom.RoundedPictureBox();
            this.PANEL_contactNumber.SuspendLayout();
            this.PANEL_address.SuspendLayout();
            this.LAYOUT_userinfo.SuspendLayout();
            this.PANEL_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).BeginInit();
            this.PANEL_email.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactNumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPictureBox)).BeginInit();
            this.PANEL_role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoEllipsis = true;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.emailLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.Location = new System.Drawing.Point(33, 2);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(629, 38);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.UseMnemonic = false;
            // 
            // contactNumLabel
            // 
            this.contactNumLabel.AutoSize = true;
            this.contactNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactNumLabel.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.contactNumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactNumLabel.Location = new System.Drawing.Point(33, 2);
            this.contactNumLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.contactNumLabel.Name = "contactNumLabel";
            this.contactNumLabel.Size = new System.Drawing.Size(629, 38);
            this.contactNumLabel.TabIndex = 2;
            this.contactNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactNumLabel.UseMnemonic = false;
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
            this.PANEL_contactNumber.Location = new System.Drawing.Point(15, 171);
            this.PANEL_contactNumber.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_contactNumber.Name = "PANEL_contactNumber";
            this.PANEL_contactNumber.RowCount = 1;
            this.PANEL_contactNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_contactNumber.Size = new System.Drawing.Size(662, 42);
            this.PANEL_contactNumber.TabIndex = 13;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoEllipsis = true;
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressLabel.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.addressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressLabel.Location = new System.Drawing.Point(33, 2);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(629, 38);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressLabel.UseMnemonic = false;
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
            this.PANEL_address.Location = new System.Drawing.Point(15, 213);
            this.PANEL_address.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_address.Name = "PANEL_address";
            this.PANEL_address.RowCount = 1;
            this.PANEL_address.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_address.Size = new System.Drawing.Size(662, 42);
            this.PANEL_address.TabIndex = 14;
            // 
            // LAYOUT_userinfo
            // 
            this.LAYOUT_userinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LAYOUT_userinfo.ColumnCount = 5;
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.13799F));
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.62067F));
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.62067F));
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_userinfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.62067F));
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_address, 0, 4);
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_contactNumber, 0, 3);
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_name, 0, 1);
            this.LAYOUT_userinfo.Controls.Add(this.editInfoButton, 2, 9);
            this.LAYOUT_userinfo.Controls.Add(this.userIDLabel, 0, 0);
            this.LAYOUT_userinfo.Controls.Add(this.backButton, 0, 9);
            this.LAYOUT_userinfo.Controls.Add(this.changeStatusButton, 4, 9);
            this.LAYOUT_userinfo.Controls.Add(this.bookListDataGridView, 0, 6);
            this.LAYOUT_userinfo.Controls.Add(this.userPictureBox, 4, 0);
            this.LAYOUT_userinfo.Controls.Add(this.PANEL_email, 0, 2);
            this.LAYOUT_userinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_userinfo.Location = new System.Drawing.Point(3, 2);
            this.LAYOUT_userinfo.Margin = new System.Windows.Forms.Padding(5);
            this.LAYOUT_userinfo.Name = "LAYOUT_userinfo";
            this.LAYOUT_userinfo.Padding = new System.Windows.Forms.Padding(15);
            this.LAYOUT_userinfo.RowCount = 10;
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_userinfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LAYOUT_userinfo.Size = new System.Drawing.Size(954, 666);
            this.LAYOUT_userinfo.TabIndex = 9;
            // 
            // PANEL_name
            // 
            this.LAYOUT_userinfo.SetColumnSpan(this.PANEL_name, 3);
            this.PANEL_name.Controls.Add(this.lastNameLabel);
            this.PANEL_name.Controls.Add(this.firstNameLabel);
            this.PANEL_name.Controls.Add(this.middleNameLabel);
            this.PANEL_name.Controls.Add(this.PANEL_role);
            this.PANEL_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_name.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.PANEL_name.Location = new System.Drawing.Point(20, 87);
            this.PANEL_name.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.PANEL_name.Name = "PANEL_name";
            this.PANEL_name.Size = new System.Drawing.Size(657, 42);
            this.PANEL_name.TabIndex = 9;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Montserrat Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lastNameLabel.Location = new System.Drawing.Point(0, 10);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(153, 32);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name,";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Montserrat Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.firstNameLabel.Location = new System.Drawing.Point(153, 8);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(149, 32);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Montserrat Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.middleNameLabel.Location = new System.Drawing.Point(302, 8);
            this.middleNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(58, 32);
            this.middleNameLabel.TabIndex = 2;
            this.middleNameLabel.Text = "M.I.";
            this.middleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoEllipsis = true;
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.LAYOUT_userinfo.SetColumnSpan(this.userIDLabel, 2);
            this.userIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userIDLabel.Font = new System.Drawing.Font("Montserrat Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.userIDLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.userIDLabel.Location = new System.Drawing.Point(15, 15);
            this.userIDLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(422, 72);
            this.userIDLabel.TabIndex = 3;
            this.userIDLabel.Text = "E00000000";
            this.userIDLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // bookListDataGridView
            // 
            this.bookListDataGridView.AllowUserToAddRows = false;
            this.bookListDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookListDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookListDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bookListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookTitleColumnHeader,
            this.dateBorrowedColumnHeader,
            this.returnDateColumnHeader,
            this.dateReturnedColumnHeader,
            this.returnStatusColumnHeader});
            this.LAYOUT_userinfo.SetColumnSpan(this.bookListDataGridView, 5);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookListDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.bookListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bookListDataGridView.EnableHeadersVisualStyles = false;
            this.bookListDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.bookListDataGridView.Location = new System.Drawing.Point(15, 265);
            this.bookListDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.bookListDataGridView.MultiSelect = false;
            this.bookListDataGridView.Name = "bookListDataGridView";
            this.bookListDataGridView.ReadOnly = true;
            this.bookListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookListDataGridView.RowHeadersVisible = false;
            this.bookListDataGridView.RowHeadersWidth = 51;
            this.LAYOUT_userinfo.SetRowSpan(this.bookListDataGridView, 2);
            this.bookListDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.bookListDataGridView.RowTemplate.Height = 24;
            this.bookListDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookListDataGridView.ShowCellToolTips = false;
            this.bookListDataGridView.ShowEditingIcon = false;
            this.bookListDataGridView.Size = new System.Drawing.Size(924, 302);
            this.bookListDataGridView.TabIndex = 7;
            this.bookListDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.bookListDataGridView_RowsAdded);
            // 
            // bookTitleColumnHeader
            // 
            this.bookTitleColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookTitleColumnHeader.DefaultCellStyle = dataGridViewCellStyle3;
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
            // PANEL_email
            // 
            this.PANEL_email.ColumnCount = 2;
            this.LAYOUT_userinfo.SetColumnSpan(this.PANEL_email, 3);
            this.PANEL_email.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PANEL_email.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.PANEL_email.Controls.Add(this.emailLabel, 1, 0);
            this.PANEL_email.Controls.Add(this.emailPictureBox, 0, 0);
            this.PANEL_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_email.Location = new System.Drawing.Point(15, 129);
            this.PANEL_email.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_email.Name = "PANEL_email";
            this.PANEL_email.RowCount = 1;
            this.PANEL_email.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_email.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.PANEL_email.Size = new System.Drawing.Size(662, 42);
            this.PANEL_email.TabIndex = 12;
            // 
            // contactNumPictureBox
            // 
            this.contactNumPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.contactNumPictureBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.contactNumPictureBox.BorderRadius = 3;
            this.contactNumPictureBox.BorderSize = 1;
            this.contactNumPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactNumPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("contactNumPictureBox.Image")));
            this.contactNumPictureBox.Location = new System.Drawing.Point(5, 10);
            this.contactNumPictureBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.contactNumPictureBox.Name = "contactNumPictureBox";
            this.contactNumPictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.contactNumPictureBox.Size = new System.Drawing.Size(23, 22);
            this.contactNumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contactNumPictureBox.TabIndex = 1;
            this.contactNumPictureBox.TabStop = false;
            // 
            // addressPictureBox
            // 
            this.addressPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.addressPictureBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.addressPictureBox.BorderRadius = 3;
            this.addressPictureBox.BorderSize = 1;
            this.addressPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addressPictureBox.Image")));
            this.addressPictureBox.Location = new System.Drawing.Point(5, 10);
            this.addressPictureBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.addressPictureBox.Name = "addressPictureBox";
            this.addressPictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.addressPictureBox.Size = new System.Drawing.Size(23, 22);
            this.addressPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addressPictureBox.TabIndex = 1;
            this.addressPictureBox.TabStop = false;
            // 
            // PANEL_role
            // 
            this.PANEL_role.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.PANEL_role.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.PANEL_role.BorderWidth = 1F;
            this.PANEL_role.Controls.Add(this.roleLabel);
            this.PANEL_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_role.Location = new System.Drawing.Point(360, 16);
            this.PANEL_role.Margin = new System.Windows.Forms.Padding(0);
            this.PANEL_role.MaximumSize = new System.Drawing.Size(200, 26);
            this.PANEL_role.MinimumSize = new System.Drawing.Size(0, 26);
            this.PANEL_role.Name = "PANEL_role";
            this.PANEL_role.Radius = 10;
            this.PANEL_role.Size = new System.Drawing.Size(118, 26);
            this.PANEL_role.TabIndex = 7;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleLabel.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.roleLabel.Location = new System.Drawing.Point(0, 0);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Padding = new System.Windows.Forms.Padding(15, 2, 15, 5);
            this.roleLabel.Size = new System.Drawing.Size(115, 25);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "EMPLOYEE";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roleLabel.UseMnemonic = false;
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
            this.editInfoButton.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInfoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.editInfoButton.Location = new System.Drawing.Point(440, 589);
            this.editInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editInfoButton.Name = "editInfoButton";
            this.editInfoButton.Size = new System.Drawing.Size(234, 60);
            this.editInfoButton.TabIndex = 0;
            this.editInfoButton.Text = "Edit Info";
            this.editInfoButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
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
            this.backButton.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.backButton.Location = new System.Drawing.Point(18, 589);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(176, 60);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.changeStatusButton.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.changeStatusButton.Location = new System.Drawing.Point(700, 589);
            this.changeStatusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(236, 54);
            this.changeStatusButton.TabIndex = 6;
            this.changeStatusButton.Text = "DEACTIVATE";
            this.changeStatusButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.changeStatusButton.UseVisualStyleBackColor = false;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.userPictureBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.userPictureBox.BorderRadius = 1;
            this.userPictureBox.BorderSize = 1;
            this.userPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPictureBox.Image = global::Archivary.Properties.Resources.PLACEHOLDER_PICTURE;
            this.userPictureBox.Location = new System.Drawing.Point(700, 17);
            this.userPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.LAYOUT_userinfo.SetRowSpan(this.userPictureBox, 5);
            this.userPictureBox.Size = new System.Drawing.Size(236, 236);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 10;
            this.userPictureBox.TabStop = false;
            // 
            // emailPictureBox
            // 
            this.emailPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.emailPictureBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.emailPictureBox.BorderRadius = 3;
            this.emailPictureBox.BorderSize = 1;
            this.emailPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("emailPictureBox.Image")));
            this.emailPictureBox.Location = new System.Drawing.Point(5, 10);
            this.emailPictureBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.emailPictureBox.Name = "emailPictureBox";
            this.emailPictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.emailPictureBox.Size = new System.Drawing.Size(23, 22);
            this.emailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailPictureBox.TabIndex = 0;
            this.emailPictureBox.TabStop = false;
            // 
            // FORM_INFOEMPLOYEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.Controls.Add(this.LAYOUT_userinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FORM_INFOEMPLOYEE";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_INFOEMPLOYEE";
            this.Load += new System.EventHandler(this.FORM_INFOEMPLOYEE_Load);
            this.PANEL_contactNumber.ResumeLayout(false);
            this.PANEL_contactNumber.PerformLayout();
            this.PANEL_address.ResumeLayout(false);
            this.PANEL_address.PerformLayout();
            this.LAYOUT_userinfo.ResumeLayout(false);
            this.LAYOUT_userinfo.PerformLayout();
            this.PANEL_name.ResumeLayout(false);
            this.PANEL_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).EndInit();
            this.PANEL_email.ResumeLayout(false);
            this.PANEL_email.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactNumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPictureBox)).EndInit();
            this.PANEL_role.ResumeLayout(false);
            this.PANEL_role.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label contactNumLabel;
        private System.Windows.Forms.TableLayoutPanel PANEL_contactNumber;
        private System.Windows.Forms.TableLayoutPanel LAYOUT_userinfo;
        private System.Windows.Forms.TableLayoutPanel PANEL_address;
        private System.Windows.Forms.Label addressLabel;
        private custom.RoundedPictureBox addressPictureBox;
        private System.Windows.Forms.FlowLayoutPanel PANEL_name;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private roundedCorners.roundedButton editInfoButton;
        private System.Windows.Forms.Label userIDLabel;
        private roundedCorners.roundedButton backButton;
        private roundedCorners.roundedButton changeStatusButton;
        private System.Windows.Forms.DataGridView bookListDataGridView;
        private custom.RoundedPictureBox userPictureBox;
        private RoundedCorners.RoundedPanel PANEL_role;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TableLayoutPanel PANEL_email;
        private custom.RoundedPictureBox emailPictureBox;
        private custom.RoundedPictureBox contactNumPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBorrowedColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnedColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnStatusColumnHeader;
    }
}
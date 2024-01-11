namespace Archivary.Archivary_Components
{
    partial class booksReserved
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LAYOUT_RESERVELIST = new System.Windows.Forms.TableLayoutPanel();
            this.bookReserveLabel = new System.Windows.Forms.Label();
            this.PANEL_booksReservedContainer = new RoundedCorners.RoundedPanel();
            this.reserveDataGridView = new System.Windows.Forms.DataGridView();
            this.userIDReserveColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNReserveColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleReserveColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorReserveColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReserveColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDueReserveColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusReserveColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAYOUT_RESERVELIST.SuspendLayout();
            this.PANEL_booksReservedContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LAYOUT_RESERVELIST
            // 
            this.LAYOUT_RESERVELIST.ColumnCount = 1;
            this.LAYOUT_RESERVELIST.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_RESERVELIST.Controls.Add(this.bookReserveLabel, 0, 0);
            this.LAYOUT_RESERVELIST.Controls.Add(this.PANEL_booksReservedContainer, 0, 1);
            this.LAYOUT_RESERVELIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_RESERVELIST.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_RESERVELIST.Name = "LAYOUT_RESERVELIST";
            this.LAYOUT_RESERVELIST.RowCount = 2;
            this.LAYOUT_RESERVELIST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LAYOUT_RESERVELIST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.LAYOUT_RESERVELIST.Size = new System.Drawing.Size(670, 490);
            this.LAYOUT_RESERVELIST.TabIndex = 0;
            // 
            // bookReserveLabel
            // 
            this.bookReserveLabel.AutoSize = true;
            this.bookReserveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookReserveLabel.Font = new System.Drawing.Font("Montserrat Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookReserveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.bookReserveLabel.Location = new System.Drawing.Point(0, 0);
            this.bookReserveLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bookReserveLabel.MaximumSize = new System.Drawing.Size(0, 52);
            this.bookReserveLabel.MinimumSize = new System.Drawing.Size(0, 52);
            this.bookReserveLabel.Name = "bookReserveLabel";
            this.bookReserveLabel.Size = new System.Drawing.Size(670, 52);
            this.bookReserveLabel.TabIndex = 7;
            this.bookReserveLabel.Text = "Books Reserved";
            this.bookReserveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PANEL_booksReservedContainer
            // 
            this.PANEL_booksReservedContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_booksReservedContainer.BackgroundColor = System.Drawing.Color.Transparent;
            this.PANEL_booksReservedContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.PANEL_booksReservedContainer.BorderWidth = 3F;
            this.PANEL_booksReservedContainer.Controls.Add(this.reserveDataGridView);
            this.PANEL_booksReservedContainer.Location = new System.Drawing.Point(3, 54);
            this.PANEL_booksReservedContainer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PANEL_booksReservedContainer.Name = "PANEL_booksReservedContainer";
            this.PANEL_booksReservedContainer.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.PANEL_booksReservedContainer.Radius = 10;
            this.PANEL_booksReservedContainer.Size = new System.Drawing.Size(664, 431);
            this.PANEL_booksReservedContainer.TabIndex = 8;
            // 
            // reserveDataGridView
            // 
            this.reserveDataGridView.AllowUserToAddRows = false;
            this.reserveDataGridView.AllowUserToDeleteRows = false;
            this.reserveDataGridView.AllowUserToResizeColumns = false;
            this.reserveDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reserveDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.reserveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reserveDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reserveDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.reserveDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reserveDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reserveDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.reserveDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reserveDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.reserveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDReserveColumnHeader,
            this.ISBNReserveColumnHeader,
            this.titleReserveColumnHeader,
            this.authorReserveColumnHeader,
            this.dateReserveColumnHeader,
            this.dateDueReserveColumnHeader,
            this.statusReserveColumnHeader});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reserveDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.reserveDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reserveDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.reserveDataGridView.EnableHeadersVisualStyles = false;
            this.reserveDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.reserveDataGridView.Location = new System.Drawing.Point(5, 10);
            this.reserveDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.reserveDataGridView.MultiSelect = false;
            this.reserveDataGridView.Name = "reserveDataGridView";
            this.reserveDataGridView.ReadOnly = true;
            this.reserveDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reserveDataGridView.RowHeadersVisible = false;
            this.reserveDataGridView.RowHeadersWidth = 51;
            this.reserveDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reserveDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.reserveDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.reserveDataGridView.RowTemplate.Height = 24;
            this.reserveDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reserveDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reserveDataGridView.Size = new System.Drawing.Size(649, 416);
            this.reserveDataGridView.TabIndex = 4;
            this.reserveDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.reserveDataGridView_CellFormatting);
            this.reserveDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.reserveDataGridView_RowsAdded);
            // 
            // userIDReserveColumnHeader
            // 
            this.userIDReserveColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIDReserveColumnHeader.HeaderText = "USER ID";
            this.userIDReserveColumnHeader.MinimumWidth = 6;
            this.userIDReserveColumnHeader.Name = "userIDReserveColumnHeader";
            this.userIDReserveColumnHeader.ReadOnly = true;
            this.userIDReserveColumnHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ISBNReserveColumnHeader
            // 
            this.ISBNReserveColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ISBNReserveColumnHeader.HeaderText = "BOOK ISBN";
            this.ISBNReserveColumnHeader.MinimumWidth = 6;
            this.ISBNReserveColumnHeader.Name = "ISBNReserveColumnHeader";
            this.ISBNReserveColumnHeader.ReadOnly = true;
            // 
            // titleReserveColumnHeader
            // 
            this.titleReserveColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleReserveColumnHeader.HeaderText = "BOOK TITLE";
            this.titleReserveColumnHeader.MinimumWidth = 6;
            this.titleReserveColumnHeader.Name = "titleReserveColumnHeader";
            this.titleReserveColumnHeader.ReadOnly = true;
            // 
            // authorReserveColumnHeader
            // 
            this.authorReserveColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorReserveColumnHeader.HeaderText = "AUTHOR";
            this.authorReserveColumnHeader.MinimumWidth = 6;
            this.authorReserveColumnHeader.Name = "authorReserveColumnHeader";
            this.authorReserveColumnHeader.ReadOnly = true;
            // 
            // dateReserveColumnHeader
            // 
            this.dateReserveColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateReserveColumnHeader.HeaderText = "DATE RESERVED";
            this.dateReserveColumnHeader.MinimumWidth = 6;
            this.dateReserveColumnHeader.Name = "dateReserveColumnHeader";
            this.dateReserveColumnHeader.ReadOnly = true;
            // 
            // dateDueReserveColumnHeader
            // 
            this.dateDueReserveColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDueReserveColumnHeader.HeaderText = "DATE DUE";
            this.dateDueReserveColumnHeader.MinimumWidth = 6;
            this.dateDueReserveColumnHeader.Name = "dateDueReserveColumnHeader";
            this.dateDueReserveColumnHeader.ReadOnly = true;
            // 
            // statusReserveColumnHeader
            // 
            this.statusReserveColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusReserveColumnHeader.HeaderText = "STATUS";
            this.statusReserveColumnHeader.MinimumWidth = 6;
            this.statusReserveColumnHeader.Name = "statusReserveColumnHeader";
            this.statusReserveColumnHeader.ReadOnly = true;
            // 
            // booksReserved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LAYOUT_RESERVELIST);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(650, 490);
            this.Name = "booksReserved";
            this.Size = new System.Drawing.Size(670, 490);
            this.LAYOUT_RESERVELIST.ResumeLayout(false);
            this.LAYOUT_RESERVELIST.PerformLayout();
            this.PANEL_booksReservedContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reserveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LAYOUT_RESERVELIST;
        private System.Windows.Forms.Label bookReserveLabel;
        private RoundedCorners.RoundedPanel PANEL_booksReservedContainer;
        private System.Windows.Forms.DataGridView reserveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDReserveColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNReserveColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleReserveColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorReserveColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReserveColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDueReserveColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusReserveColumnHeader;
    }
}

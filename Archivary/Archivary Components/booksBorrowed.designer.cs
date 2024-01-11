namespace Archivary.Archivary_Components
{
    partial class booksBorrowed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LAYOUT_BORROWLIST = new System.Windows.Forms.TableLayoutPanel();
            this.bookBorrowLabel = new System.Windows.Forms.Label();
            this.PANEL_booksBorrowedContainer = new RoundedCorners.RoundedPanel();
            this.borrowDataGridView = new System.Windows.Forms.DataGridView();
            this.userIDBorrowColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNBorrowColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleBorrowColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBorrowColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBorrowColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDueBorrowColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBorrowColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAYOUT_BORROWLIST.SuspendLayout();
            this.PANEL_booksBorrowedContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LAYOUT_BORROWLIST
            // 
            this.LAYOUT_BORROWLIST.ColumnCount = 1;
            this.LAYOUT_BORROWLIST.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_BORROWLIST.Controls.Add(this.bookBorrowLabel, 0, 0);
            this.LAYOUT_BORROWLIST.Controls.Add(this.PANEL_booksBorrowedContainer, 0, 1);
            this.LAYOUT_BORROWLIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_BORROWLIST.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_BORROWLIST.Name = "LAYOUT_BORROWLIST";
            this.LAYOUT_BORROWLIST.RowCount = 2;
            this.LAYOUT_BORROWLIST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LAYOUT_BORROWLIST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.LAYOUT_BORROWLIST.Size = new System.Drawing.Size(986, 521);
            this.LAYOUT_BORROWLIST.TabIndex = 0;
            // 
            // bookBorrowLabel
            // 
            this.bookBorrowLabel.AutoSize = true;
            this.bookBorrowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookBorrowLabel.Font = new System.Drawing.Font("Montserrat Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBorrowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.bookBorrowLabel.Location = new System.Drawing.Point(0, 0);
            this.bookBorrowLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bookBorrowLabel.Name = "bookBorrowLabel";
            this.bookBorrowLabel.Size = new System.Drawing.Size(986, 52);
            this.bookBorrowLabel.TabIndex = 7;
            this.bookBorrowLabel.Text = "Books Borrowed";
            this.bookBorrowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PANEL_booksBorrowedContainer
            // 
            this.PANEL_booksBorrowedContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_booksBorrowedContainer.AutoScroll = true;
            this.PANEL_booksBorrowedContainer.BackgroundColor = System.Drawing.Color.Transparent;
            this.PANEL_booksBorrowedContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.PANEL_booksBorrowedContainer.BorderWidth = 3F;
            this.PANEL_booksBorrowedContainer.Controls.Add(this.borrowDataGridView);
            this.PANEL_booksBorrowedContainer.Location = new System.Drawing.Point(3, 57);
            this.PANEL_booksBorrowedContainer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PANEL_booksBorrowedContainer.Name = "PANEL_booksBorrowedContainer";
            this.PANEL_booksBorrowedContainer.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.PANEL_booksBorrowedContainer.Radius = 10;
            this.PANEL_booksBorrowedContainer.Size = new System.Drawing.Size(980, 459);
            this.PANEL_booksBorrowedContainer.TabIndex = 8;
            // 
            // borrowDataGridView
            // 
            this.borrowDataGridView.AllowUserToAddRows = false;
            this.borrowDataGridView.AllowUserToDeleteRows = false;
            this.borrowDataGridView.AllowUserToResizeColumns = false;
            this.borrowDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.borrowDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.borrowDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.borrowDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.borrowDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.borrowDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.borrowDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.borrowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDBorrowColumnHeader,
            this.ISBNBorrowColumnHeader,
            this.titleBorrowColumnHeader,
            this.authorBorrowColumnHeader,
            this.dateBorrowColumnHeader,
            this.dateDueBorrowColumnHeader,
            this.statusBorrowColumnHeader});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.borrowDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.borrowDataGridView.EnableHeadersVisualStyles = false;
            this.borrowDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.borrowDataGridView.Location = new System.Drawing.Point(5, 10);
            this.borrowDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.borrowDataGridView.MultiSelect = false;
            this.borrowDataGridView.Name = "borrowDataGridView";
            this.borrowDataGridView.ReadOnly = true;
            this.borrowDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.borrowDataGridView.RowHeadersVisible = false;
            this.borrowDataGridView.RowHeadersWidth = 51;
            this.borrowDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.borrowDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.borrowDataGridView.RowTemplate.Height = 24;
            this.borrowDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.borrowDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowDataGridView.Size = new System.Drawing.Size(965, 444);
            this.borrowDataGridView.TabIndex = 4;
            this.borrowDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.borrowDataGridView_CellFormatting);
            this.borrowDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.borrowDataGridView_RowsAdded);
            // 
            // userIDBorrowColumnHeader
            // 
            this.userIDBorrowColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIDBorrowColumnHeader.HeaderText = "USER ID";
            this.userIDBorrowColumnHeader.MinimumWidth = 6;
            this.userIDBorrowColumnHeader.Name = "userIDBorrowColumnHeader";
            this.userIDBorrowColumnHeader.ReadOnly = true;
            this.userIDBorrowColumnHeader.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ISBNBorrowColumnHeader
            // 
            this.ISBNBorrowColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ISBNBorrowColumnHeader.HeaderText = "BOOK ISBN";
            this.ISBNBorrowColumnHeader.MinimumWidth = 6;
            this.ISBNBorrowColumnHeader.Name = "ISBNBorrowColumnHeader";
            this.ISBNBorrowColumnHeader.ReadOnly = true;
            // 
            // titleBorrowColumnHeader
            // 
            this.titleBorrowColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleBorrowColumnHeader.HeaderText = "BOOK TITLE";
            this.titleBorrowColumnHeader.MinimumWidth = 6;
            this.titleBorrowColumnHeader.Name = "titleBorrowColumnHeader";
            this.titleBorrowColumnHeader.ReadOnly = true;
            // 
            // authorBorrowColumnHeader
            // 
            this.authorBorrowColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorBorrowColumnHeader.HeaderText = "AUTHOR";
            this.authorBorrowColumnHeader.MinimumWidth = 6;
            this.authorBorrowColumnHeader.Name = "authorBorrowColumnHeader";
            this.authorBorrowColumnHeader.ReadOnly = true;
            // 
            // dateBorrowColumnHeader
            // 
            this.dateBorrowColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateBorrowColumnHeader.HeaderText = "DATE BORROWED";
            this.dateBorrowColumnHeader.MinimumWidth = 6;
            this.dateBorrowColumnHeader.Name = "dateBorrowColumnHeader";
            this.dateBorrowColumnHeader.ReadOnly = true;
            // 
            // dateDueBorrowColumnHeader
            // 
            this.dateDueBorrowColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDueBorrowColumnHeader.HeaderText = "DATE DUE";
            this.dateDueBorrowColumnHeader.MinimumWidth = 6;
            this.dateDueBorrowColumnHeader.Name = "dateDueBorrowColumnHeader";
            this.dateDueBorrowColumnHeader.ReadOnly = true;
            // 
            // statusBorrowColumnHeader
            // 
            this.statusBorrowColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusBorrowColumnHeader.HeaderText = "STATUS";
            this.statusBorrowColumnHeader.MinimumWidth = 6;
            this.statusBorrowColumnHeader.Name = "statusBorrowColumnHeader";
            this.statusBorrowColumnHeader.ReadOnly = true;
            // 
            // booksBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LAYOUT_BORROWLIST);
            this.Name = "booksBorrowed";
            this.Size = new System.Drawing.Size(986, 521);
            this.LAYOUT_BORROWLIST.ResumeLayout(false);
            this.LAYOUT_BORROWLIST.PerformLayout();
            this.PANEL_booksBorrowedContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LAYOUT_BORROWLIST;
        private System.Windows.Forms.Label bookBorrowLabel;
        private RoundedCorners.RoundedPanel PANEL_booksBorrowedContainer;
        private System.Windows.Forms.DataGridView borrowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDBorrowColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNBorrowColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleBorrowColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorBorrowColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBorrowColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDueBorrowColumnHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusBorrowColumnHeader;
    }
}

using System.Windows.Forms;

namespace Archivary._1500X1000.FORM_CIRCULATION
{
    partial class FORM_POS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.totalPanel = new System.Windows.Forms.TableLayoutPanel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.paymentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.changePanel = new System.Windows.Forms.TableLayoutPanel();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new roundedCorners.roundedButton();
            this.calculateButton = new roundedCorners.roundedButton();
            this.payButton = new roundedCorners.roundedButton();
            this.Layout1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.totalPanel.SuspendLayout();
            this.paymentPanel.SuspendLayout();
            this.changePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Layout1
            // 
            this.Layout1.ColumnCount = 3;
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Layout1.Controls.Add(this.buttonPanel, 1, 9);
            this.Layout1.Controls.Add(this.totalPanel, 1, 3);
            this.Layout1.Controls.Add(this.paymentPanel, 1, 5);
            this.Layout1.Controls.Add(this.changePanel, 1, 7);
            this.Layout1.Controls.Add(this.bookDataGridView, 1, 1);
            this.Layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Layout1.Location = new System.Drawing.Point(8, 8);
            this.Layout1.Margin = new System.Windows.Forms.Padding(2);
            this.Layout1.Name = "Layout1";
            this.Layout1.RowCount = 11;
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Layout1.Size = new System.Drawing.Size(752, 520);
            this.Layout1.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 5;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.Controls.Add(this.backButton, 0, 0);
            this.buttonPanel.Controls.Add(this.calculateButton, 2, 0);
            this.buttonPanel.Controls.Add(this.payButton, 4, 0);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(16, 449);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel.Size = new System.Drawing.Size(720, 51);
            this.buttonPanel.TabIndex = 0;
            // 
            // totalPanel
            // 
            this.totalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.totalPanel.ColumnCount = 2;
            this.totalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.totalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.totalPanel.Controls.Add(this.totalLabel, 0, 0);
            this.totalPanel.Controls.Add(this.totalTextBox, 1, 0);
            this.totalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPanel.Location = new System.Drawing.Point(16, 264);
            this.totalPanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Padding = new System.Windows.Forms.Padding(4, 4, 12, 4);
            this.totalPanel.RowCount = 1;
            this.totalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalPanel.Size = new System.Drawing.Size(720, 51);
            this.totalPanel.TabIndex = 2;
            this.totalPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.totalPanel_Paint);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.totalLabel.Location = new System.Drawing.Point(4, 4);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(211, 43);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.totalTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.totalTextBox.Location = new System.Drawing.Point(218, 15);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(488, 20);
            this.totalTextBox.TabIndex = 1;
            this.totalTextBox.Text = "0.00";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalTextBox.WordWrap = false;
            // 
            // paymentPanel
            // 
            this.paymentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paymentPanel.ColumnCount = 2;
            this.paymentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.paymentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.paymentPanel.Controls.Add(this.paymentTextBox, 0, 0);
            this.paymentPanel.Controls.Add(this.paymentLabel, 0, 0);
            this.paymentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentPanel.Location = new System.Drawing.Point(16, 323);
            this.paymentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Padding = new System.Windows.Forms.Padding(4, 4, 12, 4);
            this.paymentPanel.RowCount = 1;
            this.paymentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paymentPanel.Size = new System.Drawing.Size(720, 51);
            this.paymentPanel.TabIndex = 3;
            this.paymentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paymentPanel_Paint);
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.paymentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.paymentTextBox.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.paymentTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.paymentTextBox.Location = new System.Drawing.Point(218, 15);
            this.paymentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(488, 20);
            this.paymentTextBox.TabIndex = 2;
            this.paymentTextBox.Text = "0.00";
            this.paymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.paymentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.paymentLabel.Location = new System.Drawing.Point(4, 4);
            this.paymentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(211, 43);
            this.paymentLabel.TabIndex = 1;
            this.paymentLabel.Text = "Payment";
            this.paymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changePanel
            // 
            this.changePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.changePanel.ColumnCount = 2;
            this.changePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.changePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.changePanel.Controls.Add(this.changeTextBox, 1, 0);
            this.changePanel.Controls.Add(this.changeLabel, 0, 0);
            this.changePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePanel.Location = new System.Drawing.Point(16, 382);
            this.changePanel.Margin = new System.Windows.Forms.Padding(0);
            this.changePanel.Name = "changePanel";
            this.changePanel.Padding = new System.Windows.Forms.Padding(4, 4, 12, 4);
            this.changePanel.RowCount = 1;
            this.changePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.changePanel.Size = new System.Drawing.Size(720, 51);
            this.changePanel.TabIndex = 4;
            this.changePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.changePanel_Paint);
            // 
            // changeTextBox
            // 
            this.changeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.changeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.changeTextBox.Enabled = false;
            this.changeTextBox.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.changeTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.changeTextBox.Location = new System.Drawing.Point(217, 15);
            this.changeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.ReadOnly = true;
            this.changeTextBox.Size = new System.Drawing.Size(489, 20);
            this.changeTextBox.TabIndex = 2;
            this.changeTextBox.Text = "0.00";
            this.changeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.changeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.changeLabel.Location = new System.Drawing.Point(4, 4);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(211, 43);
            this.changeLabel.TabIndex = 1;
            this.changeLabel.Text = "Change";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.bookDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bookDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.ISBNColumnHeader,
            this.DateBorrowed,
            this.dateReturnedColumnHeader,
            this.penaltyColumnHeader});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.bookDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.bookDataGridView.Location = new System.Drawing.Point(18, 18);
            this.bookDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.bookDataGridView.MultiSelect = false;
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookDataGridView.RowHeadersVisible = false;
            this.bookDataGridView.RowHeadersWidth = 51;
            this.bookDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookDataGridView.RowTemplate.Height = 24;
            this.bookDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookDataGridView.Size = new System.Drawing.Size(716, 228);
            this.bookDataGridView.TabIndex = 5;
            // 
            // title
            // 
            this.title.HeaderText = "TITLE";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // ISBNColumnHeader
            // 
            this.ISBNColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ISBNColumnHeader.HeaderText = "ISBN";
            this.ISBNColumnHeader.MinimumWidth = 125;
            this.ISBNColumnHeader.Name = "ISBNColumnHeader";
            this.ISBNColumnHeader.ReadOnly = true;
            this.ISBNColumnHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ISBNColumnHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DateBorrowed
            // 
            this.DateBorrowed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateBorrowed.HeaderText = "DATE BORROWED";
            this.DateBorrowed.MinimumWidth = 200;
            this.DateBorrowed.Name = "DateBorrowed";
            this.DateBorrowed.ReadOnly = true;
            // 
            // dateReturnedColumnHeader
            // 
            this.dateReturnedColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dateReturnedColumnHeader.HeaderText = "DATE RETURNED";
            this.dateReturnedColumnHeader.MinimumWidth = 125;
            this.dateReturnedColumnHeader.Name = "dateReturnedColumnHeader";
            this.dateReturnedColumnHeader.ReadOnly = true;
            this.dateReturnedColumnHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateReturnedColumnHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dateReturnedColumnHeader.Width = 160;
            // 
            // penaltyColumnHeader
            // 
            this.penaltyColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.penaltyColumnHeader.HeaderText = "PENALTY";
            this.penaltyColumnHeader.MinimumWidth = 125;
            this.penaltyColumnHeader.Name = "penaltyColumnHeader";
            this.penaltyColumnHeader.ReadOnly = true;
            this.penaltyColumnHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.penaltyColumnHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.backButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.backButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.backButton.BorderRadius = 10;
            this.backButton.BorderSize = 0;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(229, 51);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.calculateButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.calculateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.calculateButton.BorderRadius = 10;
            this.calculateButton.BorderSize = 0;
            this.calculateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.calculateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.calculateButton.Location = new System.Drawing.Point(245, 0);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(0);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(229, 51);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.payButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.payButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.payButton.BorderRadius = 10;
            this.payButton.BorderSize = 0;
            this.payButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payButton.FlatAppearance.BorderSize = 0;
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.payButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.payButton.Location = new System.Drawing.Point(490, 0);
            this.payButton.Margin = new System.Windows.Forms.Padding(0);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(230, 51);
            this.payButton.TabIndex = 3;
            this.payButton.Text = "Pay";
            this.payButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // FORM_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(768, 536);
            this.Controls.Add(this.Layout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FORM_POS";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_POS";
            this.Load += new System.EventHandler(this.FORM_POS_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FORM_POS_Paint);
            this.Layout1.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.totalPanel.ResumeLayout(false);
            this.totalPanel.PerformLayout();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            this.changePanel.ResumeLayout(false);
            this.changePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout1;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.TableLayoutPanel totalPanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TableLayoutPanel paymentPanel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.TableLayoutPanel changePanel;
        private System.Windows.Forms.Label changeLabel;
        private roundedCorners.roundedButton backButton;
        private roundedCorners.roundedButton calculateButton;
        private roundedCorners.roundedButton payButton;
        private TextBox totalTextBox;
        private TextBox paymentTextBox;
        private TextBox changeTextBox;
        private DataGridView bookDataGridView;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn ISBNColumnHeader;
        private DataGridViewTextBoxColumn DateBorrowed;
        private DataGridViewTextBoxColumn dateReturnedColumnHeader;
        private DataGridViewTextBoxColumn penaltyColumnHeader;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.backButton = new roundedCorners.roundedButton();
            this.calculateButton = new roundedCorners.roundedButton();
            this.payButton = new roundedCorners.roundedButton();
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
            this.ISBNColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnedColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout1.Controls.Add(this.buttonPanel, 1, 9);
            this.Layout1.Controls.Add(this.totalPanel, 1, 3);
            this.Layout1.Controls.Add(this.paymentPanel, 1, 5);
            this.Layout1.Controls.Add(this.changePanel, 1, 7);
            this.Layout1.Controls.Add(this.bookDataGridView, 1, 1);
            this.Layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Layout1.Location = new System.Drawing.Point(10, 10);
            this.Layout1.Name = "Layout1";
            this.Layout1.RowCount = 11;
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Layout1.Size = new System.Drawing.Size(940, 650);
            this.Layout1.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 5;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.Controls.Add(this.backButton, 0, 0);
            this.buttonPanel.Controls.Add(this.calculateButton, 2, 0);
            this.buttonPanel.Controls.Add(this.payButton, 4, 0);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(20, 563);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel.Size = new System.Drawing.Size(900, 64);
            this.buttonPanel.TabIndex = 0;
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
            this.backButton.Size = new System.Drawing.Size(286, 64);
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
            this.calculateButton.Location = new System.Drawing.Point(306, 0);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(0);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(286, 64);
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
            this.payButton.Location = new System.Drawing.Point(612, 0);
            this.payButton.Margin = new System.Windows.Forms.Padding(0);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(288, 64);
            this.payButton.TabIndex = 3;
            this.payButton.Text = "Pay";
            this.payButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.payButton.UseVisualStyleBackColor = false;
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
            this.totalPanel.Location = new System.Drawing.Point(20, 331);
            this.totalPanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Padding = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.totalPanel.RowCount = 1;
            this.totalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totalPanel.Size = new System.Drawing.Size(900, 64);
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
            this.totalLabel.Location = new System.Drawing.Point(5, 5);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(264, 54);
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
            this.totalTextBox.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.totalTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.totalTextBox.Location = new System.Drawing.Point(272, 19);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(610, 25);
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
            this.paymentPanel.Location = new System.Drawing.Point(20, 405);
            this.paymentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Padding = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.paymentPanel.RowCount = 1;
            this.paymentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paymentPanel.Size = new System.Drawing.Size(900, 64);
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
            this.paymentTextBox.Location = new System.Drawing.Point(272, 19);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(610, 25);
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
            this.paymentLabel.Location = new System.Drawing.Point(5, 5);
            this.paymentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(264, 54);
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
            this.changePanel.Location = new System.Drawing.Point(20, 479);
            this.changePanel.Margin = new System.Windows.Forms.Padding(0);
            this.changePanel.Name = "changePanel";
            this.changePanel.Padding = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.changePanel.RowCount = 1;
            this.changePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.changePanel.Size = new System.Drawing.Size(900, 64);
            this.changePanel.TabIndex = 4;
            this.changePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.changePanel_Paint);
            // 
            // changeTextBox
            // 
            this.changeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.changeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.changeTextBox.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.changeTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.changeTextBox.Location = new System.Drawing.Point(272, 19);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.ReadOnly = true;
            this.changeTextBox.Size = new System.Drawing.Size(610, 25);
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
            this.changeLabel.Location = new System.Drawing.Point(5, 5);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(264, 54);
            this.changeLabel.TabIndex = 1;
            this.changeLabel.Text = "Change";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.AllowUserToResizeRows = false;
            this.bookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bookDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBNColumnHeader,
            this.authorColumnHeader,
            this.categoryColumnHeader,
            this.dateReturnedColumnHeader,
            this.penaltyColumnHeader});
            this.bookDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.bookDataGridView.Location = new System.Drawing.Point(23, 23);
            this.bookDataGridView.MultiSelect = false;
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookDataGridView.RowHeadersVisible = false;
            this.bookDataGridView.RowHeadersWidth = 51;
            this.bookDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookDataGridView.RowTemplate.Height = 24;
            this.bookDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookDataGridView.Size = new System.Drawing.Size(894, 285);
            this.bookDataGridView.TabIndex = 5;
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
            // authorColumnHeader
            // 
            this.authorColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorColumnHeader.HeaderText = "AUTHOR";
            this.authorColumnHeader.MinimumWidth = 125;
            this.authorColumnHeader.Name = "authorColumnHeader";
            this.authorColumnHeader.ReadOnly = true;
            this.authorColumnHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.authorColumnHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // categoryColumnHeader
            // 
            this.categoryColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryColumnHeader.HeaderText = "CATEGORY";
            this.categoryColumnHeader.MinimumWidth = 125;
            this.categoryColumnHeader.Name = "categoryColumnHeader";
            this.categoryColumnHeader.ReadOnly = true;
            this.categoryColumnHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryColumnHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.dateReturnedColumnHeader.Width = 192;
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
            // FORM_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.Controls.Add(this.Layout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FORM_POS";
            this.Padding = new System.Windows.Forms.Padding(10);
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
        private DataGridViewTextBoxColumn ISBNColumnHeader;
        private DataGridViewTextBoxColumn authorColumnHeader;
        private DataGridViewTextBoxColumn categoryColumnHeader;
        private DataGridViewTextBoxColumn dateReturnedColumnHeader;
        private DataGridViewTextBoxColumn penaltyColumnHeader;
    }
}
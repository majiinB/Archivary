using System.Windows.Forms.DataVisualization.Charting;

namespace Archivary.Archivary_Components
{
    partial class monthlyOverview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn25 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn26 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title19 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn27 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn28 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title20 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title21 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LAYOUT_OVERVIEW = new System.Windows.Forms.TableLayoutPanel();
            this.PANEL_categoryCopies = new RoundedCorners.RoundedPanel();
            this.categoryCopiesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PANEL_monthlyCopies = new RoundedCorners.RoundedPanel();
            this.monthlyCopiesTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.monthlyCopiesCountLabel = new System.Windows.Forms.Label();
            this.monthlyCopiesLabel = new System.Windows.Forms.Label();
            this.PANEL_monthlyReturned = new RoundedCorners.RoundedPanel();
            this.monthlyReturnedTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.monthlyReturnedCountLabel = new System.Windows.Forms.Label();
            this.monthlyReturnedLabel = new System.Windows.Forms.Label();
            this.PANEL_monthlyLoaned = new RoundedCorners.RoundedPanel();
            this.monthlyLoanedTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.monthlyLoanedCountLabel = new System.Windows.Forms.Label();
            this.monthlyLoanedLabel = new System.Windows.Forms.Label();
            this.PANEL_monthlyUser = new RoundedCorners.RoundedPanel();
            this.monthlyUserTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.monthlyUserCountLabel = new System.Windows.Forms.Label();
            this.monthlyUserLabel = new System.Windows.Forms.Label();
            this.PANEL_monthlyReserved = new RoundedCorners.RoundedPanel();
            this.monthlyReservedTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.monthlyReservedCountLabel = new System.Windows.Forms.Label();
            this.monthlyReservedLabel = new System.Windows.Forms.Label();
            this.PANEL_genreCopies = new RoundedCorners.RoundedPanel();
            this.genreCopiesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PANEL_monthlyComparison = new RoundedCorners.RoundedPanel();
            this.monthlyComparisonChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthlyOverviewLabel = new System.Windows.Forms.Label();
            this.LAYOUT_OVERVIEW.SuspendLayout();
            this.PANEL_categoryCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCopiesChart)).BeginInit();
            this.PANEL_monthlyCopies.SuspendLayout();
            this.monthlyCopiesTablePanel.SuspendLayout();
            this.PANEL_monthlyReturned.SuspendLayout();
            this.monthlyReturnedTablePanel.SuspendLayout();
            this.PANEL_monthlyLoaned.SuspendLayout();
            this.monthlyLoanedTablePanel.SuspendLayout();
            this.PANEL_monthlyUser.SuspendLayout();
            this.monthlyUserTablePanel.SuspendLayout();
            this.PANEL_monthlyReserved.SuspendLayout();
            this.monthlyReservedTablePanel.SuspendLayout();
            this.PANEL_genreCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreCopiesChart)).BeginInit();
            this.PANEL_monthlyComparison.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyComparisonChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LAYOUT_OVERVIEW
            // 
            this.LAYOUT_OVERVIEW.ColumnCount = 5;
            this.LAYOUT_OVERVIEW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LAYOUT_OVERVIEW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_OVERVIEW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LAYOUT_OVERVIEW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_OVERVIEW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_OVERVIEW.Controls.Add(this.PANEL_categoryCopies, 0, 12);
            this.LAYOUT_OVERVIEW.Controls.Add(this.PANEL_monthlyCopies, 0, 10);
            this.LAYOUT_OVERVIEW.Controls.Add(this.PANEL_monthlyReturned, 0, 8);
            this.LAYOUT_OVERVIEW.Controls.Add(this.PANEL_monthlyLoaned, 0, 6);
            this.LAYOUT_OVERVIEW.Controls.Add(this.PANEL_monthlyUser, 0, 2);
            this.LAYOUT_OVERVIEW.Controls.Add(this.PANEL_monthlyReserved, 0, 4);
            this.LAYOUT_OVERVIEW.Controls.Add(this.PANEL_genreCopies, 4, 12);
            this.LAYOUT_OVERVIEW.Controls.Add(this.PANEL_monthlyComparison, 2, 2);
            this.LAYOUT_OVERVIEW.Controls.Add(this.monthlyOverviewLabel, 0, 0);
            this.LAYOUT_OVERVIEW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_OVERVIEW.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_OVERVIEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LAYOUT_OVERVIEW.Name = "LAYOUT_OVERVIEW";
            this.LAYOUT_OVERVIEW.RowCount = 13;
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.954929F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34182F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34182F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34182F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34182F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34182F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_OVERVIEW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.33595F));
            this.LAYOUT_OVERVIEW.Size = new System.Drawing.Size(670, 650);
            this.LAYOUT_OVERVIEW.TabIndex = 2;
            // 
            // PANEL_categoryCopies
            // 
            this.PANEL_categoryCopies.BackgroundColor = System.Drawing.Color.Transparent;
            this.PANEL_categoryCopies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.PANEL_categoryCopies.BorderWidth = 3F;
            this.LAYOUT_OVERVIEW.SetColumnSpan(this.PANEL_categoryCopies, 3);
            this.PANEL_categoryCopies.Controls.Add(this.categoryCopiesChart);
            this.PANEL_categoryCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_categoryCopies.Location = new System.Drawing.Point(3, 437);
            this.PANEL_categoryCopies.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.PANEL_categoryCopies.Name = "PANEL_categoryCopies";
            this.PANEL_categoryCopies.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.PANEL_categoryCopies.Radius = 10;
            this.PANEL_categoryCopies.Size = new System.Drawing.Size(331, 213);
            this.PANEL_categoryCopies.TabIndex = 4;
            // 
            // categoryCopiesChart
            // 
            this.categoryCopiesChart.BackColor = System.Drawing.Color.Transparent;
            this.categoryCopiesChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.categoryCopiesChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.categoryCopiesChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.categoryCopiesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea19.BackColor = System.Drawing.Color.Transparent;
            chartArea19.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea19.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea19.BorderColor = System.Drawing.Color.Transparent;
            chartArea19.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea19.Name = "categoryChartArea";
            chartArea19.ShadowColor = System.Drawing.Color.Transparent;
            this.categoryCopiesChart.ChartAreas.Add(chartArea19);
            this.categoryCopiesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend19.Alignment = System.Drawing.StringAlignment.Far;
            legend19.AutoFitMinFontSize = 6;
            legend19.BackColor = System.Drawing.Color.Transparent;
            legendCellColumn25.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol;
            legendCellColumn25.Name = "Column3";
            legendCellColumn25.SeriesSymbolSize = new System.Drawing.Size(70, 70);
            legendCellColumn25.ToolTip = "#VAL";
            legendCellColumn26.Name = "Column2";
            legendCellColumn26.ToolTip = "#VAL";
            legend19.CellColumns.Add(legendCellColumn25);
            legend19.CellColumns.Add(legendCellColumn26);
            legend19.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            legend19.ForeColor = System.Drawing.SystemColors.Control;
            legend19.IsDockedInsideChartArea = false;
            legend19.IsEquallySpacedItems = true;
            legend19.IsTextAutoFit = false;
            legend19.ItemColumnSpacing = 10;
            legend19.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder;
            legend19.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend19.MaximumAutoSize = 40F;
            legend19.Name = "Legends";
            legend19.ShadowColor = System.Drawing.Color.Transparent;
            legend19.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend19.Title = "Legends";
            legend19.TitleBackColor = System.Drawing.Color.Transparent;
            legend19.TitleFont = new System.Drawing.Font("Montserrat ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend19.TitleForeColor = System.Drawing.SystemColors.Control;
            legend19.TitleSeparatorColor = System.Drawing.Color.Transparent;
            this.categoryCopiesChart.Legends.Add(legend19);
            this.categoryCopiesChart.Location = new System.Drawing.Point(11, 10);
            this.categoryCopiesChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryCopiesChart.Name = "categoryCopiesChart";
            this.categoryCopiesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.categoryCopiesChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(54)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))))};
            series31.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series31.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series31.BackSecondaryColor = System.Drawing.Color.Transparent;
            series31.BorderColor = System.Drawing.Color.Transparent;
            series31.ChartArea = "categoryChartArea";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series31.Color = System.Drawing.Color.Transparent;
            series31.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series31.IsValueShownAsLabel = true;
            series31.IsXValueIndexed = true;
            series31.LabelBackColor = System.Drawing.Color.Transparent;
            series31.LabelBorderColor = System.Drawing.Color.Transparent;
            series31.LabelForeColor = System.Drawing.Color.Transparent;
            series31.Legend = "Legends";
            series31.LegendToolTip = "#LEGENDTEXT#VAL";
            series31.MarkerBorderColor = System.Drawing.Color.Transparent;
            series31.MarkerColor = System.Drawing.Color.Transparent;
            series31.Name = "categorySeries";
            series31.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series31.ShadowColor = System.Drawing.Color.Transparent;
            series31.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series31.ToolTip = "#LEGENDTEXT#VAL";
            this.categoryCopiesChart.Series.Add(series31);
            this.categoryCopiesChart.Size = new System.Drawing.Size(309, 193);
            this.categoryCopiesChart.TabIndex = 3;
            title19.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title19.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title19.BorderWidth = 0;
            title19.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title19.ForeColor = System.Drawing.SystemColors.Control;
            title19.Name = "categoryTitle";
            title19.ShadowColor = System.Drawing.Color.Transparent;
            title19.Text = "Copies Per Category";
            title19.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.categoryCopiesChart.Titles.Add(title19);
            // 
            // PANEL_monthlyCopies
            // 
            this.PANEL_monthlyCopies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PANEL_monthlyCopies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PANEL_monthlyCopies.BorderWidth = 3F;
            this.PANEL_monthlyCopies.Controls.Add(this.monthlyCopiesTablePanel);
            this.PANEL_monthlyCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_monthlyCopies.Location = new System.Drawing.Point(3, 358);
            this.PANEL_monthlyCopies.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PANEL_monthlyCopies.MinimumSize = new System.Drawing.Size(143, 60);
            this.PANEL_monthlyCopies.Name = "PANEL_monthlyCopies";
            this.PANEL_monthlyCopies.Radius = 10;
            this.PANEL_monthlyCopies.Size = new System.Drawing.Size(154, 60);
            this.PANEL_monthlyCopies.TabIndex = 1;
            // 
            // monthlyCopiesTablePanel
            // 
            this.monthlyCopiesTablePanel.AutoSize = true;
            this.monthlyCopiesTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.monthlyCopiesTablePanel.ColumnCount = 1;
            this.monthlyCopiesTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyCopiesTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyCopiesTablePanel.Controls.Add(this.monthlyCopiesCountLabel, 0, 1);
            this.monthlyCopiesTablePanel.Controls.Add(this.monthlyCopiesLabel, 0, 0);
            this.monthlyCopiesTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyCopiesTablePanel.Location = new System.Drawing.Point(0, 0);
            this.monthlyCopiesTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyCopiesTablePanel.Name = "monthlyCopiesTablePanel";
            this.monthlyCopiesTablePanel.Padding = new System.Windows.Forms.Padding(5);
            this.monthlyCopiesTablePanel.RowCount = 2;
            this.monthlyCopiesTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyCopiesTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyCopiesTablePanel.Size = new System.Drawing.Size(154, 60);
            this.monthlyCopiesTablePanel.TabIndex = 1;
            // 
            // monthlyCopiesCountLabel
            // 
            this.monthlyCopiesCountLabel.AutoSize = true;
            this.monthlyCopiesCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyCopiesCountLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.monthlyCopiesCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyCopiesCountLabel.Location = new System.Drawing.Point(8, 30);
            this.monthlyCopiesCountLabel.Name = "monthlyCopiesCountLabel";
            this.monthlyCopiesCountLabel.Size = new System.Drawing.Size(138, 25);
            this.monthlyCopiesCountLabel.TabIndex = 1;
            this.monthlyCopiesCountLabel.Text = "000";
            this.monthlyCopiesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthlyCopiesLabel
            // 
            this.monthlyCopiesLabel.AutoSize = true;
            this.monthlyCopiesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyCopiesLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyCopiesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyCopiesLabel.Location = new System.Drawing.Point(8, 5);
            this.monthlyCopiesLabel.Name = "monthlyCopiesLabel";
            this.monthlyCopiesLabel.Size = new System.Drawing.Size(138, 25);
            this.monthlyCopiesLabel.TabIndex = 0;
            this.monthlyCopiesLabel.Text = "Book Copies";
            this.monthlyCopiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PANEL_monthlyReturned
            // 
            this.PANEL_monthlyReturned.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.PANEL_monthlyReturned.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.PANEL_monthlyReturned.BorderWidth = 3F;
            this.PANEL_monthlyReturned.Controls.Add(this.monthlyReturnedTablePanel);
            this.PANEL_monthlyReturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_monthlyReturned.Location = new System.Drawing.Point(3, 284);
            this.PANEL_monthlyReturned.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PANEL_monthlyReturned.MinimumSize = new System.Drawing.Size(153, 60);
            this.PANEL_monthlyReturned.Name = "PANEL_monthlyReturned";
            this.PANEL_monthlyReturned.Radius = 10;
            this.PANEL_monthlyReturned.Size = new System.Drawing.Size(154, 60);
            this.PANEL_monthlyReturned.TabIndex = 1;
            // 
            // monthlyReturnedTablePanel
            // 
            this.monthlyReturnedTablePanel.AutoSize = true;
            this.monthlyReturnedTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.monthlyReturnedTablePanel.ColumnCount = 1;
            this.monthlyReturnedTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyReturnedTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyReturnedTablePanel.Controls.Add(this.monthlyReturnedCountLabel, 0, 1);
            this.monthlyReturnedTablePanel.Controls.Add(this.monthlyReturnedLabel, 0, 0);
            this.monthlyReturnedTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyReturnedTablePanel.Location = new System.Drawing.Point(0, 0);
            this.monthlyReturnedTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyReturnedTablePanel.Name = "monthlyReturnedTablePanel";
            this.monthlyReturnedTablePanel.Padding = new System.Windows.Forms.Padding(5);
            this.monthlyReturnedTablePanel.RowCount = 2;
            this.monthlyReturnedTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyReturnedTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyReturnedTablePanel.Size = new System.Drawing.Size(154, 60);
            this.monthlyReturnedTablePanel.TabIndex = 1;
            // 
            // monthlyReturnedCountLabel
            // 
            this.monthlyReturnedCountLabel.AutoSize = true;
            this.monthlyReturnedCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyReturnedCountLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.monthlyReturnedCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyReturnedCountLabel.Location = new System.Drawing.Point(8, 30);
            this.monthlyReturnedCountLabel.Name = "monthlyReturnedCountLabel";
            this.monthlyReturnedCountLabel.Size = new System.Drawing.Size(138, 25);
            this.monthlyReturnedCountLabel.TabIndex = 1;
            this.monthlyReturnedCountLabel.Text = "000";
            this.monthlyReturnedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthlyReturnedLabel
            // 
            this.monthlyReturnedLabel.AutoSize = true;
            this.monthlyReturnedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyReturnedLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyReturnedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyReturnedLabel.Location = new System.Drawing.Point(8, 5);
            this.monthlyReturnedLabel.Name = "monthlyReturnedLabel";
            this.monthlyReturnedLabel.Size = new System.Drawing.Size(138, 25);
            this.monthlyReturnedLabel.TabIndex = 0;
            this.monthlyReturnedLabel.Text = "Books Returned";
            this.monthlyReturnedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PANEL_monthlyLoaned
            // 
            this.PANEL_monthlyLoaned.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PANEL_monthlyLoaned.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PANEL_monthlyLoaned.BorderWidth = 1F;
            this.PANEL_monthlyLoaned.Controls.Add(this.monthlyLoanedTablePanel);
            this.PANEL_monthlyLoaned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_monthlyLoaned.Location = new System.Drawing.Point(3, 210);
            this.PANEL_monthlyLoaned.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PANEL_monthlyLoaned.MinimumSize = new System.Drawing.Size(153, 60);
            this.PANEL_monthlyLoaned.Name = "PANEL_monthlyLoaned";
            this.PANEL_monthlyLoaned.Radius = 10;
            this.PANEL_monthlyLoaned.Size = new System.Drawing.Size(154, 60);
            this.PANEL_monthlyLoaned.TabIndex = 1;
            // 
            // monthlyLoanedTablePanel
            // 
            this.monthlyLoanedTablePanel.AutoSize = true;
            this.monthlyLoanedTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.monthlyLoanedTablePanel.ColumnCount = 1;
            this.monthlyLoanedTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyLoanedTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyLoanedTablePanel.Controls.Add(this.monthlyLoanedCountLabel, 0, 1);
            this.monthlyLoanedTablePanel.Controls.Add(this.monthlyLoanedLabel, 0, 0);
            this.monthlyLoanedTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyLoanedTablePanel.Location = new System.Drawing.Point(0, 0);
            this.monthlyLoanedTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyLoanedTablePanel.Name = "monthlyLoanedTablePanel";
            this.monthlyLoanedTablePanel.Padding = new System.Windows.Forms.Padding(5);
            this.monthlyLoanedTablePanel.RowCount = 2;
            this.monthlyLoanedTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyLoanedTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyLoanedTablePanel.Size = new System.Drawing.Size(154, 60);
            this.monthlyLoanedTablePanel.TabIndex = 1;
            // 
            // monthlyLoanedCountLabel
            // 
            this.monthlyLoanedCountLabel.AutoSize = true;
            this.monthlyLoanedCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyLoanedCountLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.monthlyLoanedCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyLoanedCountLabel.Location = new System.Drawing.Point(8, 30);
            this.monthlyLoanedCountLabel.Name = "monthlyLoanedCountLabel";
            this.monthlyLoanedCountLabel.Size = new System.Drawing.Size(138, 25);
            this.monthlyLoanedCountLabel.TabIndex = 1;
            this.monthlyLoanedCountLabel.Text = "000";
            this.monthlyLoanedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthlyLoanedLabel
            // 
            this.monthlyLoanedLabel.AutoSize = true;
            this.monthlyLoanedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyLoanedLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyLoanedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyLoanedLabel.Location = new System.Drawing.Point(8, 5);
            this.monthlyLoanedLabel.Name = "monthlyLoanedLabel";
            this.monthlyLoanedLabel.Size = new System.Drawing.Size(138, 25);
            this.monthlyLoanedLabel.TabIndex = 0;
            this.monthlyLoanedLabel.Text = "Books Loaned";
            this.monthlyLoanedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PANEL_monthlyUser
            // 
            this.PANEL_monthlyUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PANEL_monthlyUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PANEL_monthlyUser.BorderWidth = 1F;
            this.PANEL_monthlyUser.Controls.Add(this.monthlyUserTablePanel);
            this.PANEL_monthlyUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_monthlyUser.Location = new System.Drawing.Point(3, 62);
            this.PANEL_monthlyUser.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PANEL_monthlyUser.MinimumSize = new System.Drawing.Size(153, 60);
            this.PANEL_monthlyUser.Name = "PANEL_monthlyUser";
            this.PANEL_monthlyUser.Padding = new System.Windows.Forms.Padding(5);
            this.PANEL_monthlyUser.Radius = 10;
            this.PANEL_monthlyUser.Size = new System.Drawing.Size(154, 60);
            this.PANEL_monthlyUser.TabIndex = 0;
            // 
            // monthlyUserTablePanel
            // 
            this.monthlyUserTablePanel.AutoSize = true;
            this.monthlyUserTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.monthlyUserTablePanel.ColumnCount = 1;
            this.monthlyUserTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyUserTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyUserTablePanel.Controls.Add(this.monthlyUserCountLabel, 0, 1);
            this.monthlyUserTablePanel.Controls.Add(this.monthlyUserLabel, 0, 0);
            this.monthlyUserTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyUserTablePanel.Location = new System.Drawing.Point(5, 5);
            this.monthlyUserTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyUserTablePanel.Name = "monthlyUserTablePanel";
            this.monthlyUserTablePanel.Padding = new System.Windows.Forms.Padding(5);
            this.monthlyUserTablePanel.RowCount = 2;
            this.monthlyUserTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyUserTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyUserTablePanel.Size = new System.Drawing.Size(144, 50);
            this.monthlyUserTablePanel.TabIndex = 0;
            // 
            // monthlyUserCountLabel
            // 
            this.monthlyUserCountLabel.AutoSize = true;
            this.monthlyUserCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyUserCountLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyUserCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyUserCountLabel.Location = new System.Drawing.Point(8, 25);
            this.monthlyUserCountLabel.Name = "monthlyUserCountLabel";
            this.monthlyUserCountLabel.Size = new System.Drawing.Size(128, 20);
            this.monthlyUserCountLabel.TabIndex = 1;
            this.monthlyUserCountLabel.Text = "000";
            this.monthlyUserCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthlyUserLabel
            // 
            this.monthlyUserLabel.AutoSize = true;
            this.monthlyUserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyUserLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyUserLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyUserLabel.Location = new System.Drawing.Point(8, 5);
            this.monthlyUserLabel.MaximumSize = new System.Drawing.Size(0, 25);
            this.monthlyUserLabel.Name = "monthlyUserLabel";
            this.monthlyUserLabel.Size = new System.Drawing.Size(128, 20);
            this.monthlyUserLabel.TabIndex = 0;
            this.monthlyUserLabel.Text = "Active Users";
            this.monthlyUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PANEL_monthlyReserved
            // 
            this.PANEL_monthlyReserved.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.PANEL_monthlyReserved.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.PANEL_monthlyReserved.BorderWidth = 1F;
            this.PANEL_monthlyReserved.Controls.Add(this.monthlyReservedTablePanel);
            this.PANEL_monthlyReserved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_monthlyReserved.Location = new System.Drawing.Point(3, 136);
            this.PANEL_monthlyReserved.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PANEL_monthlyReserved.MinimumSize = new System.Drawing.Size(153, 60);
            this.PANEL_monthlyReserved.Name = "PANEL_monthlyReserved";
            this.PANEL_monthlyReserved.Radius = 10;
            this.PANEL_monthlyReserved.Size = new System.Drawing.Size(154, 60);
            this.PANEL_monthlyReserved.TabIndex = 1;
            // 
            // monthlyReservedTablePanel
            // 
            this.monthlyReservedTablePanel.AutoSize = true;
            this.monthlyReservedTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.monthlyReservedTablePanel.ColumnCount = 1;
            this.monthlyReservedTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyReservedTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyReservedTablePanel.Controls.Add(this.monthlyReservedCountLabel, 0, 1);
            this.monthlyReservedTablePanel.Controls.Add(this.monthlyReservedLabel, 0, 0);
            this.monthlyReservedTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyReservedTablePanel.Location = new System.Drawing.Point(0, 0);
            this.monthlyReservedTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyReservedTablePanel.Name = "monthlyReservedTablePanel";
            this.monthlyReservedTablePanel.Padding = new System.Windows.Forms.Padding(5);
            this.monthlyReservedTablePanel.RowCount = 2;
            this.monthlyReservedTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyReservedTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.monthlyReservedTablePanel.Size = new System.Drawing.Size(154, 60);
            this.monthlyReservedTablePanel.TabIndex = 1;
            // 
            // monthlyReservedCountLabel
            // 
            this.monthlyReservedCountLabel.AutoSize = true;
            this.monthlyReservedCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyReservedCountLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.monthlyReservedCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyReservedCountLabel.Location = new System.Drawing.Point(8, 30);
            this.monthlyReservedCountLabel.Name = "monthlyReservedCountLabel";
            this.monthlyReservedCountLabel.Size = new System.Drawing.Size(138, 25);
            this.monthlyReservedCountLabel.TabIndex = 1;
            this.monthlyReservedCountLabel.Text = "000";
            this.monthlyReservedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthlyReservedLabel
            // 
            this.monthlyReservedLabel.AutoSize = true;
            this.monthlyReservedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyReservedLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyReservedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.monthlyReservedLabel.Location = new System.Drawing.Point(8, 5);
            this.monthlyReservedLabel.Name = "monthlyReservedLabel";
            this.monthlyReservedLabel.Size = new System.Drawing.Size(138, 25);
            this.monthlyReservedLabel.TabIndex = 0;
            this.monthlyReservedLabel.Text = "Books Reserved";
            this.monthlyReservedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PANEL_genreCopies
            // 
            this.PANEL_genreCopies.AutoScroll = true;
            this.PANEL_genreCopies.BackgroundColor = System.Drawing.Color.Transparent;
            this.PANEL_genreCopies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.PANEL_genreCopies.BorderWidth = 3F;
            this.PANEL_genreCopies.Controls.Add(this.genreCopiesChart);
            this.PANEL_genreCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_genreCopies.Location = new System.Drawing.Point(359, 437);
            this.PANEL_genreCopies.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
            this.PANEL_genreCopies.Name = "PANEL_genreCopies";
            this.PANEL_genreCopies.Padding = new System.Windows.Forms.Padding(11, 10, 15, 10);
            this.PANEL_genreCopies.Radius = 10;
            this.PANEL_genreCopies.Size = new System.Drawing.Size(308, 213);
            this.PANEL_genreCopies.TabIndex = 2;
            // 
            // genreCopiesChart
            // 
            this.genreCopiesChart.BackColor = System.Drawing.Color.Transparent;
            this.genreCopiesChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.genreCopiesChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.genreCopiesChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.genreCopiesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea20.BackColor = System.Drawing.Color.Transparent;
            chartArea20.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea20.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea20.BorderColor = System.Drawing.Color.Transparent;
            chartArea20.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea20.Name = "genreChartArea";
            chartArea20.ShadowColor = System.Drawing.Color.Transparent;
            this.genreCopiesChart.ChartAreas.Add(chartArea20);
            this.genreCopiesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreCopiesChart.IsSoftShadows = false;
            legend20.Alignment = System.Drawing.StringAlignment.Far;
            legend20.AutoFitMinFontSize = 6;
            legend20.BackColor = System.Drawing.Color.Transparent;
            legendCellColumn27.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol;
            legendCellColumn27.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legendCellColumn27.HeaderFont = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legendCellColumn27.Name = "Column1";
            legendCellColumn27.SeriesSymbolSize = new System.Drawing.Size(70, 70);
            legendCellColumn27.ToolTip = "#VAL";
            legendCellColumn28.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legendCellColumn28.Name = "Column2";
            legendCellColumn28.ToolTip = "#VAL";
            legend20.CellColumns.Add(legendCellColumn27);
            legend20.CellColumns.Add(legendCellColumn28);
            legend20.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            legend20.ForeColor = System.Drawing.SystemColors.Control;
            legend20.IsDockedInsideChartArea = false;
            legend20.IsEquallySpacedItems = true;
            legend20.IsTextAutoFit = false;
            legend20.ItemColumnSpacing = 10;
            legend20.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder;
            legend20.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend20.MaximumAutoSize = 40F;
            legend20.Name = "Legends";
            legend20.ShadowColor = System.Drawing.Color.Transparent;
            legend20.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend20.Title = "Legends";
            legend20.TitleBackColor = System.Drawing.Color.Transparent;
            legend20.TitleFont = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend20.TitleForeColor = System.Drawing.SystemColors.Control;
            legend20.TitleSeparatorColor = System.Drawing.Color.Transparent;
            this.genreCopiesChart.Legends.Add(legend20);
            this.genreCopiesChart.Location = new System.Drawing.Point(11, 10);
            this.genreCopiesChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreCopiesChart.Name = "genreCopiesChart";
            this.genreCopiesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.genreCopiesChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(54)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))))};
            series32.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series32.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series32.BackSecondaryColor = System.Drawing.Color.Transparent;
            series32.BorderColor = System.Drawing.Color.Transparent;
            series32.ChartArea = "genreChartArea";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series32.Color = System.Drawing.Color.Transparent;
            series32.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series32.IsValueShownAsLabel = true;
            series32.IsXValueIndexed = true;
            series32.Label = "#VALX";
            series32.LabelBackColor = System.Drawing.Color.Transparent;
            series32.LabelBorderColor = System.Drawing.Color.Transparent;
            series32.LabelForeColor = System.Drawing.Color.Transparent;
            series32.LabelToolTip = "#VALX";
            series32.Legend = "Legends";
            series32.LegendToolTip = "#LEGENDTEXT#VAL";
            series32.MarkerBorderColor = System.Drawing.Color.Transparent;
            series32.MarkerColor = System.Drawing.Color.Transparent;
            series32.Name = "genreSeries";
            series32.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series32.ShadowColor = System.Drawing.Color.Transparent;
            series32.ToolTip = "#LEGENDTEXT#VAL";
            this.genreCopiesChart.Series.Add(series32);
            this.genreCopiesChart.Size = new System.Drawing.Size(282, 193);
            this.genreCopiesChart.TabIndex = 2;
            title20.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title20.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title20.BorderWidth = 0;
            title20.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title20.ForeColor = System.Drawing.SystemColors.Control;
            title20.Name = "genreTitle";
            title20.ShadowColor = System.Drawing.Color.Transparent;
            title20.Text = "Copies Per Genre";
            title20.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.genreCopiesChart.Titles.Add(title20);
            // 
            // PANEL_monthlyComparison
            // 
            this.PANEL_monthlyComparison.BackgroundColor = System.Drawing.Color.Transparent;
            this.PANEL_monthlyComparison.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.PANEL_monthlyComparison.BorderWidth = 3F;
            this.LAYOUT_OVERVIEW.SetColumnSpan(this.PANEL_monthlyComparison, 3);
            this.PANEL_monthlyComparison.Controls.Add(this.monthlyComparisonChart);
            this.PANEL_monthlyComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_monthlyComparison.Location = new System.Drawing.Point(177, 62);
            this.PANEL_monthlyComparison.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.PANEL_monthlyComparison.MinimumSize = new System.Drawing.Size(250, 300);
            this.PANEL_monthlyComparison.Name = "PANEL_monthlyComparison";
            this.PANEL_monthlyComparison.Radius = 10;
            this.LAYOUT_OVERVIEW.SetRowSpan(this.PANEL_monthlyComparison, 9);
            this.PANEL_monthlyComparison.Size = new System.Drawing.Size(490, 350);
            this.PANEL_monthlyComparison.TabIndex = 3;
            // 
            // monthlyComparisonChart
            // 
            this.monthlyComparisonChart.BackColor = System.Drawing.Color.Transparent;
            this.monthlyComparisonChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.monthlyComparisonChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.monthlyComparisonChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.monthlyComparisonChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea21.AxisX.Interval = 1D;
            chartArea21.AxisX.LabelStyle.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea21.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.Control;
            chartArea21.AxisX.LabelStyle.Format = "MMM";
            chartArea21.AxisX.LineColor = System.Drawing.SystemColors.Control;
            chartArea21.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea21.AxisX.TitleFont = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea21.AxisX.TitleForeColor = System.Drawing.SystemColors.Control;
            chartArea21.AxisY.Interval = 10D;
            chartArea21.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.Control;
            chartArea21.AxisY.LineColor = System.Drawing.SystemColors.Control;
            chartArea21.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea21.BackColor = System.Drawing.Color.Transparent;
            chartArea21.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea21.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea21.BorderColor = System.Drawing.Color.Transparent;
            chartArea21.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea21.Name = "monthlyComparisonChartArea";
            chartArea21.ShadowColor = System.Drawing.Color.Transparent;
            this.monthlyComparisonChart.ChartAreas.Add(chartArea21);
            this.monthlyComparisonChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend21.BackColor = System.Drawing.Color.Transparent;
            legend21.DockedToChartArea = "monthlyComparisonChartArea";
            legend21.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            legend21.ForeColor = System.Drawing.SystemColors.Control;
            legend21.HeaderSeparatorColor = System.Drawing.SystemColors.Control;
            legend21.IsDockedInsideChartArea = false;
            legend21.IsEquallySpacedItems = true;
            legend21.IsTextAutoFit = false;
            legend21.ItemColumnSeparatorColor = System.Drawing.SystemColors.Control;
            legend21.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend21.Name = "Legends";
            legend21.ShadowColor = System.Drawing.Color.Transparent;
            legend21.Title = "Legends";
            legend21.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend21.TitleFont = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend21.TitleForeColor = System.Drawing.SystemColors.Control;
            legend21.TitleSeparatorColor = System.Drawing.SystemColors.Control;
            this.monthlyComparisonChart.Legends.Add(legend21);
            this.monthlyComparisonChart.Location = new System.Drawing.Point(0, 0);
            this.monthlyComparisonChart.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyComparisonChart.Name = "monthlyComparisonChart";
            this.monthlyComparisonChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.monthlyComparisonChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(54)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(59)))), ((int)(((byte)(239)))))};
            series33.ChartArea = "monthlyComparisonChartArea";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series33.Legend = "Legends";
            series33.MarkerBorderWidth = 4;
            series33.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series33.Name = "Books Loaned";
            series33.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series34.ChartArea = "monthlyComparisonChartArea";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series34.LabelForeColor = System.Drawing.Color.Transparent;
            series34.Legend = "Legends";
            series34.MarkerBorderWidth = 4;
            series34.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series34.Name = "Books Reserved";
            series35.ChartArea = "monthlyComparisonChartArea";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series35.Legend = "Legends";
            series35.MarkerBorderWidth = 4;
            series35.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series35.Name = "Books Returned";
            this.monthlyComparisonChart.Series.Add(series33);
            this.monthlyComparisonChart.Series.Add(series34);
            this.monthlyComparisonChart.Series.Add(series35);
            this.monthlyComparisonChart.Size = new System.Drawing.Size(490, 350);
            this.monthlyComparisonChart.TabIndex = 2;
            title21.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title21.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title21.BorderWidth = 0;
            title21.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title21.ForeColor = System.Drawing.SystemColors.Control;
            title21.Name = "Title1";
            title21.ShadowColor = System.Drawing.Color.Transparent;
            title21.Text = "Book Circulation Chart";
            title21.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.monthlyComparisonChart.Titles.Add(title21);
            // 
            // monthlyOverviewLabel
            // 
            this.monthlyOverviewLabel.AutoSize = true;
            this.LAYOUT_OVERVIEW.SetColumnSpan(this.monthlyOverviewLabel, 5);
            this.monthlyOverviewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyOverviewLabel.Font = new System.Drawing.Font("Montserrat Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyOverviewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(190)))), ((int)(((byte)(143)))));
            this.monthlyOverviewLabel.Location = new System.Drawing.Point(0, 0);
            this.monthlyOverviewLabel.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyOverviewLabel.MaximumSize = new System.Drawing.Size(0, 52);
            this.monthlyOverviewLabel.MinimumSize = new System.Drawing.Size(0, 52);
            this.monthlyOverviewLabel.Name = "monthlyOverviewLabel";
            this.monthlyOverviewLabel.Size = new System.Drawing.Size(670, 52);
            this.monthlyOverviewLabel.TabIndex = 5;
            this.monthlyOverviewLabel.Text = "Monthly Overview";
            this.monthlyOverviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monthlyOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LAYOUT_OVERVIEW);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(1758, 0);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "monthlyOverview";
            this.Size = new System.Drawing.Size(670, 650);
            this.Load += new System.EventHandler(this.monthlyOverview_Load);
            this.LAYOUT_OVERVIEW.ResumeLayout(false);
            this.LAYOUT_OVERVIEW.PerformLayout();
            this.PANEL_categoryCopies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryCopiesChart)).EndInit();
            this.PANEL_monthlyCopies.ResumeLayout(false);
            this.PANEL_monthlyCopies.PerformLayout();
            this.monthlyCopiesTablePanel.ResumeLayout(false);
            this.monthlyCopiesTablePanel.PerformLayout();
            this.PANEL_monthlyReturned.ResumeLayout(false);
            this.PANEL_monthlyReturned.PerformLayout();
            this.monthlyReturnedTablePanel.ResumeLayout(false);
            this.monthlyReturnedTablePanel.PerformLayout();
            this.PANEL_monthlyLoaned.ResumeLayout(false);
            this.PANEL_monthlyLoaned.PerformLayout();
            this.monthlyLoanedTablePanel.ResumeLayout(false);
            this.monthlyLoanedTablePanel.PerformLayout();
            this.PANEL_monthlyUser.ResumeLayout(false);
            this.PANEL_monthlyUser.PerformLayout();
            this.monthlyUserTablePanel.ResumeLayout(false);
            this.monthlyUserTablePanel.PerformLayout();
            this.PANEL_monthlyReserved.ResumeLayout(false);
            this.PANEL_monthlyReserved.PerformLayout();
            this.monthlyReservedTablePanel.ResumeLayout(false);
            this.monthlyReservedTablePanel.PerformLayout();
            this.PANEL_genreCopies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genreCopiesChart)).EndInit();
            this.PANEL_monthlyComparison.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyComparisonChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LAYOUT_OVERVIEW;
        private RoundedCorners.RoundedPanel PANEL_categoryCopies;
        private RoundedCorners.RoundedPanel PANEL_monthlyCopies;
        private System.Windows.Forms.TableLayoutPanel monthlyCopiesTablePanel;
        private System.Windows.Forms.Label monthlyCopiesCountLabel;
        private System.Windows.Forms.Label monthlyCopiesLabel;
        private RoundedCorners.RoundedPanel PANEL_monthlyReturned;
        private System.Windows.Forms.TableLayoutPanel monthlyReturnedTablePanel;
        private System.Windows.Forms.Label monthlyReturnedCountLabel;
        private System.Windows.Forms.Label monthlyReturnedLabel;
        private RoundedCorners.RoundedPanel PANEL_monthlyLoaned;
        private System.Windows.Forms.TableLayoutPanel monthlyLoanedTablePanel;
        private System.Windows.Forms.Label monthlyLoanedCountLabel;
        private System.Windows.Forms.Label monthlyLoanedLabel;
        private RoundedCorners.RoundedPanel PANEL_monthlyUser;
        private System.Windows.Forms.TableLayoutPanel monthlyUserTablePanel;
        private System.Windows.Forms.Label monthlyUserCountLabel;
        private System.Windows.Forms.Label monthlyUserLabel;
        private RoundedCorners.RoundedPanel PANEL_monthlyReserved;
        private System.Windows.Forms.TableLayoutPanel monthlyReservedTablePanel;
        private System.Windows.Forms.Label monthlyReservedCountLabel;
        private System.Windows.Forms.Label monthlyReservedLabel;
        private RoundedCorners.RoundedPanel PANEL_genreCopies;
        private RoundedCorners.RoundedPanel PANEL_monthlyComparison;
        private System.Windows.Forms.Label monthlyOverviewLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthlyComparisonChart;
        private Chart genreCopiesChart;
        private Chart categoryCopiesChart;
    }
}

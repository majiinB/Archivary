namespace Archivary.PARENT_FORMS
{
    partial class FORM_SETTINGS
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
            this.LAYOUT_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.PANEL_CONTAINER = new System.Windows.Forms.Panel();
            this.leftPanelBorder = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanelBorder = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.saveButton = new roundedCorners.roundedButton();
            this.editButton = new roundedCorners.roundedButton();
            this.LAYOUT_buttons.SuspendLayout();
            this.PANEL_CONTAINER.SuspendLayout();
            this.leftPanelBorder.SuspendLayout();
            this.rightPanelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // LAYOUT_buttons
            // 
            this.LAYOUT_buttons.ColumnCount = 2;
            this.LAYOUT_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_buttons.Controls.Add(this.saveButton, 1, 0);
            this.LAYOUT_buttons.Controls.Add(this.editButton, 0, 0);
            this.LAYOUT_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LAYOUT_buttons.Location = new System.Drawing.Point(0, 570);
            this.LAYOUT_buttons.Name = "LAYOUT_buttons";
            this.LAYOUT_buttons.Padding = new System.Windows.Forms.Padding(10);
            this.LAYOUT_buttons.RowCount = 1;
            this.LAYOUT_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_buttons.Size = new System.Drawing.Size(960, 100);
            this.LAYOUT_buttons.TabIndex = 1;
            // 
            // PANEL_CONTAINER
            // 
            this.PANEL_CONTAINER.Controls.Add(this.leftPanelBorder);
            this.PANEL_CONTAINER.Controls.Add(this.rightPanelBorder);
            this.PANEL_CONTAINER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTAINER.Location = new System.Drawing.Point(0, 0);
            this.PANEL_CONTAINER.Name = "PANEL_CONTAINER";
            this.PANEL_CONTAINER.Size = new System.Drawing.Size(960, 570);
            this.PANEL_CONTAINER.TabIndex = 2;
            // 
            // leftPanelBorder
            // 
            this.leftPanelBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.leftPanelBorder.Controls.Add(this.leftPanel);
            this.leftPanelBorder.Location = new System.Drawing.Point(13, 12);
            this.leftPanelBorder.Name = "leftPanelBorder";
            this.leftPanelBorder.Padding = new System.Windows.Forms.Padding(3);
            this.leftPanelBorder.Size = new System.Drawing.Size(479, 534);
            this.leftPanelBorder.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(473, 528);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanelBorder
            // 
            this.rightPanelBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.rightPanelBorder.Controls.Add(this.rightPanel);
            this.rightPanelBorder.Location = new System.Drawing.Point(510, 12);
            this.rightPanelBorder.Name = "rightPanelBorder";
            this.rightPanelBorder.Padding = new System.Windows.Forms.Padding(3);
            this.rightPanelBorder.Size = new System.Drawing.Size(437, 534);
            this.rightPanelBorder.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(3, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(431, 528);
            this.rightPanel.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.saveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.saveButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveButton.BorderRadius = 20;
            this.saveButton.BorderSize = 0;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Montserrat Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(483, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(464, 74);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.TextColor = System.Drawing.Color.White;
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.editButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editButton.BorderRadius = 20;
            this.editButton.BorderSize = 0;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Montserrat Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(13, 13);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(464, 74);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.TextColor = System.Drawing.Color.White;
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // FORM_SETTINGS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 670);
            this.ControlBox = false;
            this.Controls.Add(this.PANEL_CONTAINER);
            this.Controls.Add(this.LAYOUT_buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_SETTINGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_SETTINGS";
            this.Load += new System.EventHandler(this.FORM_SETTINGS_Load);
            this.Resize += new System.EventHandler(this.FORM_SETTINGS_Resize);
            this.LAYOUT_buttons.ResumeLayout(false);
            this.PANEL_CONTAINER.ResumeLayout(false);
            this.leftPanelBorder.ResumeLayout(false);
            this.rightPanelBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private roundedCorners.roundedButton saveButton;
        private roundedCorners.roundedButton editButton;
        private System.Windows.Forms.TableLayoutPanel LAYOUT_buttons;
        private System.Windows.Forms.Panel PANEL_CONTAINER;
        private System.Windows.Forms.Panel leftPanelBorder;
        private System.Windows.Forms.Panel rightPanelBorder;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
    }
}
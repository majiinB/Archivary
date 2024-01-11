using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary._900X500
{
    public partial class FORM_ALERT : Form
    {
        public enum KIND_OF_ALERT
        {
            Error = 1,
            Confirmation = 2,
            Success = 3,
            Warning = 4
        }
        public FORM_ALERT(int condition, string errorTitle, string errorMessage)
        {
            InitializeComponent();

            //initialize message
            alertTitleLabel.Text = errorTitle;
            alertMessageLabel.Text = errorMessage;

            //Condition
            if(condition == (int)KIND_OF_ALERT.Error)
            {
                //Apply logic kung ano gusto niyo baguhin dito kung error
                iconPictureBox.Image = Archivary.Properties.Resources.ICON_STOP;
                tableLayoutPanel1.SetColumnSpan(continueButton, 2);
                alertTitleLabel.ForeColor= Color.FromArgb(227, 25, 55);
                continueButton.BackColor = Color.FromArgb(227, 25, 55);
                cancelButton.Visible = false;
            }
            else if (condition == (int)KIND_OF_ALERT.Success)
            {
                //Apply logic kung ano gusto niyo baguhin dito kung success
                iconPictureBox.Image = Archivary.Properties.Resources.ArchivaryLogoGreen;
                tableLayoutPanel1.SetColumnSpan(continueButton, 2);
                alertTitleLabel.ForeColor = Color.FromArgb(37, 211, 102);
                continueButton.BackColor = Color.FromArgb(37, 211, 102);
                cancelButton.Visible = false;
            }
            else if (condition == (int)KIND_OF_ALERT.Confirmation)
            {
                //Apply logic kung ano gusto niyo baguhin dito kung confirmation
                iconPictureBox.Image = Archivary.Properties.Resources.ICON_WARNING1;
                alertTitleLabel.ForeColor = Color.FromArgb(128, 128, 255);
                continueButton.BackColor = Color.FromArgb(128, 128, 255);
                
            }
            else if (condition == (int)KIND_OF_ALERT.Warning)
            {
                //Apply logic kung ano gusto niyo baguhin dito kung confirmation
                iconPictureBox.Image = Archivary.Properties.Resources.ICON_WARNING1;
                alertTitleLabel.ForeColor = Color.FromArgb(240, 215, 49);
                continueButton.BackColor = Color.FromArgb(240, 215, 49);

            }
            //for centering the alertMessageLabel
            alertMessageLabel.ParentChanged += (sender, e) => CenterLabel();
            CenterLabel(); 

        }
        private void CenterLabel() //<-- for centering labels kasi nawawala text alignment pag naka-set to true yung auto size
        {
            if (alertMessageLabel.Parent is FlowLayoutPanel)
            {
                FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)alertMessageLabel.Parent;

                int spaceLeft = flowLayoutPanel.ClientSize.Width - alertMessageLabel.Width;
                alertMessageLabel.Padding = new Padding(spaceLeft / 2, alertMessageLabel.Padding.Top, 0, 0);
            }
        }
        private void FORM_ALERT_Load(object sender, EventArgs e)
        {

        }
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }
        private void FORM_ALERT_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(244,244,244), 5);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
            Success = 3
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
                cancelButton.Visible = false;
            }
            else if (condition == (int)KIND_OF_ALERT.Success)
            {
                //Apply logic kung ano gusto niyo baguhin dito kung success
                cancelButton.Visible = false;
            }
            else if (condition == (int)KIND_OF_ALERT.Confirmation)
            {
                //Apply logic kung ano gusto niyo baguhin dito kung confirmation
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

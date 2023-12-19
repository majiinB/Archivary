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
    public partial class FORM_PASSWORD : Form
    {
        public FORM_PASSWORD()
        {
            InitializeComponent();
        }
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }
        private void FORM_PASSWORD_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(37, 211, 102), 3);
        }


        //
        // CONFIRMATION BUTTONS
        //
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {

        }

        //
        // TOGGLE EYE BUTTONS
        //
        private bool isToggled = false;

        private void oldEyeButton_Click(object sender, EventArgs e)
        {
            isToggled = !isToggled;
            if (isToggled)
            {
                this.oldEyeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_EYE;
                oldPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                this.oldEyeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_EYE_SLASH;
                oldPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void newEyeButton_Click(object sender, EventArgs e)
        {
            isToggled = !isToggled;
            if (isToggled)
            {
                this.newEyeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_EYE;
                newPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                this.newEyeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_EYE_SLASH;
                newPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void confirmEyeButton_Click(object sender, EventArgs e)
        {
            isToggled = !isToggled;
            if (isToggled)
            {
                this.confirmEyeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_EYE;
                confirmNewPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                this.oldEyeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_EYE_SLASH;
                oldPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}

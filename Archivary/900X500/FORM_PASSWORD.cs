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
        private bool isToggled1 = false;
        private bool isToggled2 = false;
        private bool isToggled3 = false;

        private void oldEyeButton_Click(object sender, EventArgs e)
        {
            isToggled1 = !isToggled1;
            if (isToggled1)
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
            isToggled2 = !isToggled2;
            if (isToggled2)
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
            isToggled3 = !isToggled3;
            if (isToggled3)
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

        //
        // OLD PASSWORD HOVERS
        //
        private string passwordInput1, passwordInput2, passwordInput3;
        private void oldPasswordTextBox_Enter(object sender, EventArgs e)
        {
            passwordInput1 = oldPasswordTextBox.Text;
            if (passwordInput1 == "Enter Old Password  ") oldPasswordTextBox.Text = "";
            else oldPasswordTextBox.Text = passwordInput1;
        }

        private void oldPasswordTextBox_Leave(object sender, EventArgs e)
        {
            passwordInput1 = oldPasswordTextBox.Text;
            if (string.IsNullOrWhiteSpace(passwordInput1)) oldPasswordTextBox.Text = "Enter Old Password  ";
        }

        //
        // NEW PASSWORD HOVERS
        //
        private void newPasswordTextBox_Enter(object sender, EventArgs e)
        {
            passwordInput2 = newPasswordTextBox.Text;
            if (passwordInput2 == "Enter Old Password  ") newPasswordTextBox.Text = "";
            else newPasswordTextBox.Text = passwordInput2;
        }

        private void newPasswordTextBox_Leave(object sender, EventArgs e)
        {
            passwordInput2 = newPasswordTextBox.Text;
            if (string.IsNullOrWhiteSpace(passwordInput2)) newPasswordTextBox.Text = "Enter Old Password  ";
        }

        //
        // CONFIRM NEW PASSWORD HOVERS
        //
        private void confirmNewPasswordTextBox_Enter(object sender, EventArgs e)
        {
            passwordInput3 = confirmNewPasswordTextBox.Text;
            if (passwordInput3 == "Enter Old Password  ") confirmNewPasswordTextBox.Text = "";
            else confirmNewPasswordTextBox.Text = passwordInput3;
        }

        private void confirmNewPasswordTextBox_Leave(object sender, EventArgs e)
        {
            passwordInput3 = confirmNewPasswordTextBox.Text;
            if (string.IsNullOrWhiteSpace(passwordInput3)) confirmNewPasswordTextBox.Text = "Enter Old Password  ";
        }
    }
}

using Archivary.BACKEND.OBJECTS;
using Archivary.BACKEND.USER_OPERATIONS;
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
        private object user;
        public FORM_PASSWORD(object user)
        {
            InitializeComponent();
            this.user = user;
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
            if (!string.IsNullOrEmpty(oldPasswordTextBox.Text) &&
                !string.IsNullOrEmpty(newPasswordTextBox.Text) &&
                !string.IsNullOrEmpty(confirmNewPasswordTextBox.Text) &&
                oldPasswordTextBox.Text != "Enter Old Password  " &&
                newPasswordTextBox.Text != "Enter Old Password  " &&
                confirmNewPasswordTextBox.Text != "Enter Old Password  ")
            {
                if (user is Admin admin)
                {
                    string adminHashedPass = UserOperation.GetPassword(admin.AdminId);

                    if (UserOperation.VerifyPassword(oldPasswordTextBox.Text, adminHashedPass))
                    {
                        if (newPasswordTextBox.Text == confirmNewPasswordTextBox.Text)
                        {
                            if(newPasswordTextBox.Text != oldPasswordTextBox.Text)
                            {
                                if (UserOperation.UpdatePassword(admin.AdminId, UserOperation.HashPassword(newPasswordTextBox.Text)))
                                {
                                    MessageBox.Show("Admin Password Change Successful");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a different password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("New pass and confimation pass are not the same please try again");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect old password");
                    }
                }
                else if (user is Employee employee)
                {
                    string employeeHashedPass = UserOperation.GetPassword(employee.EmployeeId);

                    if (UserOperation.VerifyPassword(oldPasswordTextBox.Text, employeeHashedPass))
                    {
                        if (newPasswordTextBox.Text == confirmNewPasswordTextBox.Text)
                        {
                            if (newPasswordTextBox.Text != oldPasswordTextBox.Text)
                            {
                                if (UserOperation.UpdatePassword(employee.EmployeeId, UserOperation.HashPassword(newPasswordTextBox.Text)))
                                {
                                    MessageBox.Show("Employee Password Change Successful");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a different password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("New pass and confimation pass are not the same please try again");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect old password");
                    }
                }
            }
            else MessageBox.Show("One of the textbox are blank");
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
                this.confirmEyeButton.ButtonImage = global::Archivary.Properties.Resources.ICON_EYE_SLASH;
                confirmNewPasswordTextBox.UseSystemPasswordChar = true;
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

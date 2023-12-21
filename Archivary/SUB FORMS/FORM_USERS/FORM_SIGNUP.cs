using roundedCorners;
using RoundedCorners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary._1200X800.FORM_USERS
{
    public partial class FORM_SIGNUP : Form
    {
        private roundedButton currentBtn;

        public FORM_SIGNUP()
        {
            InitializeComponent();
            ActivateButton(studentButton);
        }
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid,
                color, borderWidth, ButtonBorderStyle.Solid);
        }
        private void FORM_SIGNUP_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(37, 211, 102), 3);//3 represents the border width
        }

        private void lastNameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (roundedButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 211, 102);
                currentBtn.ForeColor = Color.FromArgb(30, 30, 30);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(30, 30, 30);
                currentBtn.BorderSize = 2;
                currentBtn.BorderColor = Color.FromArgb(37, 211, 102);
                currentBtn.ForeColor = Color.FromArgb(37, 211, 102);
            }
        }
        private void studentButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ClearAllTextBoxes(this);
            profilePictureImageBox.Image = null; //to clear ImageBox when the button is clicked

            //visibility of textboxes and labels 
            collegeLabel.Visible = true;
            collegeTextBox.Visible = true;
            PANEL_CONTENTS.SetColumnSpan(collegeTextBox, 3);
            yearLabel.Visible = true;
            yearTextBox.Visible = true;
            sectionLabel.Visible = true;
            sectionTextBox.Visible = true;
            collegeTextBox.Size = new System.Drawing.Size(398, 38);
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ClearAllTextBoxes(this);
            profilePictureImageBox.Image = null; //to clear ImageBox when the button is clicked

            //visibility of textboxes and labels 
            collegeLabel.Visible = true;
            collegeTextBox.Visible = true;
            PANEL_CONTENTS.SetColumnSpan(collegeTextBox, 5);
            yearLabel.Visible = false;
            yearTextBox.Visible = false;
            sectionLabel.Visible = false;
            sectionTextBox.Visible = false;
            collegeTextBox.Size = new System.Drawing.Size(651, 38);

        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ClearAllTextBoxes(this);
            profilePictureImageBox.Image = null; //to clear ImageBox when the button is clicked

            //visibility of textboxes and labels 
            collegeLabel.Visible = false;
            collegeTextBox.Visible = false;
            yearLabel.Visible = false;
            yearTextBox.Visible = false;
            sectionLabel.Visible = false;
            sectionTextBox.Visible = false;
        }
        private void ClearAllTextBoxes(Control control)
        {
            foreach (Control textBoxes in control.Controls)
            {
                if (textBoxes is RoundedTextBox)
                {
                    ((RoundedTextBox)textBoxes).Text = string.Empty;
                }
                else if (textBoxes.HasChildren)
                {
                    ClearAllTextBoxes(textBoxes);
                }
            }
        }
    }
}

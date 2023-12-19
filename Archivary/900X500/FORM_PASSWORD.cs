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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oldOpenEyeButton_Click(object sender, EventArgs e)
        {
            oldPasswordTextBox.UseSystemPasswordChar = true;
            oldCloseEyeButton.Visible = true;
            oldOpenEyeButton.Visible = false;
        }

        private void oldCloseEyeButton_Click(object sender, EventArgs e)
        {
            oldPasswordTextBox.UseSystemPasswordChar = false;
            oldCloseEyeButton.Visible = false;
            oldOpenEyeButton.Visible = true;
        }

        private void newCloseEyeButton_Click(object sender, EventArgs e)
        {
            newPasswordTextBox.UseSystemPasswordChar = false;
            newCloseEyeButton.Visible = false;
            newOpenEyeButton.Visible = true;
        }

        private void newOpenEyeButton_Click(object sender, EventArgs e)
        {
            newPasswordTextBox.UseSystemPasswordChar = true;
            newCloseEyeButton.Visible = true;
            newOpenEyeButton.Visible = false;
        }

        private void confirmCloseEyeButton_Click(object sender, EventArgs e)
        {
           confirmNewPasswordTextBox.UseSystemPasswordChar = false;
           confirmCloseEyeButton.Visible = false;
           confirmOpenEyeButton.Visible = true;
        }

        private void confirmOpenEyeButton_Click(object sender, EventArgs e)
        {
            confirmNewPasswordTextBox.UseSystemPasswordChar = true;
            confirmCloseEyeButton.Visible = true;
            confirmOpenEyeButton.Visible = false;
        }
    }
}

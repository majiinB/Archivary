using Archivary._900X500;
using Archivary.PARENT_FORMS;
using Archivary.SUB_FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary._1500X1000.FORM_CIRCULATION
{
    public partial class FORM_POS : Form
    {
        public FORM_POS()
        {
            InitializeComponent();
        }
        private void FORM_POS_Load(object sender, EventArgs e)
        {
            this.Size = new Size(970, 670);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e) {
            //e.Graphics.DrawRectangle(new Pen(Color.FromArgb(29, 185, 84)), e.ClipRectangle);
        }

       
        private void FORM_POS_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(37, 211, 102), 3);
        }
        private void DrawCustomBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth)
        {
            ControlPaint.DrawBorder(graphics, rectangle, color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid, color, borderWidth, ButtonBorderStyle.Solid);
        }

        private void totalPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomCellBorder(e.Graphics, totalPanel.ClientRectangle, Color.FromArgb(37, 211, 102), 10, totalPanel);
        }
        private void changePanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomCellBorder(e.Graphics, totalPanel.ClientRectangle, Color.FromArgb(37, 211, 102), 10, totalPanel);

        }

        private void paymentPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCustomCellBorder(e.Graphics, totalPanel.ClientRectangle, Color.FromArgb(37, 211, 102), 10, totalPanel);
        }
        private void DrawCustomCellBorder(Graphics graphics, Rectangle rectangle, Color color, int borderWidth, TableLayoutPanel tableLayoutPanel)
        {

            using (Pen pen = new Pen(color, borderWidth))
            {
                graphics.DrawRectangle(pen, rectangle);
                rectangle.Inflate(-borderWidth / 2, -borderWidth / 2);

                for (int i = 1; i < tableLayoutPanel.RowCount;i++)
                {
                    int y = tableLayoutPanel.GetRowHeights().Take(i).Sum();
                    graphics.DrawLine(pen, rectangle.Left, y, rectangle.Right,y);
                }
                /*for(int i = 1; i < tableLayoutPanel.ColumnCount; i++)
                {
                    int x = tableLayoutPanel.GetColumnWidths().Take(i).Sum();
                    graphics.DrawLine(pen, x,rectangle.Top, x, rectangle.Bottom );
                }*/
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            FORM_ALERT FormsAlert = new FORM_ALERT();

            using (FORM_ROOT FormsReturn = new FORM_ROOT())
            {
                //MessageBox.Show("This is a simple alert!", "Alert Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormsAlert.ShowDialog();
            }
        }
    }

}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RoundedCorners
{
    public partial class RoundedPanel : Panel
    {
        private int radius = 10;

        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        private Color backgroundColor = SystemColors.Control;
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        private Color borderColor = SystemColors.Control;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        private float borderWidth = 1.0f;
        public float BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        public RoundedPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Resize += RoundedPanel_Resize;
            ControlAdded += RoundedPanel_ControlAdded;
        }

        private void RoundedPanel_Resize(object sender, EventArgs e)
        {
            // Redraw the panel on resize
            Invalidate();

            // Update the region of the child controls
            foreach (Control control in Controls)
            {
                if (control != null)
                {
                    control.Region = new Region(CreateRoundedRectanglePath());
                }
            }
        }

        private void RoundedPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            // Clip the child controls to the rounded shape of the panel
            if (e.Control != null)
            {
                e.Control.Region = new Region(CreateRoundedRectanglePath());
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Create a rounded rectangle path
            GraphicsPath path = CreateRoundedRectanglePath();

            // Draw background
            g.FillPath(new SolidBrush(backgroundColor), path);

            // Draw border
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                borderPen.Alignment = PenAlignment.Inset;
                g.DrawPath(borderPen, path);
            }
        }

        private GraphicsPath CreateRoundedRectanglePath()
        {
            int diameter = radius * 2;

            // Calculate adjusted starting points to avoid zigzag lines
            int startX = 0;
            int startY = 0;

            int widthMinusDiameter = Width - diameter - 1;
            int heightMinusDiameter = Height - diameter - 1;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(startX, startY, diameter, diameter, 180, 90);
            path.AddArc(widthMinusDiameter, startY, diameter, diameter, 270, 90);
            path.AddArc(widthMinusDiameter, heightMinusDiameter, diameter, diameter, 0, 90);
            path.AddArc(startX, heightMinusDiameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
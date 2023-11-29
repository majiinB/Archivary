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
            //InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Create a rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(Width - radius * 2 - 1, 0, radius * 2, radius * 2, 270, 90); // Adjusted starting angle
            path.AddArc(Width - radius * 2 - 1, Height - radius * 2 - 1, radius * 2, radius * 2, 0, 90); // Adjusted starting angle
            path.AddArc(0, Height - radius * 2 - 1, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            // Draw background
            g.FillPath(new SolidBrush(backgroundColor), path);

            // Draw border
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                borderPen.Alignment = PenAlignment.Inset;
                g.DrawPath(borderPen, path);
            }
        }

    }
}
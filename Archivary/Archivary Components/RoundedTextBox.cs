using System;
using System.Drawing;
using System.Windows.Forms;

public class RoundedTextBox : TextBox
{
    private const int BorderSize = 2;
    private const int BorderRadius = 10;

    public RoundedTextBox()
    {
        // Set the control style to enable double buffering
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        UpdateStyles();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a Graphics object for drawing
        using (Graphics g = e.Graphics)
        {
            // Draw the rounded border
            using (Pen borderPen = new Pen(BorderColor, BorderSize))
            {
                g.DrawArc(borderPen, 0, 0, BorderRadius * 2, BorderRadius * 2, 180, 90);
                g.DrawLine(borderPen, BorderRadius, 0, Width - BorderRadius, 0);
                g.DrawArc(borderPen, Width - BorderRadius * 2, 0, BorderRadius * 2, BorderRadius * 2, 270, 90);
                g.DrawLine(borderPen, Width, BorderRadius, Width, Height - BorderRadius);
                g.DrawArc(borderPen, Width - BorderRadius * 2, Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 0, 90);
                g.DrawLine(borderPen, BorderRadius, Height, Width - BorderRadius, Height);
                g.DrawArc(borderPen, 0, Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 90, 90);
                g.DrawLine(borderPen, 0, BorderRadius, 0, Height - BorderRadius);
            }
        }
    }

    private Color borderColor = Color.Black;

    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            borderColor = value;
            Invalidate(); // Redraw the control when the border color changes
        }
    }
}
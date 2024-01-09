using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RoundedCorners
{
    public class RoundedTextBox : Control
    {
        private int radius = 15;
        private int borderThickness = 4;
        public TextBox textBox = new TextBox();
        private GraphicsPath shape;
        private GraphicsPath innerRect;
        private Color backgroundColor = Color.White;
        private Color borderColor = Color.Black;
        private bool useSystemPasswordChar = false;
        private char originalPasswordChar;

        public int BorderThickness
        {
            get => borderThickness;
            set
            {
                borderThickness = value;
                AdjustTextBoxLayout();
                Invalidate();
            }
        }

        public new bool TabStop
        {
            get => base.TabStop;
            set
            {
                base.TabStop = value;
                textBox.TabStop = value;
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            textBox.Focus();
        }

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                // Manually handle tab key to focus on the next control
                SelectNextControl(this, true, true, true, true);
                return true;
            }
            return base.IsInputKey(keyData);
        }

        public int Radius
        {
            get => radius;
            set
            {
                radius = value;
                AdjustTextBoxLayout();
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public bool UseSystemPasswordChar
        {
            get => useSystemPasswordChar;
            set
            {
                useSystemPasswordChar = value;
                UpdatePasswordChar();
            }
        }

        private void UpdatePasswordChar()
        {
            if (useSystemPasswordChar)
            {
                originalPasswordChar = textBox.PasswordChar;
                textBox.UseSystemPasswordChar = true;
                textBox.PasswordChar = '\0'; // Reset PasswordChar to default
            }
            else
            {
                textBox.UseSystemPasswordChar = false;
                textBox.PasswordChar = originalPasswordChar;
            }
        }

        private void AdjustTextBoxLayout()
        {
            textBox.Location = new Point(borderThickness + radius, (Height / 2) - (textBox.Font.Height / 2));
            textBox.Width = Width - (2 * borderThickness) - (2 * radius);
            textBox.Height = Height - (2 * borderThickness); // Ensure the textbox fits within the control
        }


        public RoundedTextBox()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            this.textBox.Parent = this;
            base.Controls.Add(this.textBox);
            this.textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Poppins", 10.2f, FontStyle.Regular); // Set Montserrat font
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.backgroundColor = Color.White;
            textBox.BackColor = this.backgroundColor;
            this.Text = null;
            this.Font = new Font("Poppins", 10.2f, FontStyle.Regular); // Set Montserrat font
            base.Size = new Size(135, 33);
            this.DoubleBuffered = true;
            textBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            textBox.TextChanged += new EventHandler(textBox_TextChanged);
            textBox.MouseDoubleClick += new MouseEventHandler(textBox_MouseDoubleClick);
            textBox.Width = Width - (2 * borderThickness) - (2 * radius);
            AdjustTextBoxLayout();
        }

        private void textBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textBox.SelectAll();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox.Text;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                textBox.SelectionStart = 0;
                textBox.SelectionLength = this.Text.Length;
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            textBox.Font = new Font("Poppins", 10.2f, FontStyle.Regular); // Set Poppins font
            base.Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            textBox.ForeColor = this.ForeColor;
            base.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.shape = new MyRectangle((float)base.Width, (float)base.Height, (float)this.radius, 0f, 0f).Path;

            // Calculate the inner rectangle with border thickness
            float innerRectX = borderThickness / 2f;
            float innerRectY = borderThickness / 2f;
            float innerRectWidth = base.Width - borderThickness;
            float innerRectHeight = base.Height - borderThickness;

            this.innerRect = new MyRectangle(innerRectWidth, innerRectHeight, (float)this.radius, innerRectX, innerRectY).Path;

            if (textBox.Height >= (base.Height - 4))
            {
                base.Height = textBox.Height + 4;
            }

            textBox.Location = new Point(borderThickness + this.radius - 5, (base.Height / 2) - (textBox.Font.Height / 2));
            textBox.Width = base.Width - (2 * borderThickness) - (2 * this.radius);
            e.Graphics.SmoothingMode = ((SmoothingMode)SmoothingMode.AntiAlias);

            using (Pen borderPen = new Pen(BorderColor, BorderThickness))
            using (SolidBrush brush = new SolidBrush(this.backgroundColor))
            {
                e.Graphics.DrawPath(borderPen, this.shape);
                e.Graphics.FillPath(brush, this.innerRect);
            }

            Trans.MakeTransparent(this, e.Graphics);
            base.OnPaint(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            textBox.Text = this.Text;
        }

        public void SelectAll()
        {
            textBox.SelectAll();
        }

        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                textBox.BackColor = backgroundColor;
                Invalidate();
            }
        }

        public Color Br
        {
            get => this.backgroundColor;
            set
            {
                this.backgroundColor = value;
                if (this.backgroundColor != Color.Transparent)
                {
                    textBox.BackColor = this.backgroundColor;
                }
                base.Invalidate();
            }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = Color.Transparent;
        }
    }

    internal class MyRectangle
    {
        private Point location;
        private float radius;
        private GraphicsPath grPath;
        private float x;
        private float y;
        private float width;
        private float height;

        public MyRectangle()
        {

        }
        public MyRectangle(float width, float height, float radius, float x = 0f, float y = 0f)
        {
            this.location = new Point(0, 0);
            this.radius = radius;
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.grPath = new GraphicsPath();
            if (radius <= 0f)
            {
                this.grPath.AddRectangle(new RectangleF(x, y, width, height));
            }
            else
            {
                RectangleF ef = new RectangleF(x, y, 2f * radius, 2f * radius);
                RectangleF ef2 = new RectangleF((width - (2f * radius)) - 1f, x, 2f * radius, 2f * radius);
                RectangleF ef3 = new RectangleF(x, (height - (2f * radius)) - 1f, 2f * radius, 2f * radius);
                RectangleF ef4 = new RectangleF((width - (2f * radius)) - 1f, (height - (2f * radius)) - 1f, 2f * radius, 2f * radius);
                this.grPath.AddArc(ef, 180f, 90f);
                this.grPath.AddArc(ef2, 270f, 90f);
                this.grPath.AddArc(ef4, 0f, 90f);
                this.grPath.AddArc(ef3, 90f, 90f);
                this.grPath.CloseAllFigures();
            }
        }

        public GraphicsPath Path =>
            this.grPath;

        public RectangleF Rect =>
            new RectangleF(this.x, this.y, this.width, this.height);
        public float Radius
        {
            get =>
                this.radius;
            set =>
                this.radius = value;
        }
    }

    internal class Trans
    {
        public static void MakeTransparent(Control control, Graphics g)
        {
            Control parent = control.Parent;
            if (parent != null)
            {
                Rectangle rectangle = control.Bounds;
                Control.ControlCollection controls = parent.Controls;
                int index = controls.IndexOf(control);
                Bitmap bitmap = null;
                for (int i = controls.Count - 1; i > index; i--)
                {
                    Control control3 = controls[i];
                    if (control3.Bounds.IntersectsWith(rectangle))
                    {
                        if (bitmap == null)
                        {
                            bitmap = new Bitmap(control.Parent.ClientSize.Width, control.Parent.ClientSize.Height);
                        }
                        control3.DrawToBitmap(bitmap, control3.Bounds);
                    }
                }
                if (bitmap != null)
                {
                    g.DrawImage((Image)bitmap, control.ClientRectangle, rectangle, (GraphicsUnit)GraphicsUnit.Pixel);
                    bitmap.Dispose();
                }
            }
        }
    }
}
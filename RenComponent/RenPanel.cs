using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RenComponent
{
    public class RenPanel : Panel
    {
        private int borderRadius = 0;
        private float gradientAngle = 90f;
        private Color gradientTopColor = Color.Transparent;
        private Color gradientBottomColor = Color.Transparent;
        private int borderSize = 0;
        private Color borderColor = Color.PaleVioletRed;

        // Constructor
        public RenPanel()
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.MediumSlateBlue; // Set default background to MediumSlateBlue
            this.DoubleBuffered = true; // Enable double buffering for smoother rendering
            this.Size = new Size(200, 100); // Set a default size
        }

        // Properties to set border radius and gradient colors
        [Category("Ren Control")]
        [Description("Border radius for rounded corners. Set to 0 for no rounding.")]
        public int BorderRadius { 
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
            }
        
        [Category("Ren Control")]
        [Description("Angle of the gradient background in degrees.")]        
        public float GradientAngle { 
            get => gradientAngle;
            set { gradientAngle = value; this.Invalidate(); }
            }
        
        [Category("Ren Control")]
        [Description("Top color of the gradient background.")]        
        public Color GradientTopColor { 
            get => gradientTopColor; 
            set
            {
                gradientTopColor = value;
                if (gradientTopColor != gradientBottomColor)
                    this.BackColor = Color.Transparent;
                this.Invalidate();
            }
        }
        
        [Category("Ren Control")]
        [Description("Bottom color of the gradient background.")]
        public Color GradientBottomColor { 
            get => gradientBottomColor;
            set
            {
                gradientBottomColor = value;
                if (gradientTopColor != gradientBottomColor)
                    this.BackColor = Color.Transparent;
                this.Invalidate();
            }
        }

        [Category("Ren Control")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate(); //Redraw the control
            }
        }

        [Category("Ren Control")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate(); //Redraw the control
            }
        }

        // Methode
        private GraphicsPath GetRenPath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        // Override the OnPaint method to draw the panel with rounded corners and gradient background
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBottomColor, this.GradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            Rectangle rectBorder = Rectangle.Inflate(this.ClientRectangle, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetRenPath(rectangleF, borderRadius))
                using (GraphicsPath pathBorder = GetRenPath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(penSurface, path);
                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectangleF);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
    }
}

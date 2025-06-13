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
            set { gradientTopColor = value; this.Invalidate(); }
        }
        [Category("Ren Control")]
        [Description("Bottom color of the gradient background.")]
        public Color GradientBottomColor { 
            get => gradientBottomColor;
            set { gradientBottomColor = value; this.Invalidate(); }
            }

        // Methode
        private GraphicsPath GetRenPath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            //if (radius <= 0)
            //    path.AddRectangle(rectangle);
            //else
            //{
            //    path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            //    path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            //    path.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90);
            //    path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90);
            //    path.CloseFigure();
            //}
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
            if (borderRadius > 2)
            {
                using(GraphicsPath path = GetRenPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else  this.Region = new Region(rectangleF);
        }


        
    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RenComponent
{
    [ToolboxItem(true)]
    [Category("RenComponent")]
    public class RenCircularProgressBar : UserControl
    {
        private float valueSize = 40;
        private int borderSize = 10;
        private Color middleCircleColor = Color.PaleVioletRed;
        private Color backCircleColor = Color.LavenderBlush;
        private Color outerCircleColor = Color.Transparent;

        public RenCircularProgressBar()
        {
            this.DoubleBuffered = true; // Enable double buffering to reduce flickering
            this.Size = new Size(100, 100); // Default size
        }

        #region Properties
        [Category("Ren Control")]
        [DefaultValue(0)]
        [Description("Specifies the percentage value displayed by the circular progress bar (range: 0 to 100).")]
        public float ValueSize
        {
            get => valueSize;
            set { valueSize = (value > 100) ? 100 : value; this.Invalidate(); }
        }

        [Category("Ren Control")]
        [DefaultValue(10)]
        [Description("Specifies the thickness (in pixels) of the outer progress ring. Maximum value: 20.")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = (value > 20) ? 20 : value; this.Invalidate(); }
        }

        [Category("Ren Control")]
        [Description("Sets the color of the filled portion of the progress ring, based on the current value.")]
        public Color MiddleCircleColor
        {
            get => middleCircleColor;
            set { middleCircleColor = ForeColor = value; this.Invalidate(); }
        }

        [Category("Ren Control")]
        [Description("Sets the color of the unfilled (remaining) portion of the progress ring.")]
        public Color UnfilledCircleColor
        {
            get => backCircleColor;
            set { backCircleColor = value; this.Invalidate(); }
        }

        [Category("Ren Control")]
        [Description("Sets the color of the inner (central) circle inside the circular progress bar.")]
        public Color OuterCircleColor
        {
            get => outerCircleColor;
            set { outerCircleColor = value; this.Invalidate(); }
        }

        #endregion

        #region Overridden Method
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen backPen = new Pen(backCircleColor, borderSize - 1);
            Pen pen = new Pen(middleCircleColor, borderSize) { StartCap = LineCap.Round, EndCap = LineCap.Round};
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            graphics.FillPie(new SolidBrush(outerCircleColor), new Rectangle(10, 10, Width - 20, Height - 20), 0, 360);
            graphics.DrawArc(backPen, new Rectangle(10, 10, Width - 20, Height - 20), -90, 360);
            graphics.DrawArc(pen, new Rectangle(10, 10, Width - 20, Height - 20), -90, (valueSize / 100) * 360);

            StringFormat stringFormat = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center};
            graphics.DrawString(valueSize + "%", Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);

            base.OnPaint(e);
            
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Height = Width;
            base.OnSizeChanged(e);
        }
        #endregion
    }
}

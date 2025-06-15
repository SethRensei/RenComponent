using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RenComponent
{
    public class RenEllipse : Component, IExtenderProvider
    {
        private Control _target;
        private EventHandler _resizeHandler;

        private int _cornerRadius = 5;
        private int _cornerTopLeft = 5;
        private int _cornerTopRight = 5;
        private int _cornerBottomRight = 5;
        private int _cornerBottomLeft = 5;

        private bool useUnifiedRadius = true;

        [Category("Ren Control")]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Unified corner radius for all corners. If set, overrides individual corner settings.")]
        [DefaultValue(5)]
        public int AllCornerRadius
        {
            get => useUnifiedRadius ? _cornerRadius : 0;
            set
            {
                int newVal = Math.Max(0, value);
                if (_cornerRadius == newVal && useUnifiedRadius) return;

                useUnifiedRadius = true;
                _cornerRadius = newVal;

                _cornerTopLeft = _cornerTopRight = _cornerBottomRight = _cornerBottomLeft = newVal;

                OnRadiusChanged();
            }
        }

        [Category("Ren Control")]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Individual corner radius for the top-left corner. If set, overrides unified radius.")]
        [DefaultValue(5)]
        public int TopLeft
        {
            get => _cornerTopLeft;
            set => SetIndividualCorner(ref _cornerTopLeft, value);
        }

        [Category("Ren Control")]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Individual corner radius for the top-right corner. If set, overrides unified radius.")]
        [DefaultValue(5)]
        public int TopRight
        {
            get => _cornerTopRight;
            set => SetIndividualCorner(ref _cornerTopRight, value);
        }

        [Category("Ren Control")]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Individual corner radius for the bottom-right corner. If set, overrides unified radius.")]
        [DefaultValue(5)]
        public int BottomRight
        {
            get => _cornerBottomRight;
            set => SetIndividualCorner(ref _cornerBottomRight, value);
        }

        [Category("Ren Control")]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Individual corner radius for the bottom-left corner. If set, overrides unified radius.")]
        [DefaultValue(5)]
        public int BottomLeft
        {
            get => _cornerBottomLeft;
            set => SetIndividualCorner(ref _cornerBottomLeft, value);
        }

        private void SetIndividualCorner(ref int cornerField, int value)
        {
            int newVal = Math.Max(0, value);
            if (cornerField == newVal) return;
            cornerField = newVal;
            // if any individual differs, disable unified radius
            if (!(_cornerTopLeft == _cornerTopRight &&
                  _cornerTopLeft == _cornerBottomRight &&
                  _cornerTopLeft == _cornerBottomLeft))
            {
                useUnifiedRadius = true;
                _cornerRadius = _cornerTopLeft;
            }
            else useUnifiedRadius = false;

            OnRadiusChanged();
        }

        private void OnRadiusChanged()
        {
            if (_target != null) ApplyRoundedRegion();
        }

        public bool CanExtend(object extendee) => extendee is Control;

        public void SetCornerRadius(Control ctrl, int radius)
        {
            AllCornerRadius = radius;
            TargetControl = ctrl;
        }
        public int GetCornerRadius(Control ctrl) => AllCornerRadius;

        [Category("Behavior")]
        [Description("The control to apply the rounded corners to.")]
        public Control TargetControl
        {
            get => _target;
            set
            {
                if (_target != null)
                {
                    _target.SizeChanged -= _resizeHandler;
                    _target.Region?.Dispose();
                }
                _target = value;
                if (_target != null)
                {
                    _resizeHandler = (s, e) => ApplyRoundedRegion();
                    _target.SizeChanged += _resizeHandler;
                    ApplyRoundedRegion();
                }
            }
        }

        private void ApplyRoundedRegion()
        {
            _target.Region?.Dispose();

            int tl = _cornerTopLeft;
            int tr = _cornerTopRight;
            int br = _cornerBottomRight;
            int bl = _cornerBottomLeft;
            int w = _target.Width;
            int h = _target.Height;

            using (var path = new GraphicsPath())
            {
                // Start top-left
                path.StartFigure();

                // Top edge
                path.AddArc(0, 0, tl * 2, tl * 2, 180, 90);
                path.AddLine(tl, 0, w - tr, 0);

                // Top-right
                path.AddArc(w - tr * 2, 0, tr * 2, tr * 2, 270, 90);
                path.AddLine(w, tr, w, h - br);

                // Bottom-right
                path.AddArc(w - br * 2, h - br * 2, br * 2, br * 2, 0, 90);
                path.AddLine(w - br, h, bl, h);

                // Bottom-left
                path.AddArc(0, h - bl * 2, bl * 2, bl * 2, 90, 90);
                path.CloseFigure();

                _target.Region = new Region(path);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _target != null)
            {
                _target.SizeChanged -= _resizeHandler;
                _target.Region?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

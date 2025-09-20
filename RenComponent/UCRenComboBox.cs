using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RenComponent
{
    [ToolboxItem(true)]
    [Category("RenComponent")]
    public partial class UCRenComboBox : UserControl
    {
        // Événement déclenché lors du changement de sélection
        [Category("Ren Control")]
        public event EventHandler SelectedIndexChanged;

        int i = 0;
        private int listHeight = 229; // Height of the dropdown list
        private string _displayMember;
        private string _valueMember;
        private IEnumerable _dataSource;
        public string[] Data;
        
        public UCRenComboBox()
        {
            InitializeComponent();
        }


        [Category("Ren Control")]
        public int DropdownHeight
        {
            get => listHeight;
            set
            {
                listHeight = value;
                pnlItem.Height = listHeight;
                this.Invalidate(); //Redraw the control
            }
        }

        [Category("Ren Control")]
        public string Title
        {
            get => lblTitle.Text;
            set
            {
                lblTitle.Text = value;
                this.Invalidate(); //Redraw the control
            }
        }

        [Category("Ren Control")]
        public int Radius
        {
            get => pnlTitle.BorderRadius;
            set
            {
                pnlTitle.BorderRadius = value;
                this.Invalidate(); //Redraw the control
            }
        }

        [Category("Ren Control")]
        public Image Icon
        {
            get => iconComboBox.Image;
            set
            {
                iconComboBox.Image = value;
                this.Invalidate(); //Redraw the control
            }
        }

        [Category("Ren Control")]
        public Color TitleColor
        {
            get => lblTitle.ForeColor;
            set
            {
                lblTitle.ForeColor = value;
                this.Invalidate(); //Redraw the control
            }
        }

        [Category("Ren Control")]
        public Font TitleFont
        {
            get => lblTitle.Font;
            set
            {
                lblTitle.Font = value;
                this.Invalidate(); //Redraw the control
            }
        }

        [Category("Ren Control")]
        [Description("Top color of the comboBox's background.")]
        public Color BackgroundColor
        {
            get => this.pnlTitle.BackColor;
            set
            {
                this.pnlTitle.BackColor = value;
                this.pnlTitle.GradientTopColor = Color.Transparent;
                this.pnlTitle.GradientBottomColor = Color.Transparent;
                this.Invalidate(); //Redraw the control
            }
        }

        [Category("Ren Control")]
        [Description("Top color of the comboBox's gradient background.")]
        public Color CmbBoxGradientTopColor
        {
            get => pnlTitle.GradientTopColor;
            set
            {
                pnlTitle.GradientTopColor = value;
                if (pnlTitle.GradientTopColor != pnlTitle.GradientBottomColor)
                    this.pnlTitle.BackColor = Color.Transparent; // If gradient is set, keep it transparent
                this.Invalidate();
            }
        }

        [Category("Ren Control")]
        [Description("Bottom color of the comboBox's gradient background.")]
        public Color CmbBoxGradientBottomColor
        {
            get => pnlTitle.GradientBottomColor;
            set
            {
                pnlTitle.GradientBottomColor = value;
                if (pnlTitle.GradientTopColor != pnlTitle.GradientBottomColor)
                    this.pnlTitle.BackColor = Color.Transparent; // If gradient is set, keep it transparent
                this.Invalidate();
            }
        }

        [Category("Ren Control")]
        [Description("Angle of the gradient background in degrees.")]
        public float GradientAngle
        {
            get => pnlTitle.GradientAngle;
            set { pnlTitle.GradientAngle = value; this.Invalidate(); }
        }

        [Category("Ren Control")]
        public Color BarColor
        {
            get => lblBar.BackColor;
            set
            {
                lblBar.BackColor = value;
                this.Invalidate(); //Redraw the control
            }
        }

        [Category("Ren Co - Data")]
        public IEnumerable DataSource
        {
            get => _dataSource;
            set
            {
                _dataSource = value;
                UpdateItems();
            }
        }

        [Category("Ren Co - Data")]
        public string DisplayMember
        {
            get => _displayMember;
            set
            {
                _displayMember = value;
                UpdateItems();
            }
        }

        [Category("Ren Co - Data")]
        public string ValueMember
        {
            get => _valueMember;
            set => _valueMember = value;
        }

        [Category("Ren Co - Data")]
        public string[] Items
        {
            get => Data;
            set
            {
                // Sécurité contre null
                flpItem.Controls.Clear();

                if (value == null || value.Length == 0)
                {
                    Data = Array.Empty<string>();
                    return;
                }

                foreach (var item in value)
                {
                    Label label = new Label();
                    label.Text = item;
                    label.ForeColor = Color.White;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Height = 25;
                    label.Width = flpItem.Width - 25;

                    label.MouseClick += new MouseEventHandler(Label_Selected);
                    flpItem.Controls.Add(label);
                }
                Data = value;
                this.Invalidate();
            }
        }

        // Event Handlers
        private void Label_Selected(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            foreach (var item in flpItem.Controls.OfType<Label>())
                item.BackColor = Color.FromArgb(30, 32, 34);

            label.BackColor = Color.FromArgb(46, 239, 221);
            txtComboBox.Text = label.Text;

            // Notifier l'événement
            SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
            i = 0;
            TimerItem2.Start();
        }

        // méthode qui reconstruit les labels
        private void UpdateItems()
        {
            flpItem.Controls.Clear();
            if (_dataSource == null || string.IsNullOrEmpty(_displayMember))
                return;

            foreach (var item in _dataSource)
            {
                // réflexion sur la propriété DisplayMember
                var prop = item.GetType().GetProperty(_displayMember);
                var displayText = prop?.GetValue(item, null)?.ToString() ?? string.Empty;

                var label = new Label
                {
                    Text = displayText,
                    ForeColor = this.ForeColor,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Height = 25,
                    Width = flpItem.Width - 25,
                    Tag = item  // on garde l'objet complet pour ValueMember
                };
                label.MouseClick += Label_Selected;
                flpItem.Controls.Add(label);
            }

            this.Invalidate();
        }

        // pour récupérer SelectedValue
        [Browsable(false)]
        public object SelectedValue
        {
            get
            {
                var selectedLabel = flpItem.Controls
                    .OfType<Label>()
                    .FirstOrDefault(l =>
                        l.BackColor == Color.FromArgb(46, 239, 221)  // ou ton critère
                    );
                if (selectedLabel == null || string.IsNullOrEmpty(_valueMember))
                    return null;

                var item = selectedLabel.Tag;
                return item.GetType()
                           .GetProperty(_valueMember)?
                           .GetValue(item, null);
            }
        }

        [Browsable(false)]
        public string SelectedItem
        {
            get => txtComboBox.Text;
        }

        private void PicComboBox_Click(object sender, System.EventArgs e)
        {
            i = 0;
            if (Height <= 60) TimerItem.Start();
            else TimerItem2.Start();
        }

        private void TimerItem_Tick(object sender, System.EventArgs e)
        {
            picComboBox.Image = Properties.Resources.Up;
            if (Height < 269)
            {
                Height = Height + i;
                i++;
            }
            else TimerItem.Stop();
            pnlItem.BorderRadius = 30;
        }

        private void TimerItem2_Tick(object sender, System.EventArgs e)
        {
            picComboBox.Image = Properties.Resources.Down;
            if (Height > 61)
            {
                Height = Height - i;
                i++;
            }
            else TimerItem2.Stop();
            pnlItem.BorderRadius = 30;
        }
    }
}

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RenComponent
{
    [ToolboxItem(true)]
    [DefaultProperty("Grid")]
    [DefaultEvent("Load")]
    public partial class PaginatedDataGridView : UserControl
    {
        private DataTable originalData;
        private int currentPage = 1;
        private int totalPages = 1;
        private int pageSize = 10;
        private Size btnSize = new Size(40, 35);
        private Color btnBackColor = Color.MediumSlateBlue;
        private Color btnForeColor = Color.White;
        private Font btnFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        private int btnTop = 3, infoTop = 15;


        private DataGridView dataGridView1;
        private Panel panelPagination;
        private Button btnFirst, btnPrev, btnNext, btnLast;
        private Label lblPageInfo;

        public PaginatedDataGridView()
        {
            InitializeComponent();
            SetupLayout();
        }

        #region Properties

        [Category("Ren Control")]
        [DefaultValue(10)]
        [Description("Number of rows per page.")]
        public int PageSize
        {
            get => pageSize;
            set { pageSize = value > 0 ? value : 10; RefreshPagination(); }
        }

        [Browsable(false)]
        public int CurrentPage
        {
            get => currentPage;
            private set => currentPage = value;
        }

        [Browsable(false)]
        public int TotalPages
        {
            get => totalPages;
            private set => totalPages = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Category("Ren Control")]
        [Description("Internal DataGridView you can fully customize.")]
        public DataGridView DataGrid => dataGridView1;

        

        [Category("Ren Control")]
        [Description("Size of pagination buttons.")]
        public Size ButtonSize
        {
            get => btnSize;
            set
            {
                btnSize = value;
                foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
                {
                    btn.Size = btnSize;
                }
            }
        }

        [Category("Ren Control")]
        [Description("Background color of pagination buttons.")]
        public Color ButtonBackColor
        {
            get => btnBackColor;
            set
            {
                btnBackColor = value;
                foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
                {
                    btn.BackColor = btnBackColor;
                }
            }
        }

        [Category("Ren Control")]
        [Description("Foreground color of pagination buttons.")]
        public Color ButtonForeColor
        {
            get => btnForeColor;
            set
            {
                btnForeColor = value;
                foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
                {
                    btn.ForeColor = btnForeColor;
                }
            }
        }

        [Category("Ren Control")]
        [Description("Font of pagination buttons.")]
        public Font ButtonFont
        {
            get => btnFont;
            set
            {
                btnFont = value;
                foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
                {
                    btn.Font = btnFont;
                }
            }
        }

        [Category("Ren Control")]
        [Description("Top position of pagination buttons.")]
        public int ButtonTop
        {
            get => btnTop;
            set
            {
                btnTop = value;
                foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
                {
                    btn.Top = btnTop;
                }
            }
        }

        [Category("Ren Control")]
        [Description("Top position of page info label.")]
        public int PageInfoTop
        {
            get => infoTop;
            set
            {
                infoTop = value;
                lblPageInfo.Top = infoTop;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Assign a DataTable as source.
        /// </summary>
        public void SetData(DataTable table)
        {
            originalData = table;
            CurrentPage = 1;
            RefreshPagination();
        }

        /// <summary>
        /// Applique un style global à tous les boutons de pagination.
        /// </summary>
        [Category("Ren Control")]
        [Description("Applique le style global à tous les boutons de pagination.")]
        public void ApplyStyleToAllButtons(Color backColor, Color foreColor)
        {
            foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
            {
                btn.BackColor = backColor;
                btn.ForeColor = foreColor;
                btn.UseVisualStyleBackColor = false;
            }
        }

        #endregion

        #region Private Methods

        private void SetupLayout()
        {
            // DataGridView
            dataGridView1 = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                BackgroundColor = BackColor,
                AllowUserToDeleteRows = false,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                ReadOnly = false
            };

            // Panel pagination
            panelPagination = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 45,
                BackColor = Color.Transparent
            };

            // Création des boutons
            btnFirst = CreateRenButton("<<", 5);
            btnPrev = CreateRenButton("◀", 50);
            btnNext = CreateRenButton("▶", 95);
            btnLast = CreateRenButton(">>", 140);

            // Label info
            lblPageInfo = new Label
            {
                AutoSize = true,
                Left = 180,
                Top = infoTop,
                Font = Font,
                ForeColor = ForeColor,
                Text = "Page 0 / 0",
                Margin = new Padding(10, 0, 10, 0)
            };

            // Gestion clics
            btnFirst.Click += (s, e) => { CurrentPage = 1; RefreshPagination(); };
            btnPrev.Click += (s, e) => { if (CurrentPage > 1) CurrentPage--; RefreshPagination(); };
            btnNext.Click += (s, e) => { if (CurrentPage < TotalPages) CurrentPage++; RefreshPagination(); };
            btnLast.Click += (s, e) => { CurrentPage = TotalPages; RefreshPagination(); };

            // Ajout des contrôles
            panelPagination.Controls.Add(btnFirst);
            panelPagination.Controls.Add(btnPrev);
            panelPagination.Controls.Add(btnNext);
            panelPagination.Controls.Add(btnLast);
            panelPagination.Controls.Add(lblPageInfo);

            //panelPagination.Controls.Add(tableLayout);

            Controls.Add(dataGridView1);
            Controls.Add(panelPagination);
        }

        private Button CreateRenButton(string text, int letf)
        {
            var btn = new Button
            {
                Text = text,
                Size = btnSize,
                Top = 3,
                Left = letf,
                Font = btnFont,
                BackColor = btnBackColor,
                FlatStyle = FlatStyle.Flat,
                UseVisualStyleBackColor = false
            };

            btn.FlatAppearance.BorderSize = 0;

            ApplyDefaultStyle(btn);
            return btn;
        }

        private void ApplyDefaultStyle(Button btn)
        {
            btn.BackColor = Color.MediumSlateBlue;
            btn.ForeColor = Color.White;
        }

        private void RefreshPagination()
        {
            if (originalData == null || originalData.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
                lblPageInfo.Text = "Page 0 / 0";
                return;
            }

            int totalRows = originalData.Rows.Count;
            TotalPages = (int)Math.Ceiling(totalRows / (double)PageSize);

            var pageRows = originalData.AsEnumerable()
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize);

            if (pageRows.Any())
                dataGridView1.DataSource = pageRows.CopyToDataTable();
            else
                dataGridView1.DataSource = originalData.Clone();

            lblPageInfo.Text = $"Page {CurrentPage} / {TotalPages}";
        }

        #endregion

        #region -> Events
        private void PaginatedDataGridView_BackColorChanged(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = BackColor;
        }

        private void PaginatedDataGridView_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColorChanged += DGVBackColorChanged;
            FontChanged += PDGVFontChanged;
            ForeColorChanged += PDGVForeChanged;
        }

        private void DGVBackColorChanged(object sender, EventArgs e)
        {
            BackColor = dataGridView1.BackgroundColor;
        }

        private void PDGVFontChanged(object sender, EventArgs e)
        {
            lblPageInfo.Font = Font;
            panelPagination.Height = 45;
            foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
            {
                btn.Font = Font;
                btn.Size = btnSize;
            }
        }

        private void PDGVForeChanged(object sender, EventArgs e)
        {
            lblPageInfo.ForeColor = ForeColor;
        }
    #endregion
}
}

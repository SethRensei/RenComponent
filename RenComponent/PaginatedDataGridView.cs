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

        private Size btnSize = new Size(35, 35);
        private Color btnBackColor = Color.MediumSlateBlue;
        private Color btnForeColor = Color.White, btnBoderColor = Color.MediumSlateBlue;
        private Font btnFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        private int btnBorderRadius = 0, btnBorderSize = 0;

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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Category("Ren Control")]
        [Description("Color of page info.")]
        public Color PageInfoForeColor
        {
            get => lblPageInfo.ForeColor;
            set => lblPageInfo.ForeColor = value;
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Category("Ren Control")]
        [Description("Color of page info.")]
        public Font PageInfoFont
        {
            get => lblPageInfo.Font;
            set => lblPageInfo.Font = value;
        }


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
        [Description("Border radius of pagination buttons.")]
        public int ButtonBorderRadius
        {
            get => btnBorderRadius;
            set
            {
                btnBorderRadius = value;
                foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
                {
                    btn.BorderRadius = value;
                }
            }
        }

        [Category("Ren Control")]
        [Description("Border size of pagination buttons.")]
        public int ButtonBorderSize
        {
            get => btnBorderSize;
            set
            {
                btnBorderSize = value;
                foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
                {
                    btn.BorderSize = value;
                }
            }
        }

        [Category("Ren Control")]
        [Description("Border color of pagination buttons.")]
        public Color ButtonBorderColor
        {
            get => btnBoderColor;
            set
            {
                btnBoderColor = value;
                foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
                {
                    btn.BorderColor = value;
                }
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
            dataGridView1.BackgroundColor = BackColor;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ColumnHeadersHeight = 35;


            // Gestion clics
            btnFirst.Click += (s, e) => { CurrentPage = 1; RefreshPagination(); };
            btnPrev.Click += (s, e) => { if (CurrentPage > 1) CurrentPage--; RefreshPagination(); };
            btnNext.Click += (s, e) => { if (CurrentPage < TotalPages) CurrentPage++; RefreshPagination(); };
            btnLast.Click += (s, e) => { CurrentPage = TotalPages; RefreshPagination(); };
            
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
            foreach (var btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
            {
                btn.Font = btnFont;
                btn.Size = new Size(35, 35);
            }
        }

        private void PDGVForeChanged(object sender, EventArgs e)
        {
            lblPageInfo.ForeColor = ForeColor;
        }
    #endregion
}
}

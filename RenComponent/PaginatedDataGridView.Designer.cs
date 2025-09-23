namespace RenComponent
{
    partial class PaginatedDataGridView
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnLast = new RenComponent.RenButton();
            this.btnNext = new RenComponent.RenButton();
            this.btnPrev = new RenComponent.RenButton();
            this.btnFirst = new RenComponent.RenButton();
            this.pnlPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPagination
            // 
            this.pnlPagination.Controls.Add(this.lblPageInfo);
            this.pnlPagination.Controls.Add(this.panel1);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Location = new System.Drawing.Point(0, 155);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(510, 50);
            this.pnlPagination.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(510, 155);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageInfo.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.lblPageInfo.ForeColor = System.Drawing.Color.White;
            this.lblPageInfo.Location = new System.Drawing.Point(188, 0);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(322, 50);
            this.lblPageInfo.TabIndex = 1;
            this.lblPageInfo.Text = "Page 0 / 0";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLast.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLast.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLast.BorderRadius = 0;
            this.btnLast.BorderSize = 0;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(141, 7);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(35, 35);
            this.btnLast.TabIndex = 0;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNext.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 0;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(95, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrev.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrev.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrev.BorderRadius = 0;
            this.btnPrev.BorderSize = 0;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(50, 7);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(35, 35);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "◀";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFirst.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFirst.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFirst.BorderRadius = 0;
            this.btnFirst.BorderSize = 0;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(6, 7);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(35, 35);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // PaginatedDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlPagination);
            this.Name = "PaginatedDataGridView";
            this.Size = new System.Drawing.Size(510, 205);
            this.Load += new System.EventHandler(this.PaginatedDataGridView_Load);
            this.BackColorChanged += new System.EventHandler(this.PaginatedDataGridView_BackColorChanged);
            this.pnlPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Panel panel1;
        private RenButton btnLast;
        private RenButton btnNext;
        private RenButton btnPrev;
        private RenButton btnFirst;
    }
}

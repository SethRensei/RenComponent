namespace RenComponent
{
    partial class UCRenComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRenComboBox));
            this.TimerItem = new System.Windows.Forms.Timer();
            this.TimerItem2 = new System.Windows.Forms.Timer();
            this.pnlItem = new RenComponent.RenPanel();
            this.flpItem = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitle = new RenComponent.RenPanel();
            this.lblBar = new System.Windows.Forms.Label();
            this.txtComboBox = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconComboBox = new System.Windows.Forms.PictureBox();
            this.picComboBox = new System.Windows.Forms.PictureBox();
            this.pnlItem.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerItem
            // 
            this.TimerItem.Interval = 1;
            this.TimerItem.Tick += new System.EventHandler(this.TimerItem_Tick);
            // 
            // TimerItem2
            // 
            this.TimerItem2.Interval = 1;
            this.TimerItem2.Tick += new System.EventHandler(this.TimerItem2_Tick);
            // 
            // pnlItem
            // 
            this.pnlItem.BackColor = System.Drawing.Color.Transparent;
            this.pnlItem.BorderColor = System.Drawing.Color.Transparent;
            this.pnlItem.BorderRadius = 30;
            this.pnlItem.BorderSize = 0;
            this.pnlItem.Controls.Add(this.flpItem);
            this.pnlItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.pnlItem.ForeColor = System.Drawing.Color.White;
            this.pnlItem.GradientAngle = 90F;
            this.pnlItem.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.pnlItem.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.pnlItem.Location = new System.Drawing.Point(0, 60);
            this.pnlItem.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Padding = new System.Windows.Forms.Padding(5);
            this.pnlItem.Size = new System.Drawing.Size(300, 229);
            this.pnlItem.TabIndex = 1;
            // 
            // flpItem
            // 
            this.flpItem.AutoScroll = true;
            this.flpItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItem.Location = new System.Drawing.Point(5, 5);
            this.flpItem.Margin = new System.Windows.Forms.Padding(0);
            this.flpItem.Name = "flpItem";
            this.flpItem.Size = new System.Drawing.Size(290, 219);
            this.flpItem.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.pnlTitle.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BorderRadius = 60;
            this.pnlTitle.BorderSize = 0;
            this.pnlTitle.Controls.Add(this.lblBar);
            this.pnlTitle.Controls.Add(this.txtComboBox);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.iconComboBox);
            this.pnlTitle.Controls.Add(this.picComboBox);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.GradientAngle = 90F;
            this.pnlTitle.GradientBottomColor = System.Drawing.Color.Transparent;
            this.pnlTitle.GradientTopColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(300, 60);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblBar
            // 
            this.lblBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(239)))), ((int)(((byte)(221)))));
            this.lblBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(239)))), ((int)(((byte)(221)))));
            this.lblBar.Location = new System.Drawing.Point(51, 51);
            this.lblBar.Margin = new System.Windows.Forms.Padding(0);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(210, 4);
            this.lblBar.TabIndex = 3;
            // 
            // txtComboBox
            // 
            this.txtComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComboBox.ForeColor = System.Drawing.Color.White;
            this.txtComboBox.Location = new System.Drawing.Point(49, 26);
            this.txtComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.txtComboBox.Name = "txtComboBox";
            this.txtComboBox.Size = new System.Drawing.Size(212, 21);
            this.txtComboBox.TabIndex = 2;
            this.txtComboBox.Text = "Choose an Option";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(239)))), ((int)(((byte)(221)))));
            this.lblTitle.Location = new System.Drawing.Point(42, 2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // iconComboBox
            // 
            this.iconComboBox.Image = ((System.Drawing.Image)(resources.GetObject("iconComboBox.Image")));
            this.iconComboBox.Location = new System.Drawing.Point(10, 15);
            this.iconComboBox.Name = "iconComboBox";
            this.iconComboBox.Size = new System.Drawing.Size(30, 30);
            this.iconComboBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconComboBox.TabIndex = 0;
            this.iconComboBox.TabStop = false;
            // 
            // picComboBox
            // 
            this.picComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picComboBox.Image = global::RenComponent.Properties.Resources.Down;
            this.picComboBox.Location = new System.Drawing.Point(264, 15);
            this.picComboBox.Name = "picComboBox";
            this.picComboBox.Size = new System.Drawing.Size(30, 30);
            this.picComboBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComboBox.TabIndex = 0;
            this.picComboBox.TabStop = false;
            this.picComboBox.Click += new System.EventHandler(this.PicComboBox_Click);
            // 
            // UCRenComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCRenComboBox";
            this.Size = new System.Drawing.Size(300, 368);
            this.pnlItem.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RenPanel pnlTitle;
        private RenPanel pnlItem;
        private System.Windows.Forms.FlowLayoutPanel flpItem;
        private System.Windows.Forms.PictureBox picComboBox;
        private System.Windows.Forms.PictureBox iconComboBox;
        private System.Windows.Forms.Label txtComboBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Timer TimerItem;
        private System.Windows.Forms.Timer TimerItem2;
    }
}

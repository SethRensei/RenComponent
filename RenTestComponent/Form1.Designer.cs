namespace RenTestComponent
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbBoxAnimal = new RenComponent.UCRenComboBox();
            this.renTextBox3 = new RenComponent.RenTextBox();
            this.renTextBox2 = new RenComponent.RenTextBox();
            this.renTextBox1 = new RenComponent.RenTextBox();
            this.renComboBox1 = new RenComponent.RenComboBox();
            this.renDatePicker2 = new RenComponent.RenDatePicker();
            this.renToggleButton2 = new RenComponent.RenToggleButton();
            this.renButton2 = new RenComponent.RenButton();
            this.renRadioButton2 = new RenComponent.RenRadioButton();
            this.renPanel2 = new RenComponent.RenPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.renToggleButton1 = new RenComponent.RenToggleButton();
            this.renRadioButton1 = new RenComponent.RenRadioButton();
            this.renDatePicker1 = new RenComponent.RenDatePicker();
            this.renPanel1 = new RenComponent.RenPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.renButton1 = new RenComponent.RenButton();
            this.renPanel2.SuspendLayout();
            this.renPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoxAnimal
            // 
            this.cmbBoxAnimal.BackColor = System.Drawing.Color.Transparent;
            this.cmbBoxAnimal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.cmbBoxAnimal.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(239)))), ((int)(((byte)(221)))));
            this.cmbBoxAnimal.CmbBoxGradientBottomColor = System.Drawing.Color.Transparent;
            this.cmbBoxAnimal.CmbBoxGradientTopColor = System.Drawing.Color.Transparent;
            this.cmbBoxAnimal.ComboBoxHeight = 60;
            this.cmbBoxAnimal.DataSource = null;
            this.cmbBoxAnimal.DisplayMember = null;
            this.cmbBoxAnimal.DropdownHeight = 100;
            this.cmbBoxAnimal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxAnimal.ForeColor = System.Drawing.Color.White;
            this.cmbBoxAnimal.GradientAngle = 90F;
            this.cmbBoxAnimal.Icon = global::RenTestComponent.Properties.Resources.Animals;
            this.cmbBoxAnimal.Items = new string[] {
        "Basilic vert",
        "Bec-en-sabot du Nil",
        "Belette",
        "Belette d’Europe",
        "Belette pygmée",
        "Bélouga",
        "Béluga",
        "Biche des palétuviers",
        "Bison d’Amérique",
        "Bison d’Amérique du Nord"};
            this.cmbBoxAnimal.Location = new System.Drawing.Point(258, 244);
            this.cmbBoxAnimal.Margin = new System.Windows.Forms.Padding(0);
            this.cmbBoxAnimal.Name = "cmbBoxAnimal";
            this.cmbBoxAnimal.Radius = 60;
            this.cmbBoxAnimal.Size = new System.Drawing.Size(229, 60);
            this.cmbBoxAnimal.TabIndex = 18;
            this.cmbBoxAnimal.Title = "Animals";
            this.cmbBoxAnimal.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(239)))), ((int)(((byte)(221)))));
            this.cmbBoxAnimal.TitleFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.cmbBoxAnimal.ValueMember = null;
            this.cmbBoxAnimal.SelectedIndexChanged += new System.EventHandler(this.CmbBoxAnimal_SelectedIndexChanged);
            // 
            // renTextBox3
            // 
            this.renTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.renTextBox3.BorderColor = System.Drawing.Color.Yellow;
            this.renTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.renTextBox3.BorderRadius = 10;
            this.renTextBox3.BorderSize = 2;
            this.renTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.renTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.renTextBox3.Location = new System.Drawing.Point(258, 52);
            this.renTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.renTextBox3.Multiline = true;
            this.renTextBox3.Name = "renTextBox3";
            this.renTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.renTextBox3.PasswordChar = false;
            this.renTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.renTextBox3.PlaceholderText = "";
            this.renTextBox3.Size = new System.Drawing.Size(229, 144);
            this.renTextBox3.TabIndex = 16;
            this.renTextBox3.Texts = "";
            this.renTextBox3.UnderlinedStyle = false;
            // 
            // renTextBox2
            // 
            this.renTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.renTextBox2.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.renTextBox2.BorderFocusColor = System.Drawing.Color.CornflowerBlue;
            this.renTextBox2.BorderRadius = 9;
            this.renTextBox2.BorderSize = 2;
            this.renTextBox2.Font = new System.Drawing.Font("DejaVu Sans", 10F);
            this.renTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.renTextBox2.Location = new System.Drawing.Point(258, 204);
            this.renTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.renTextBox2.Multiline = false;
            this.renTextBox2.Name = "renTextBox2";
            this.renTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.renTextBox2.PasswordChar = false;
            this.renTextBox2.PlaceholderColor = System.Drawing.Color.Black;
            this.renTextBox2.PlaceholderText = "Your Phone Number";
            this.renTextBox2.Size = new System.Drawing.Size(229, 31);
            this.renTextBox2.TabIndex = 15;
            this.renTextBox2.Texts = "";
            this.renTextBox2.UnderlinedStyle = true;
            this.renTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RenTextBox2_KeyPress);
            // 
            // renTextBox1
            // 
            this.renTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.renTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.renTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.renTextBox1.BorderRadius = 0;
            this.renTextBox1.BorderSize = 2;
            this.renTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.renTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.renTextBox1.Location = new System.Drawing.Point(258, 13);
            this.renTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.renTextBox1.Multiline = false;
            this.renTextBox1.Name = "renTextBox1";
            this.renTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.renTextBox1.PasswordChar = false;
            this.renTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.renTextBox1.PlaceholderText = "";
            this.renTextBox1.Size = new System.Drawing.Size(229, 31);
            this.renTextBox1.TabIndex = 14;
            this.renTextBox1.Texts = "";
            this.renTextBox1.UnderlinedStyle = false;
            // 
            // renComboBox1
            // 
            this.renComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.renComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.renComboBox1.BorderSize = 1;
            this.renComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.renComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.renComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.renComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.renComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.renComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.renComboBox1.Location = new System.Drawing.Point(258, 326);
            this.renComboBox1.Name = "renComboBox1";
            this.renComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.renComboBox1.Size = new System.Drawing.Size(200, 30);
            this.renComboBox1.TabIndex = 13;
            this.renComboBox1.Texts = "";
            // 
            // renDatePicker2
            // 
            this.renDatePicker2.BorderColor = System.Drawing.Color.Black;
            this.renDatePicker2.BorderSize = 2;
            this.renDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.renDatePicker2.Location = new System.Drawing.Point(12, 166);
            this.renDatePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.renDatePicker2.Name = "renDatePicker2";
            this.renDatePicker2.Size = new System.Drawing.Size(200, 35);
            this.renDatePicker2.SkinColor = System.Drawing.Color.Transparent;
            this.renDatePicker2.TabIndex = 11;
            this.renDatePicker2.TextColor = System.Drawing.Color.Black;
            // 
            // renToggleButton2
            // 
            this.renToggleButton2.AutoSize = true;
            this.renToggleButton2.Location = new System.Drawing.Point(12, 275);
            this.renToggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.renToggleButton2.Name = "renToggleButton2";
            this.renToggleButton2.OffBackColor = System.Drawing.Color.Teal;
            this.renToggleButton2.OffToggleColor = System.Drawing.Color.White;
            this.renToggleButton2.OnBackColor = System.Drawing.Color.PaleVioletRed;
            this.renToggleButton2.OnToggleColor = System.Drawing.Color.Black;
            this.renToggleButton2.Size = new System.Drawing.Size(45, 22);
            this.renToggleButton2.TabIndex = 10;
            this.renToggleButton2.UseVisualStyleBackColor = true;
            // 
            // renButton2
            // 
            this.renButton2.BackColor = System.Drawing.Color.Transparent;
            this.renButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.renButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.renButton2.BorderRadius = 10;
            this.renButton2.BorderSize = 2;
            this.renButton2.FlatAppearance.BorderSize = 0;
            this.renButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renButton2.ForeColor = System.Drawing.Color.Black;
            this.renButton2.Location = new System.Drawing.Point(12, 68);
            this.renButton2.Name = "renButton2";
            this.renButton2.Size = new System.Drawing.Size(150, 40);
            this.renButton2.TabIndex = 9;
            this.renButton2.Text = "renButton2";
            this.renButton2.TextColor = System.Drawing.Color.Black;
            this.renButton2.UseVisualStyleBackColor = false;
            // 
            // renRadioButton2
            // 
            this.renRadioButton2.AutoSize = true;
            this.renRadioButton2.Checked = true;
            this.renRadioButton2.CheckedColor = System.Drawing.Color.Red;
            this.renRadioButton2.Location = new System.Drawing.Point(12, 335);
            this.renRadioButton2.MinimumSize = new System.Drawing.Size(0, 21);
            this.renRadioButton2.Name = "renRadioButton2";
            this.renRadioButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.renRadioButton2.Size = new System.Drawing.Size(115, 21);
            this.renRadioButton2.TabIndex = 6;
            this.renRadioButton2.TabStop = true;
            this.renRadioButton2.Text = "renRadioButton2";
            this.renRadioButton2.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.renRadioButton2.UseVisualStyleBackColor = true;
            // 
            // renPanel2
            // 
            this.renPanel2.BackColor = System.Drawing.Color.Transparent;
            this.renPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.renPanel2.BorderRadius = 0;
            this.renPanel2.BorderSize = 0;
            this.renPanel2.Controls.Add(this.label2);
            this.renPanel2.ForeColor = System.Drawing.Color.White;
            this.renPanel2.GradientAngle = 45F;
            this.renPanel2.GradientBottomColor = System.Drawing.Color.Cyan;
            this.renPanel2.GradientTopColor = System.Drawing.Color.Red;
            this.renPanel2.Location = new System.Drawing.Point(588, 181);
            this.renPanel2.Name = "renPanel2";
            this.renPanel2.Size = new System.Drawing.Size(200, 148);
            this.renPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "PANEL";
            // 
            // renToggleButton1
            // 
            this.renToggleButton1.AutoSize = true;
            this.renToggleButton1.Location = new System.Drawing.Point(12, 247);
            this.renToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.renToggleButton1.Name = "renToggleButton1";
            this.renToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.renToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.renToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.renToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.renToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.renToggleButton1.TabIndex = 5;
            this.renToggleButton1.UseVisualStyleBackColor = true;
            // 
            // renRadioButton1
            // 
            this.renRadioButton1.AutoSize = true;
            this.renRadioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.renRadioButton1.Location = new System.Drawing.Point(12, 308);
            this.renRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.renRadioButton1.Name = "renRadioButton1";
            this.renRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.renRadioButton1.Size = new System.Drawing.Size(115, 21);
            this.renRadioButton1.TabIndex = 4;
            this.renRadioButton1.Text = "renRadioButton1";
            this.renRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.renRadioButton1.UseVisualStyleBackColor = true;
            // 
            // renDatePicker1
            // 
            this.renDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.renDatePicker1.BorderSize = 0;
            this.renDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.renDatePicker1.Location = new System.Drawing.Point(12, 125);
            this.renDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.renDatePicker1.Name = "renDatePicker1";
            this.renDatePicker1.Size = new System.Drawing.Size(200, 35);
            this.renDatePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.renDatePicker1.TabIndex = 3;
            this.renDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // renPanel1
            // 
            this.renPanel1.BackColor = System.Drawing.Color.Transparent;
            this.renPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.renPanel1.BorderRadius = 30;
            this.renPanel1.BorderSize = 2;
            this.renPanel1.Controls.Add(this.label1);
            this.renPanel1.ForeColor = System.Drawing.Color.White;
            this.renPanel1.GradientAngle = 90F;
            this.renPanel1.GradientBottomColor = System.Drawing.Color.Transparent;
            this.renPanel1.GradientTopColor = System.Drawing.Color.Transparent;
            this.renPanel1.Location = new System.Drawing.Point(588, 12);
            this.renPanel1.Name = "renPanel1";
            this.renPanel1.Size = new System.Drawing.Size(200, 148);
            this.renPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANEL";
            // 
            // renButton1
            // 
            this.renButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.renButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.renButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.renButton1.BorderRadius = 0;
            this.renButton1.BorderSize = 0;
            this.renButton1.FlatAppearance.BorderSize = 0;
            this.renButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renButton1.ForeColor = System.Drawing.Color.White;
            this.renButton1.Location = new System.Drawing.Point(12, 12);
            this.renButton1.Name = "renButton1";
            this.renButton1.Size = new System.Drawing.Size(150, 40);
            this.renButton1.TabIndex = 0;
            this.renButton1.Text = "renButton1";
            this.renButton1.TextColor = System.Drawing.Color.White;
            this.renButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.cmbBoxAnimal);
            this.Controls.Add(this.renTextBox3);
            this.Controls.Add(this.renTextBox2);
            this.Controls.Add(this.renTextBox1);
            this.Controls.Add(this.renComboBox1);
            this.Controls.Add(this.renDatePicker2);
            this.Controls.Add(this.renToggleButton2);
            this.Controls.Add(this.renButton2);
            this.Controls.Add(this.renRadioButton2);
            this.Controls.Add(this.renPanel2);
            this.Controls.Add(this.renToggleButton1);
            this.Controls.Add(this.renRadioButton1);
            this.Controls.Add(this.renDatePicker1);
            this.Controls.Add(this.renPanel1);
            this.Controls.Add(this.renButton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.renPanel2.ResumeLayout(false);
            this.renPanel2.PerformLayout();
            this.renPanel1.ResumeLayout(false);
            this.renPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenComponent.RenButton renButton1;
        private RenComponent.RenPanel renPanel1;
        private RenComponent.RenDatePicker renDatePicker1;
        private RenComponent.RenRadioButton renRadioButton1;
        private RenComponent.RenToggleButton renToggleButton1;
        private System.Windows.Forms.Label label1;
        private RenComponent.RenPanel renPanel2;
        private System.Windows.Forms.Label label2;
        private RenComponent.RenRadioButton renRadioButton2;
        private RenComponent.RenButton renButton2;
        private RenComponent.RenToggleButton renToggleButton2;
        private RenComponent.RenDatePicker renDatePicker2;
        private RenComponent.RenComboBox renComboBox1;
        private RenComponent.RenTextBox renTextBox1;
        private RenComponent.RenTextBox renTextBox2;
        private RenComponent.RenTextBox renTextBox3;
        private RenComponent.UCRenComboBox cmbBoxAnimal;
    }
}


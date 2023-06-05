namespace AutoFact
{
    partial class aService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aService));
            this.bAddService = new CustomControls.RJControls.RButton();
            this.bRetourService = new CustomControls.RJControls.RButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameCategory = new System.Windows.Forms.TextBox();
            this.AddCategoryButton = new CustomControls.RJControls.RButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddService
            // 
            this.bAddService.BackColor = System.Drawing.Color.RoyalBlue;
            this.bAddService.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.bAddService.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bAddService.BorderRadius = 15;
            this.bAddService.BorderSize = 0;
            this.bAddService.FlatAppearance.BorderSize = 0;
            this.bAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddService.ForeColor = System.Drawing.Color.White;
            this.bAddService.Location = new System.Drawing.Point(461, 316);
            this.bAddService.Name = "bAddService";
            this.bAddService.Size = new System.Drawing.Size(150, 40);
            this.bAddService.TabIndex = 29;
            this.bAddService.Text = "Ajouter";
            this.bAddService.TextColor = System.Drawing.Color.White;
            this.bAddService.UseVisualStyleBackColor = false;
            this.bAddService.Click += new System.EventHandler(this.bAddService_Click_1);
            // 
            // bRetourService
            // 
            this.bRetourService.BackColor = System.Drawing.Color.RoyalBlue;
            this.bRetourService.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.bRetourService.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bRetourService.BorderRadius = 15;
            this.bRetourService.BorderSize = 0;
            this.bRetourService.FlatAppearance.BorderSize = 0;
            this.bRetourService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRetourService.ForeColor = System.Drawing.Color.White;
            this.bRetourService.Location = new System.Drawing.Point(240, 316);
            this.bRetourService.Name = "bRetourService";
            this.bRetourService.Size = new System.Drawing.Size(150, 40);
            this.bRetourService.TabIndex = 28;
            this.bRetourService.Text = "Retour";
            this.bRetourService.TextColor = System.Drawing.Color.White;
            this.bRetourService.UseVisualStyleBackColor = false;
            this.bRetourService.Click += new System.EventHandler(this.bRetourService_Click_1);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(11, 12);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(97, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 25;
            this.logo.TabStop = false;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(337, 192);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(63, 13);
            this.labelNom.TabIndex = 22;
            this.labelNom.Text = "Prix Unitaire";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(317, 159);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(83, 13);
            this.labelFirstName.TabIndex = 21;
            this.labelFirstName.Text = "Nom du Service";
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(397, 189);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbUnitPrice.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(397, 156);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nom de la catégorie";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(397, 253);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategory.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Catégorie";
            // 
            // textBoxNameCategory
            // 
            this.textBoxNameCategory.Location = new System.Drawing.Point(396, 222);
            this.textBoxNameCategory.Name = "textBoxNameCategory";
            this.textBoxNameCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameCategory.TabIndex = 33;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddCategoryButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.AddCategoryButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddCategoryButton.BorderRadius = 15;
            this.AddCategoryButton.BorderSize = 0;
            this.AddCategoryButton.FlatAppearance.BorderSize = 0;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryButton.ForeColor = System.Drawing.Color.White;
            this.AddCategoryButton.Location = new System.Drawing.Point(513, 218);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(128, 26);
            this.AddCategoryButton.TabIndex = 34;
            this.AddCategoryButton.Text = "Ajouter";
            this.AddCategoryButton.TextColor = System.Drawing.Color.White;
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // aService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.textBoxNameCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddService);
            this.Controls.Add(this.bRetourService);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.tbName);
            this.Name = "aService";
            this.Text = "Ajouter un service";
            this.Load += new System.EventHandler(this.aService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RButton bAddService;
        private CustomControls.RJControls.RButton bRetourService;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameCategory;
        private CustomControls.RJControls.RButton AddCategoryButton;
    }
}
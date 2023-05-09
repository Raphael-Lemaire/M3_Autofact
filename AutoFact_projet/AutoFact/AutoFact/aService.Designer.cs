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
            this.bAddService.Location = new System.Drawing.Point(676, 434);
            this.bAddService.Margin = new System.Windows.Forms.Padding(4);
            this.bAddService.Name = "bAddService";
            this.bAddService.Size = new System.Drawing.Size(200, 49);
            this.bAddService.TabIndex = 29;
            this.bAddService.Text = "Ajouter";
            this.bAddService.TextColor = System.Drawing.Color.White;
            this.bAddService.UseVisualStyleBackColor = false;
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
            this.bRetourService.Location = new System.Drawing.Point(197, 434);
            this.bRetourService.Margin = new System.Windows.Forms.Padding(4);
            this.bRetourService.Name = "bRetourService";
            this.bRetourService.Size = new System.Drawing.Size(200, 49);
            this.bRetourService.TabIndex = 28;
            this.bRetourService.Text = "Retour";
            this.bRetourService.TextColor = System.Drawing.Color.White;
            this.bRetourService.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(15, 15);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(129, 114);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 25;
            this.logo.TabStop = false;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(621, 247);
            this.labelNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(78, 16);
            this.labelNom.TabIndex = 22;
            this.labelNom.Text = "Prix Unitaire";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(211, 248);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(103, 16);
            this.labelFirstName.TabIndex = 21;
            this.labelFirstName.Text = "Nom du Service";
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(702, 244);
            this.tbUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(132, 22);
            this.tbUnitPrice.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(317, 245);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(132, 22);
            this.tbName.TabIndex = 17;
            // 
            // aService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bAddService);
            this.Controls.Add(this.bRetourService);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.tbName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}
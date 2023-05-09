namespace AutoFact
{
    partial class aDevis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aDevis));
            this.rButton2 = new CustomControls.RJControls.RButton();
            this.bAddCustomer = new CustomControls.RJControls.RButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.labelNumberPhone = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // rButton2
            // 
            this.rButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.rButton2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton2.BorderRadius = 15;
            this.rButton2.BorderSize = 0;
            this.rButton2.FlatAppearance.BorderSize = 0;
            this.rButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton2.ForeColor = System.Drawing.Color.White;
            this.rButton2.Location = new System.Drawing.Point(533, 352);
            this.rButton2.Name = "rButton2";
            this.rButton2.Size = new System.Drawing.Size(150, 40);
            this.rButton2.TabIndex = 29;
            this.rButton2.Text = "Créer devis";
            this.rButton2.TextColor = System.Drawing.Color.White;
            this.rButton2.UseVisualStyleBackColor = false;
            // 
            // bAddCustomer
            // 
            this.bAddCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.bAddCustomer.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.bAddCustomer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bAddCustomer.BorderRadius = 15;
            this.bAddCustomer.BorderSize = 0;
            this.bAddCustomer.FlatAppearance.BorderSize = 0;
            this.bAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddCustomer.ForeColor = System.Drawing.Color.White;
            this.bAddCustomer.Location = new System.Drawing.Point(174, 352);
            this.bAddCustomer.Name = "bAddCustomer";
            this.bAddCustomer.Size = new System.Drawing.Size(150, 40);
            this.bAddCustomer.TabIndex = 28;
            this.bAddCustomer.Text = "retour";
            this.bAddCustomer.TextColor = System.Drawing.Color.White;
            this.bAddCustomer.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(37, 11);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(97, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 25;
            this.logo.TabStop = false;
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.Location = new System.Drawing.Point(356, 193);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(33, 13);
            this.labelNumberPhone.TabIndex = 23;
            this.labelNumberPhone.Text = "Client";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(501, 164);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(0, 13);
            this.labelNom.TabIndex = 22;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(317, 167);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(72, 13);
            this.labelFirstName.TabIndex = 21;
            this.labelFirstName.Text = "Nom du devis";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(395, 164);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 17;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(395, 190);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(100, 21);
            this.comboBoxClient.TabIndex = 32;
            // 
            // aDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.rButton2);
            this.Controls.Add(this.bAddCustomer);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.labelNumberPhone);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "aDevis";
            this.Text = "aDevis";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RButton rButton2;
        private CustomControls.RJControls.RButton bAddCustomer;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label labelNumberPhone;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.ComboBox comboBoxClient;
    }
}
namespace AutoFact
{
    partial class aClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aClient));
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbNumberPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelNumberPhone = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCompagny = new System.Windows.Forms.TextBox();
            this.bAddCustomer = new CustomControls.RJControls.RButton();
            this.rButton2 = new CustomControls.RJControls.RButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(148, 161);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(557, 157);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // tbNumberPhone
            // 
            this.tbNumberPhone.Location = new System.Drawing.Point(148, 241);
            this.tbNumberPhone.Name = "tbNumberPhone";
            this.tbNumberPhone.Size = new System.Drawing.Size(100, 20);
            this.tbNumberPhone.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(557, 241);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(99, 164);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(43, 13);
            this.labelFirstName.TabIndex = 7;
            this.labelFirstName.Text = "Prénom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(475, 164);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(76, 13);
            this.labelNom.TabIndex = 8;
            this.labelNom.Text = "Nom de famille";
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.Location = new System.Drawing.Point(44, 244);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(98, 13);
            this.labelNumberPhone.TabIndex = 9;
            this.labelNumberPhone.Text = "Numéro Téléphone";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(476, 244);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(75, 13);
            this.labelEmailAddress.TabIndex = 10;
            this.labelEmailAddress.Text = "Adresse e-mail";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(11, 11);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(97, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "entreprise";
            // 
            // tbCompagny
            // 
            this.tbCompagny.Location = new System.Drawing.Point(312, 301);
            this.tbCompagny.Name = "tbCompagny";
            this.tbCompagny.Size = new System.Drawing.Size(100, 20);
            this.tbCompagny.TabIndex = 14;
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
            this.bAddCustomer.Location = new System.Drawing.Point(148, 352);
            this.bAddCustomer.Name = "bAddCustomer";
            this.bAddCustomer.Size = new System.Drawing.Size(150, 40);
            this.bAddCustomer.TabIndex = 15;
            this.bAddCustomer.Text = "retour";
            this.bAddCustomer.TextColor = System.Drawing.Color.White;
            this.bAddCustomer.UseVisualStyleBackColor = false;
            this.bAddCustomer.Click += new System.EventHandler(this.bAddCustomer_Click);
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
            this.rButton2.Location = new System.Drawing.Point(507, 352);
            this.rButton2.Name = "rButton2";
            this.rButton2.Size = new System.Drawing.Size(150, 40);
            this.rButton2.TabIndex = 16;
            this.rButton2.Text = "Ajouter";
            this.rButton2.TextColor = System.Drawing.Color.White;
            this.rButton2.UseVisualStyleBackColor = false;
            this.rButton2.Click += new System.EventHandler(this.rButton2_Click);
            // 
            // aClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.rButton2);
            this.Controls.Add(this.bAddCustomer);
            this.Controls.Add(this.tbCompagny);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.labelNumberPhone);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNumberPhone);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "aClient";
            this.Text = "Ajouter un client";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbNumberPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelNumberPhone;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompagny;
        private CustomControls.RJControls.RButton bAddCustomer;
        private CustomControls.RJControls.RButton rButton2;
    }
}
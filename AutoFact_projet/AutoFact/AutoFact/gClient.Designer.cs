namespace AutoFact
{
    partial class gClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gClient));
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelNumberPhone = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbNumberPhone = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.rbBack = new CustomControls.RJControls.RButton();
            this.rbAdd = new CustomControls.RJControls.RButton();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.rButton1 = new CustomControls.RJControls.RButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(551, 237);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 21;
            this.labelAddress.Text = "Adresse";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(348, 237);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(75, 13);
            this.labelEmailAddress.TabIndex = 20;
            this.labelEmailAddress.Text = "Adresse e-mail";
            this.labelEmailAddress.Click += new System.EventHandler(this.labelEmailAddress_Click);
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.Location = new System.Drawing.Point(122, 237);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(98, 13);
            this.labelNumberPhone.TabIndex = 19;
            this.labelNumberPhone.Text = "Numéro Téléphone";
            this.labelNumberPhone.Click += new System.EventHandler(this.labelNumberPhone_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(474, 173);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(76, 13);
            this.labelNom.TabIndex = 18;
            this.labelNom.Text = "Nom de famille";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(195, 169);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(43, 13);
            this.labelFirstName.TabIndex = 17;
            this.labelFirstName.Text = "Prénom";
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(602, 234);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 16;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(429, 234);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.tbEmailAddress.TabIndex = 15;
            this.tbEmailAddress.TextChanged += new System.EventHandler(this.tbEmailAddress_TextChanged);
            // 
            // tbNumberPhone
            // 
            this.tbNumberPhone.Location = new System.Drawing.Point(226, 234);
            this.tbNumberPhone.Name = "tbNumberPhone";
            this.tbNumberPhone.Size = new System.Drawing.Size(100, 20);
            this.tbNumberPhone.TabIndex = 14;
            this.tbNumberPhone.TextChanged += new System.EventHandler(this.tbNumberPhone_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(556, 166);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 13;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(244, 166);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 12;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(11, 11);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(97, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 22;
            this.logo.TabStop = false;
            // 
            // rbBack
            // 
            this.rbBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbBack.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rbBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbBack.BorderRadius = 12;
            this.rbBack.BorderSize = 0;
            this.rbBack.FlatAppearance.BorderSize = 0;
            this.rbBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBack.ForeColor = System.Drawing.Color.White;
            this.rbBack.Location = new System.Drawing.Point(244, 446);
            this.rbBack.Name = "rbBack";
            this.rbBack.Size = new System.Drawing.Size(100, 32);
            this.rbBack.TabIndex = 25;
            this.rbBack.Text = "Annuler";
            this.rbBack.TextColor = System.Drawing.Color.White;
            this.rbBack.UseVisualStyleBackColor = false;
            // 
            // rbAdd
            // 
            this.rbAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbAdd.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rbAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbAdd.BorderRadius = 12;
            this.rbAdd.BorderSize = 0;
            this.rbAdd.FlatAppearance.BorderSize = 0;
            this.rbAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdd.ForeColor = System.Drawing.Color.White;
            this.rbAdd.Location = new System.Drawing.Point(494, 446);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(100, 32);
            this.rbAdd.TabIndex = 26;
            this.rbAdd.Text = "Ajouter";
            this.rbAdd.TextColor = System.Drawing.Color.White;
            this.rbAdd.UseVisualStyleBackColor = false;
            // 
            // tbRecherche
            // 
            this.tbRecherche.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbRecherche.Location = new System.Drawing.Point(157, 54);
            this.tbRecherche.Multiline = true;
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(220, 19);
            this.tbRecherche.TabIndex = 28;
            this.tbRecherche.Text = "recherche";
            this.tbRecherche.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rButton1
            // 
            this.rButton1.BackColor = System.Drawing.Color.LightCyan;
            this.rButton1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.rButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton1.BorderRadius = 15;
            this.rButton1.BorderSize = 0;
            this.rButton1.FlatAppearance.BorderSize = 0;
            this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton1.ForeColor = System.Drawing.Color.Black;
            this.rButton1.Location = new System.Drawing.Point(383, 47);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(100, 33);
            this.rButton1.TabIndex = 27;
            this.rButton1.Text = "Recherche";
            this.rButton1.TextColor = System.Drawing.Color.Black;
            this.rButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(41, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 310);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // gClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 513);
            this.Controls.Add(this.tbRecherche);
            this.Controls.Add(this.rButton1);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.rbBack);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.labelNumberPhone);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.tbNumberPhone);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "gClient";
            this.Text = "Gérer les clients";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelNumberPhone;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbNumberPhone;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox tbRecherche;
        private CustomControls.RJControls.RButton rbBack;
        private CustomControls.RJControls.RButton rbAdd;
        private CustomControls.RJControls.RButton rButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
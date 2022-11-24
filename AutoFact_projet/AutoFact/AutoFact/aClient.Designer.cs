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
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelNumberPhone = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.rbBack = new CustomControls.RJControls.RButton();
            this.rbAdd = new CustomControls.RJControls.RButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(250, 161);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(534, 161);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbNumberPhone
            // 
            this.tbNumberPhone.Location = new System.Drawing.Point(157, 268);
            this.tbNumberPhone.Name = "tbNumberPhone";
            this.tbNumberPhone.Size = new System.Drawing.Size(100, 20);
            this.tbNumberPhone.TabIndex = 4;
            this.tbNumberPhone.TextChanged += new System.EventHandler(this.tbNumberPhone_TextChanged);
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(374, 268);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.tbEmailAddress.TabIndex = 5;
            this.tbEmailAddress.TextChanged += new System.EventHandler(this.tbEmailAddress_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(599, 268);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 6;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Gray;
            this.labelFirstName.Location = new System.Drawing.Point(201, 164);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(43, 13);
            this.labelFirstName.TabIndex = 7;
            this.labelFirstName.Text = "Prénom";
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Gray;
            this.labelNom.Location = new System.Drawing.Point(452, 168);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(76, 13);
            this.labelNom.TabIndex = 8;
            this.labelNom.Text = "Nom de famille";
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.BackColor = System.Drawing.Color.Gray;
            this.labelNumberPhone.Location = new System.Drawing.Point(53, 271);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(98, 13);
            this.labelNumberPhone.TabIndex = 9;
            this.labelNumberPhone.Text = "Numéro Téléphone";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.BackColor = System.Drawing.Color.Gray;
            this.labelEmailAddress.Location = new System.Drawing.Point(293, 271);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(75, 13);
            this.labelEmailAddress.TabIndex = 10;
            this.labelEmailAddress.Text = "Adresse e-mail";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Gray;
            this.labelAddress.Location = new System.Drawing.Point(548, 271);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Adresse";
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
            this.rbBack.Location = new System.Drawing.Point(250, 409);
            this.rbBack.Name = "rbBack";
            this.rbBack.Size = new System.Drawing.Size(100, 32);
            this.rbBack.TabIndex = 13;
            this.rbBack.Text = "Annuler";
            this.rbBack.TextColor = System.Drawing.Color.White;
            this.rbBack.UseVisualStyleBackColor = false;
            this.rbBack.Click += new System.EventHandler(this.rbBack_Click);
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
            this.rbAdd.Location = new System.Drawing.Point(516, 409);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(100, 32);
            this.rbAdd.TabIndex = 14;
            this.rbAdd.Text = "Ajouter";
            this.rbAdd.TextColor = System.Drawing.Color.White;
            this.rbAdd.UseVisualStyleBackColor = false;
            this.rbAdd.Click += new System.EventHandler(this.rbAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(27, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 283);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(796, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // aClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 506);
            this.Controls.Add(this.pictureBox2);
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
            this.Name = "aClient";
            this.Text = "Ajouter un client";
            this.Load += new System.EventHandler(this.aClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbNumberPhone;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelNumberPhone;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.PictureBox logo;
        private CustomControls.RJControls.RButton rbBack;
        private CustomControls.RJControls.RButton rbAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
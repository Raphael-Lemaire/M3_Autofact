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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(98, 322);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 21;
            this.labelAddress.Text = "Adresse";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(68, 282);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(75, 13);
            this.labelEmailAddress.TabIndex = 20;
            this.labelEmailAddress.Text = "Adresse e-mail";
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.Location = new System.Drawing.Point(45, 240);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(98, 13);
            this.labelNumberPhone.TabIndex = 19;
            this.labelNumberPhone.Text = "Numéro Téléphone";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(67, 201);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(76, 13);
            this.labelNom.TabIndex = 18;
            this.labelNom.Text = "Nom de famille";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(100, 161);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(43, 13);
            this.labelFirstName.TabIndex = 17;
            this.labelFirstName.Text = "Prénom";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(149, 319);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 16;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(149, 279);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.tbEmailAddress.TabIndex = 15;
            // 
            // tbNumberPhone
            // 
            this.tbNumberPhone.Location = new System.Drawing.Point(149, 237);
            this.tbNumberPhone.Name = "tbNumberPhone";
            this.tbNumberPhone.Size = new System.Drawing.Size(100, 20);
            this.tbNumberPhone.TabIndex = 14;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(149, 194);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 13;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(149, 158);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 12;
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
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(611, 314);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(474, 314);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Annuler";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // gClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
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
            this.Name = "gClient";
            this.Text = "Gérer les clients";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
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
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
    }
}
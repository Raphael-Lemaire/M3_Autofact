﻿namespace AutoFact
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(463, 317);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Annuler";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(600, 317);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button2_Click);
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
            this.tbLastName.Location = new System.Drawing.Point(148, 198);
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
            this.tbEmail.Location = new System.Drawing.Point(148, 283);
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
            this.labelNom.Location = new System.Drawing.Point(66, 205);
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
            this.labelEmailAddress.Location = new System.Drawing.Point(67, 286);
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
            this.label1.Location = new System.Drawing.Point(80, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "entreprise";
            // 
            // tbCompagny
            // 
            this.tbCompagny.Location = new System.Drawing.Point(148, 320);
            this.tbCompagny.Name = "tbCompagny";
            this.tbCompagny.Size = new System.Drawing.Size(100, 20);
            this.tbCompagny.TabIndex = 14;
            // 
            // aClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
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
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Name = "aClient";
            this.Text = "Ajouter un client";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
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
    }
}
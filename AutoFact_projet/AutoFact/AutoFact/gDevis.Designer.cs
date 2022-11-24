namespace AutoFact
{
    partial class gDevis
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
            this.SaveQuote = new CustomControls.RJControls.RButton();
            this.tbTotal_Price = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveQuote
            // 
            this.SaveQuote.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.SaveQuote.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.SaveQuote.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SaveQuote.BorderRadius = 15;
            this.SaveQuote.BorderSize = 0;
            this.SaveQuote.FlatAppearance.BorderSize = 0;
            this.SaveQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveQuote.ForeColor = System.Drawing.Color.White;
            this.SaveQuote.Location = new System.Drawing.Point(464, 389);
            this.SaveQuote.Name = "SaveQuote";
            this.SaveQuote.Size = new System.Drawing.Size(150, 40);
            this.SaveQuote.TabIndex = 0;
            this.SaveQuote.Text = "Enregistrer devis";
            this.SaveQuote.TextColor = System.Drawing.Color.White;
            this.SaveQuote.UseVisualStyleBackColor = false;
            this.SaveQuote.Click += new System.EventHandler(this.SaveQuote_Click);
            // 
            // tbTotal_Price
            // 
            this.tbTotal_Price.Location = new System.Drawing.Point(302, 175);
            this.tbTotal_Price.Name = "tbTotal_Price";
            this.tbTotal_Price.Size = new System.Drawing.Size(100, 22);
            this.tbTotal_Price.TabIndex = 1;
            this.tbTotal_Price.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(302, 128);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total_Price";
            // 
            // gDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbTotal_Price);
            this.Controls.Add(this.SaveQuote);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "gDevis";
            this.Text = "Gérer les devis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RButton SaveQuote;
        private System.Windows.Forms.TextBox tbTotal_Price;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
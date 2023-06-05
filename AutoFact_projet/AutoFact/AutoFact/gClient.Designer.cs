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
            this.logo = new System.Windows.Forms.PictureBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.tbScreachCustomer = new System.Windows.Forms.TextBox();
            this.TBfirstNameUp = new System.Windows.Forms.TextBox();
            this.TBlasttNameUpdate = new System.Windows.Forms.TextBox();
            this.TBmailUpdate = new System.Windows.Forms.TextBox();
            this.TBnumberPhoneUpdate = new System.Windows.Forms.TextBox();
            this.TBcompagnyMailUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rButton2 = new CustomControls.RJControls.RButton();
            this.rButton1 = new CustomControls.RJControls.RButton();
            this.Updatebot = new CustomControls.RJControls.RButton();
            this.ReadCustomer = new CustomControls.RJControls.RButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(24, 11);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(97, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 22;
            this.logo.TabStop = false;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(24, 201);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(852, 382);
            this.dataGridViewCustomer.TabIndex = 23;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick);
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            // 
            // tbScreachCustomer
            // 
            this.tbScreachCustomer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbScreachCustomer.Location = new System.Drawing.Point(673, 175);
            this.tbScreachCustomer.Name = "tbScreachCustomer";
            this.tbScreachCustomer.Size = new System.Drawing.Size(203, 20);
            this.tbScreachCustomer.TabIndex = 25;
            this.tbScreachCustomer.TextChanged += new System.EventHandler(this.tbScreachCustomer_TextChanged);
            // 
            // TBfirstNameUp
            // 
            this.TBfirstNameUp.Location = new System.Drawing.Point(128, 606);
            this.TBfirstNameUp.Name = "TBfirstNameUp";
            this.TBfirstNameUp.Size = new System.Drawing.Size(100, 20);
            this.TBfirstNameUp.TabIndex = 31;
            // 
            // TBlasttNameUpdate
            // 
            this.TBlasttNameUpdate.Location = new System.Drawing.Point(128, 647);
            this.TBlasttNameUpdate.Name = "TBlasttNameUpdate";
            this.TBlasttNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.TBlasttNameUpdate.TabIndex = 31;
            // 
            // TBmailUpdate
            // 
            this.TBmailUpdate.Location = new System.Drawing.Point(377, 603);
            this.TBmailUpdate.Name = "TBmailUpdate";
            this.TBmailUpdate.Size = new System.Drawing.Size(100, 20);
            this.TBmailUpdate.TabIndex = 31;
            // 
            // TBnumberPhoneUpdate
            // 
            this.TBnumberPhoneUpdate.Location = new System.Drawing.Point(377, 644);
            this.TBnumberPhoneUpdate.Name = "TBnumberPhoneUpdate";
            this.TBnumberPhoneUpdate.Size = new System.Drawing.Size(100, 20);
            this.TBnumberPhoneUpdate.TabIndex = 31;
            // 
            // TBcompagnyMailUpdate
            // 
            this.TBcompagnyMailUpdate.Location = new System.Drawing.Point(604, 606);
            this.TBcompagnyMailUpdate.Name = "TBcompagnyMailUpdate";
            this.TBcompagnyMailUpdate.Size = new System.Drawing.Size(100, 20);
            this.TBcompagnyMailUpdate.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nom de famille";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nom compagnie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 647);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Numéro Téléphone";
            // 
            // rButton2
            // 
            this.rButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton2.BorderRadius = 8;
            this.rButton2.BorderSize = 0;
            this.rButton2.FlatAppearance.BorderSize = 0;
            this.rButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton2.ForeColor = System.Drawing.Color.White;
            this.rButton2.Location = new System.Drawing.Point(955, 211);
            this.rButton2.Name = "rButton2";
            this.rButton2.Size = new System.Drawing.Size(8, 8);
            this.rButton2.TabIndex = 39;
            this.rButton2.Text = "rButton2";
            this.rButton2.TextColor = System.Drawing.Color.White;
            this.rButton2.UseVisualStyleBackColor = false;
            // 
            // rButton1
            // 
            this.rButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.rButton1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.rButton1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rButton1.BorderRadius = 15;
            this.rButton1.BorderSize = 0;
            this.rButton1.FlatAppearance.BorderSize = 0;
            this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton1.ForeColor = System.Drawing.Color.White;
            this.rButton1.Location = new System.Drawing.Point(892, 211);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(150, 40);
            this.rButton1.TabIndex = 38;
            this.rButton1.Text = "Supprimer";
            this.rButton1.TextColor = System.Drawing.Color.White;
            this.rButton1.UseVisualStyleBackColor = false;
            this.rButton1.Click += new System.EventHandler(this.rButton1_Click);
            // 
            // Updatebot
            // 
            this.Updatebot.BackColor = System.Drawing.Color.RoyalBlue;
            this.Updatebot.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Updatebot.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Updatebot.BorderRadius = 15;
            this.Updatebot.BorderSize = 0;
            this.Updatebot.FlatAppearance.BorderSize = 0;
            this.Updatebot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebot.ForeColor = System.Drawing.Color.White;
            this.Updatebot.Location = new System.Drawing.Point(892, 278);
            this.Updatebot.Name = "Updatebot";
            this.Updatebot.Size = new System.Drawing.Size(150, 40);
            this.Updatebot.TabIndex = 37;
            this.Updatebot.Text = "Modifier";
            this.Updatebot.TextColor = System.Drawing.Color.White;
            this.Updatebot.UseVisualStyleBackColor = false;
            this.Updatebot.Click += new System.EventHandler(this.Updatebot_Click);
            // 
            // ReadCustomer
            // 
            this.ReadCustomer.BackColor = System.Drawing.Color.DarkCyan;
            this.ReadCustomer.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.ReadCustomer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ReadCustomer.BorderRadius = 15;
            this.ReadCustomer.BorderSize = 0;
            this.ReadCustomer.FlatAppearance.BorderSize = 0;
            this.ReadCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadCustomer.ForeColor = System.Drawing.Color.White;
            this.ReadCustomer.Location = new System.Drawing.Point(24, 146);
            this.ReadCustomer.Name = "ReadCustomer";
            this.ReadCustomer.Size = new System.Drawing.Size(150, 40);
            this.ReadCustomer.TabIndex = 24;
            this.ReadCustomer.Text = "Actualiser";
            this.ReadCustomer.TextColor = System.Drawing.Color.White;
            this.ReadCustomer.UseVisualStyleBackColor = false;
            this.ReadCustomer.Click += new System.EventHandler(this.ReadCustomer_Click_1);
            // 
            // gClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 680);
            this.Controls.Add(this.rButton2);
            this.Controls.Add(this.rButton1);
            this.Controls.Add(this.Updatebot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBcompagnyMailUpdate);
            this.Controls.Add(this.TBnumberPhoneUpdate);
            this.Controls.Add(this.TBmailUpdate);
            this.Controls.Add(this.TBlasttNameUpdate);
            this.Controls.Add(this.TBfirstNameUp);
            this.Controls.Add(this.tbScreachCustomer);
            this.Controls.Add(this.ReadCustomer);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.logo);
            this.Name = "gClient";
            this.Text = "Gérer les clients";
            this.Load += new System.EventHandler(this.gClient_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private CustomControls.RJControls.RButton ReadCustomer;
        private System.Windows.Forms.TextBox tbScreachCustomer;
        private System.Windows.Forms.TextBox TBfirstNameUp;
        private System.Windows.Forms.TextBox TBlasttNameUpdate;
        private System.Windows.Forms.TextBox TBmailUpdate;
        private System.Windows.Forms.TextBox TBnumberPhoneUpdate;
        private System.Windows.Forms.TextBox TBcompagnyMailUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RButton Updatebot;
        private CustomControls.RJControls.RButton rButton1;
        private CustomControls.RJControls.RButton rButton2;
    }
}
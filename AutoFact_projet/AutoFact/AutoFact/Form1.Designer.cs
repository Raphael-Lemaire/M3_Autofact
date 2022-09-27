
namespace AutoFact
{
    partial class formAF
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAF));
            this.pageselection = new System.Windows.Forms.TabControl();
            this.firstpage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servicespage = new System.Windows.Forms.TabPage();
            this.historiquepage = new System.Windows.Forms.TabPage();
            this.clientpage = new System.Windows.Forms.TabPage();
            this.parametrepage = new System.Windows.Forms.TabPage();
            this.logo = new System.Windows.Forms.PictureBox();
            this.colservices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colannee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageselection.SuspendLayout();
            this.firstpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pageselection
            // 
            this.pageselection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageselection.Controls.Add(this.firstpage);
            this.pageselection.Controls.Add(this.servicespage);
            this.pageselection.Controls.Add(this.historiquepage);
            this.pageselection.Controls.Add(this.clientpage);
            this.pageselection.Controls.Add(this.parametrepage);
            this.pageselection.Location = new System.Drawing.Point(161, 12);
            this.pageselection.Name = "pageselection";
            this.pageselection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pageselection.SelectedIndex = 0;
            this.pageselection.Size = new System.Drawing.Size(842, 445);
            this.pageselection.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.pageselection.TabIndex = 0;
            // 
            // firstpage
            // 
            this.firstpage.Controls.Add(this.label1);
            this.firstpage.Controls.Add(this.dataGridView1);
            this.firstpage.Location = new System.Drawing.Point(4, 29);
            this.firstpage.Name = "firstpage";
            this.firstpage.Padding = new System.Windows.Forms.Padding(3);
            this.firstpage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.firstpage.Size = new System.Drawing.Size(834, 412);
            this.firstpage.TabIndex = 0;
            this.firstpage.Text = "Dashboard";
            this.firstpage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chiffre d\'affaire";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colservices,
            this.colca,
            this.colannee});
            this.dataGridView1.Location = new System.Drawing.Point(7, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(307, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // servicespage
            // 
            this.servicespage.Location = new System.Drawing.Point(4, 29);
            this.servicespage.Name = "servicespage";
            this.servicespage.Padding = new System.Windows.Forms.Padding(3);
            this.servicespage.Size = new System.Drawing.Size(765, 403);
            this.servicespage.TabIndex = 1;
            this.servicespage.Text = "Services";
            this.servicespage.UseVisualStyleBackColor = true;
            // 
            // historiquepage
            // 
            this.historiquepage.Location = new System.Drawing.Point(4, 29);
            this.historiquepage.Name = "historiquepage";
            this.historiquepage.Padding = new System.Windows.Forms.Padding(3);
            this.historiquepage.Size = new System.Drawing.Size(765, 403);
            this.historiquepage.TabIndex = 2;
            this.historiquepage.Text = "Historique";
            this.historiquepage.UseVisualStyleBackColor = true;
            // 
            // clientpage
            // 
            this.clientpage.Location = new System.Drawing.Point(4, 29);
            this.clientpage.Name = "clientpage";
            this.clientpage.Padding = new System.Windows.Forms.Padding(3);
            this.clientpage.Size = new System.Drawing.Size(765, 403);
            this.clientpage.TabIndex = 3;
            this.clientpage.Text = "Client";
            this.clientpage.UseVisualStyleBackColor = true;
            // 
            // parametrepage
            // 
            this.parametrepage.Location = new System.Drawing.Point(4, 29);
            this.parametrepage.Name = "parametrepage";
            this.parametrepage.Padding = new System.Windows.Forms.Padding(3);
            this.parametrepage.Size = new System.Drawing.Size(765, 403);
            this.parametrepage.TabIndex = 4;
            this.parametrepage.Text = "Paramètres";
            this.parametrepage.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(145, 143);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // colservices
            // 
            this.colservices.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colservices.HeaderText = "Services";
            this.colservices.MinimumWidth = 8;
            this.colservices.Name = "colservices";
            this.colservices.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colca
            // 
            this.colca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colca.HeaderText = "CA";
            this.colca.MinimumWidth = 8;
            this.colca.Name = "colca";
            this.colca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colannee
            // 
            this.colannee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colannee.HeaderText = "Année";
            this.colannee.MinimumWidth = 8;
            this.colannee.Name = "colannee";
            this.colannee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // formAF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 469);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pageselection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAF";
            this.Text = "AutoFact";
            this.pageselection.ResumeLayout(false);
            this.firstpage.ResumeLayout(false);
            this.firstpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pageselection;
        private System.Windows.Forms.TabPage firstpage;
        private System.Windows.Forms.TabPage servicespage;
        private System.Windows.Forms.TabPage historiquepage;
        private System.Windows.Forms.TabPage clientpage;
        private System.Windows.Forms.TabPage parametrepage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colservices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colannee;
    }
}


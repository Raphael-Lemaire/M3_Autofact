
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
            this.rvs = new System.Windows.Forms.Label();
            this.dfdashboard = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cadashboard = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colservices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colannee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicespage = new System.Windows.Forms.TabPage();
            this.filtrecatservice = new System.Windows.Forms.ComboBox();
            this.addService = new System.Windows.Forms.Button();
            this.gererService = new System.Windows.Forms.Button();
            this.dsservice = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_des_services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_unitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devispage = new System.Windows.Forms.TabPage();
            this.gererDevis = new System.Windows.Forms.Button();
            this.filtreDevis = new System.Windows.Forms.ComboBox();
            this.ldDevis = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.numDevis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientpage = new System.Windows.Forms.TabPage();
            this.addClient = new System.Windows.Forms.Button();
            this.gererClient = new System.Windows.Forms.Button();
            this.listecliClient = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.numeroClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClientc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametrepage = new System.Windows.Forms.TabPage();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pageselection.SuspendLayout();
            this.firstpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.servicespage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.devispage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.clientpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
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
            this.pageselection.Controls.Add(this.devispage);
            this.pageselection.Controls.Add(this.clientpage);
            this.pageselection.Controls.Add(this.parametrepage);
            this.pageselection.Location = new System.Drawing.Point(107, 8);
            this.pageselection.Margin = new System.Windows.Forms.Padding(2);
            this.pageselection.Name = "pageselection";
            this.pageselection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pageselection.SelectedIndex = 0;
            this.pageselection.Size = new System.Drawing.Size(936, 514);
            this.pageselection.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.pageselection.TabIndex = 0;
            // 
            // firstpage
            // 
            this.firstpage.Controls.Add(this.rvs);
            this.firstpage.Controls.Add(this.dfdashboard);
            this.firstpage.Controls.Add(this.dataGridView2);
            this.firstpage.Controls.Add(this.cadashboard);
            this.firstpage.Controls.Add(this.dataGridView1);
            this.firstpage.Location = new System.Drawing.Point(4, 22);
            this.firstpage.Margin = new System.Windows.Forms.Padding(2);
            this.firstpage.Name = "firstpage";
            this.firstpage.Padding = new System.Windows.Forms.Padding(2);
            this.firstpage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.firstpage.Size = new System.Drawing.Size(928, 488);
            this.firstpage.TabIndex = 0;
            this.firstpage.Text = "Dashboard";
            this.firstpage.UseVisualStyleBackColor = true;
            // 
            // rvs
            // 
            this.rvs.AutoSize = true;
            this.rvs.Location = new System.Drawing.Point(538, 82);
            this.rvs.Name = "rvs";
            this.rvs.Size = new System.Drawing.Size(170, 13);
            this.rvs.TabIndex = 4;
            this.rvs.Text = "Répartition des ventes de services";
            this.rvs.Click += new System.EventHandler(this.rvs_Click);
            // 
            // dfdashboard
            // 
            this.dfdashboard.AutoSize = true;
            this.dfdashboard.Location = new System.Drawing.Point(5, 226);
            this.dfdashboard.Name = "dfdashboard";
            this.dfdashboard.Size = new System.Drawing.Size(105, 13);
            this.dfdashboard.TabIndex = 3;
            this.dfdashboard.Text = "Dernières facturation";
            this.dfdashboard.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 242);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(474, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // cadashboard
            // 
            this.cadashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadashboard.AutoSize = true;
            this.cadashboard.Location = new System.Drawing.Point(4, 24);
            this.cadashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cadashboard.Name = "cadashboard";
            this.cadashboard.Size = new System.Drawing.Size(77, 13);
            this.cadashboard.TabIndex = 1;
            this.cadashboard.Text = "Chiffre d\'affaire";
            this.cadashboard.Click += new System.EventHandler(this.label1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(5, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(474, 125);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // servicespage
            // 
            this.servicespage.Controls.Add(this.filtrecatservice);
            this.servicespage.Controls.Add(this.addService);
            this.servicespage.Controls.Add(this.gererService);
            this.servicespage.Controls.Add(this.dsservice);
            this.servicespage.Controls.Add(this.dataGridView3);
            this.servicespage.Location = new System.Drawing.Point(4, 22);
            this.servicespage.Margin = new System.Windows.Forms.Padding(2);
            this.servicespage.Name = "servicespage";
            this.servicespage.Padding = new System.Windows.Forms.Padding(2);
            this.servicespage.Size = new System.Drawing.Size(928, 488);
            this.servicespage.TabIndex = 1;
            this.servicespage.Text = "Services";
            this.servicespage.UseVisualStyleBackColor = true;
            // 
            // filtrecatservice
            // 
            this.filtrecatservice.FormattingEnabled = true;
            this.filtrecatservice.Items.AddRange(new object[] {
            "Par défaut",
            "Service",
            "Produit"});
            this.filtrecatservice.Location = new System.Drawing.Point(639, 42);
            this.filtrecatservice.Name = "filtrecatservice";
            this.filtrecatservice.Size = new System.Drawing.Size(75, 21);
            this.filtrecatservice.TabIndex = 4;
            this.filtrecatservice.Text = "Catégorie";
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(801, 42);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(75, 23);
            this.addService.TabIndex = 3;
            this.addService.Text = "Ajouter";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // gererService
            // 
            this.gererService.Location = new System.Drawing.Point(720, 42);
            this.gererService.Name = "gererService";
            this.gererService.Size = new System.Drawing.Size(75, 23);
            this.gererService.TabIndex = 2;
            this.gererService.Text = "Gérer";
            this.gererService.UseVisualStyleBackColor = true;
            this.gererService.Click += new System.EventHandler(this.gererService_Click);
            // 
            // dsservice
            // 
            this.dsservice.AutoSize = true;
            this.dsservice.Location = new System.Drawing.Point(5, 53);
            this.dsservice.Name = "dsservice";
            this.dsservice.Size = new System.Drawing.Size(118, 13);
            this.dsservice.TabIndex = 1;
            this.dsservice.Text = "Les différents services :";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categorie,
            this.nom_des_services,
            this.prix_unitaire});
            this.dataGridView3.Location = new System.Drawing.Point(5, 69);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(899, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // categorie
            // 
            this.categorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categorie.HeaderText = "Catégorie";
            this.categorie.Name = "categorie";
            this.categorie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nom_des_services
            // 
            this.nom_des_services.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_des_services.HeaderText = "Nom des services";
            this.nom_des_services.Name = "nom_des_services";
            this.nom_des_services.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // prix_unitaire
            // 
            this.prix_unitaire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prix_unitaire.HeaderText = "Prix unitaire";
            this.prix_unitaire.Name = "prix_unitaire";
            this.prix_unitaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // devispage
            // 
            this.devispage.Controls.Add(this.gererDevis);
            this.devispage.Controls.Add(this.filtreDevis);
            this.devispage.Controls.Add(this.ldDevis);
            this.devispage.Controls.Add(this.dataGridView4);
            this.devispage.Location = new System.Drawing.Point(4, 22);
            this.devispage.Margin = new System.Windows.Forms.Padding(2);
            this.devispage.Name = "devispage";
            this.devispage.Padding = new System.Windows.Forms.Padding(2);
            this.devispage.Size = new System.Drawing.Size(928, 488);
            this.devispage.TabIndex = 2;
            this.devispage.Text = "Devis";
            this.devispage.UseVisualStyleBackColor = true;
            // 
            // gererDevis
            // 
            this.gererDevis.Location = new System.Drawing.Point(806, 41);
            this.gererDevis.Name = "gererDevis";
            this.gererDevis.Size = new System.Drawing.Size(75, 23);
            this.gererDevis.TabIndex = 3;
            this.gererDevis.Text = "Gérer";
            this.gererDevis.UseVisualStyleBackColor = true;
            this.gererDevis.Click += new System.EventHandler(this.gererDevis_Click);
            // 
            // filtreDevis
            // 
            this.filtreDevis.FormattingEnabled = true;
            this.filtreDevis.Location = new System.Drawing.Point(712, 43);
            this.filtreDevis.Name = "filtreDevis";
            this.filtreDevis.Size = new System.Drawing.Size(75, 21);
            this.filtreDevis.TabIndex = 2;
            this.filtreDevis.Text = "Filtre";
            // 
            // ldDevis
            // 
            this.ldDevis.AutoSize = true;
            this.ldDevis.Location = new System.Drawing.Point(5, 53);
            this.ldDevis.Name = "ldDevis";
            this.ldDevis.Size = new System.Drawing.Size(83, 13);
            this.ldDevis.TabIndex = 1;
            this.ldDevis.Text = "Liste des devis :";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDevis,
            this.nomClient,
            this.prixTotal});
            this.dataGridView4.Location = new System.Drawing.Point(5, 69);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(901, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // numDevis
            // 
            this.numDevis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numDevis.HeaderText = "Numéro du devis";
            this.numDevis.Name = "numDevis";
            // 
            // nomClient
            // 
            this.nomClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomClient.HeaderText = "Nom du client";
            this.nomClient.Name = "nomClient";
            // 
            // prixTotal
            // 
            this.prixTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prixTotal.HeaderText = "Prix total";
            this.prixTotal.Name = "prixTotal";
            // 
            // clientpage
            // 
            this.clientpage.Controls.Add(this.addClient);
            this.clientpage.Controls.Add(this.gererClient);
            this.clientpage.Controls.Add(this.listecliClient);
            this.clientpage.Controls.Add(this.dataGridView5);
            this.clientpage.Location = new System.Drawing.Point(4, 22);
            this.clientpage.Margin = new System.Windows.Forms.Padding(2);
            this.clientpage.Name = "clientpage";
            this.clientpage.Padding = new System.Windows.Forms.Padding(2);
            this.clientpage.Size = new System.Drawing.Size(928, 488);
            this.clientpage.TabIndex = 3;
            this.clientpage.Text = "Client";
            this.clientpage.UseVisualStyleBackColor = true;
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(782, 40);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(75, 23);
            this.addClient.TabIndex = 3;
            this.addClient.Text = "Ajouter";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // gererClient
            // 
            this.gererClient.Location = new System.Drawing.Point(701, 40);
            this.gererClient.Name = "gererClient";
            this.gererClient.Size = new System.Drawing.Size(75, 23);
            this.gererClient.TabIndex = 2;
            this.gererClient.Text = "Gérer";
            this.gererClient.UseVisualStyleBackColor = true;
            this.gererClient.Click += new System.EventHandler(this.gererClient_Click);
            // 
            // listecliClient
            // 
            this.listecliClient.AutoSize = true;
            this.listecliClient.Location = new System.Drawing.Point(5, 53);
            this.listecliClient.Name = "listecliClient";
            this.listecliClient.Size = new System.Drawing.Size(88, 13);
            this.listecliClient.TabIndex = 1;
            this.listecliClient.Text = "Liste des clients :";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroClient,
            this.nomClientc});
            this.dataGridView5.Location = new System.Drawing.Point(5, 69);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(859, 150);
            this.dataGridView5.TabIndex = 0;
            // 
            // numeroClient
            // 
            this.numeroClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroClient.HeaderText = "Numéro client";
            this.numeroClient.Name = "numeroClient";
            // 
            // nomClientc
            // 
            this.nomClientc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomClientc.HeaderText = "Nom des clients";
            this.nomClientc.Name = "nomClientc";
            // 
            // parametrepage
            // 
            this.parametrepage.Location = new System.Drawing.Point(4, 22);
            this.parametrepage.Margin = new System.Windows.Forms.Padding(2);
            this.parametrepage.Name = "parametrepage";
            this.parametrepage.Padding = new System.Windows.Forms.Padding(2);
            this.parametrepage.Size = new System.Drawing.Size(928, 488);
            this.parametrepage.TabIndex = 4;
            this.parametrepage.Text = "Paramètres";
            this.parametrepage.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(8, 8);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(97, 93);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // formAF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1047, 530);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pageselection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formAF";
            this.Text = "AutoFact";
            this.pageselection.ResumeLayout(false);
            this.firstpage.ResumeLayout(false);
            this.firstpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.servicespage.ResumeLayout(false);
            this.servicespage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.devispage.ResumeLayout(false);
            this.devispage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.clientpage.ResumeLayout(false);
            this.clientpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pageselection;
        private System.Windows.Forms.TabPage firstpage;
        private System.Windows.Forms.TabPage servicespage;
        private System.Windows.Forms.TabPage devispage;
        private System.Windows.Forms.TabPage clientpage;
        private System.Windows.Forms.TabPage parametrepage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label cadashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colservices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colannee;
        private System.Windows.Forms.Label dfdashboard;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label rvs;
        private System.Windows.Forms.Label dsservice;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox filtrecatservice;
        private System.Windows.Forms.Button addService;
        private System.Windows.Forms.Button gererService;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_des_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_unitaire;
        private System.Windows.Forms.Button gererDevis;
        private System.Windows.Forms.ComboBox filtreDevis;
        private System.Windows.Forms.Label ldDevis;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDevis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotal;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button gererClient;
        private System.Windows.Forms.Label listecliClient;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientc;
    }
}


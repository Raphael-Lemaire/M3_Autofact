﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAF));
            this.pageselection = new System.Windows.Forms.TabControl();
            this.firstpage = new System.Windows.Forms.TabPage();
            this.loadgraph = new CustomControls.RJControls.RButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rvs = new System.Windows.Forms.Label();
            this.dfdashboard = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cadashboard = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colservices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colannee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicespage = new System.Windows.Forms.TabPage();
            this.rButton2 = new CustomControls.RJControls.RButton();
            this.rButton1 = new CustomControls.RJControls.RButton();
            this.filtrecatservice = new System.Windows.Forms.ComboBox();
            this.dsservice = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_des_services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_unitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devispage = new System.Windows.Forms.TabPage();
            this.LoadGridview4 = new CustomControls.RJControls.RButton();
            this.rButton3 = new CustomControls.RJControls.RButton();
            this.filtreDevis = new System.Windows.Forms.ComboBox();
            this.ldDevis = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.clientpage = new System.Windows.Forms.TabPage();
            this.bSearch = new CustomControls.RJControls.RButton();
            this.tbScreachCustomer = new System.Windows.Forms.TextBox();
            this.ReadCustomer = new CustomControls.RJControls.RButton();
            this.Button_Delete = new CustomControls.RJControls.RButton();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.rButton5 = new CustomControls.RJControls.RButton();
            this.rButton4 = new CustomControls.RJControls.RButton();
            this.listecliClient = new System.Windows.Forms.Label();
            this.parametrepage = new System.Windows.Forms.TabPage();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pageselection.SuspendLayout();
            this.firstpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.servicespage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.devispage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.clientpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
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
            this.pageselection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageselection.ItemSize = new System.Drawing.Size(64, 30);
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
            this.firstpage.Controls.Add(this.loadgraph);
            this.firstpage.Controls.Add(this.chart1);
            this.firstpage.Controls.Add(this.rvs);
            this.firstpage.Controls.Add(this.dfdashboard);
            this.firstpage.Controls.Add(this.dataGridView2);
            this.firstpage.Controls.Add(this.cadashboard);
            this.firstpage.Controls.Add(this.dataGridView1);
            this.firstpage.Location = new System.Drawing.Point(4, 34);
            this.firstpage.Margin = new System.Windows.Forms.Padding(2);
            this.firstpage.Name = "firstpage";
            this.firstpage.Padding = new System.Windows.Forms.Padding(2);
            this.firstpage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.firstpage.Size = new System.Drawing.Size(928, 476);
            this.firstpage.TabIndex = 0;
            this.firstpage.Text = "Dashboard";
            this.firstpage.UseVisualStyleBackColor = true;
            // 
            // loadgraph
            // 
            this.loadgraph.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loadgraph.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.loadgraph.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loadgraph.BorderRadius = 15;
            this.loadgraph.BorderSize = 0;
            this.loadgraph.FlatAppearance.BorderSize = 0;
            this.loadgraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadgraph.ForeColor = System.Drawing.Color.White;
            this.loadgraph.Location = new System.Drawing.Point(636, 39);
            this.loadgraph.Margin = new System.Windows.Forms.Padding(2);
            this.loadgraph.Name = "loadgraph";
            this.loadgraph.Size = new System.Drawing.Size(112, 32);
            this.loadgraph.TabIndex = 6;
            this.loadgraph.Text = "LoadGraph";
            this.loadgraph.TextColor = System.Drawing.Color.White;
            this.loadgraph.UseVisualStyleBackColor = false;
            this.loadgraph.Click += new System.EventHandler(this.rButton6_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(541, 107);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "CA";
            series3.YValuesPerPoint = 4;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(350, 350);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // rvs
            // 
            this.rvs.AutoSize = true;
            this.rvs.Location = new System.Drawing.Point(538, 82);
            this.rvs.Name = "rvs";
            this.rvs.Size = new System.Drawing.Size(214, 16);
            this.rvs.TabIndex = 4;
            this.rvs.Text = "Répartition des ventes de services";
            this.rvs.UseWaitCursor = true;
            this.rvs.Click += new System.EventHandler(this.rvs_Click);
            // 
            // dfdashboard
            // 
            this.dfdashboard.AutoSize = true;
            this.dfdashboard.Location = new System.Drawing.Point(5, 238);
            this.dfdashboard.Name = "dfdashboard";
            this.dfdashboard.Size = new System.Drawing.Size(130, 16);
            this.dfdashboard.TabIndex = 3;
            this.dfdashboard.Text = "Dernières facturation";
            this.dfdashboard.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 257);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(474, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // cadashboard
            // 
            this.cadashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadashboard.AutoSize = true;
            this.cadashboard.Location = new System.Drawing.Point(5, 21);
            this.cadashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cadashboard.Name = "cadashboard";
            this.cadashboard.Size = new System.Drawing.Size(95, 16);
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
            this.servicespage.Controls.Add(this.rButton2);
            this.servicespage.Controls.Add(this.rButton1);
            this.servicespage.Controls.Add(this.filtrecatservice);
            this.servicespage.Controls.Add(this.dsservice);
            this.servicespage.Controls.Add(this.dataGridView3);
            this.servicespage.Location = new System.Drawing.Point(4, 34);
            this.servicespage.Margin = new System.Windows.Forms.Padding(2);
            this.servicespage.Name = "servicespage";
            this.servicespage.Padding = new System.Windows.Forms.Padding(2);
            this.servicespage.Size = new System.Drawing.Size(928, 476);
            this.servicespage.TabIndex = 1;
            this.servicespage.Text = "Services";
            this.servicespage.UseVisualStyleBackColor = true;
            this.servicespage.Click += new System.EventHandler(this.servicespage_Click);
            // 
            // rButton2
            // 
            this.rButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.rButton2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton2.BorderRadius = 12;
            this.rButton2.BorderSize = 0;
            this.rButton2.FlatAppearance.BorderSize = 0;
            this.rButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton2.ForeColor = System.Drawing.Color.White;
            this.rButton2.Location = new System.Drawing.Point(823, 31);
            this.rButton2.Name = "rButton2";
            this.rButton2.Size = new System.Drawing.Size(100, 32);
            this.rButton2.TabIndex = 6;
            this.rButton2.Text = "Ajouter";
            this.rButton2.TextColor = System.Drawing.Color.White;
            this.rButton2.UseVisualStyleBackColor = false;
            this.rButton2.Click += new System.EventHandler(this.rButton2_Click);
            // 
            // rButton1
            // 
            this.rButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.rButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton1.BorderRadius = 12;
            this.rButton1.BorderSize = 0;
            this.rButton1.FlatAppearance.BorderSize = 0;
            this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton1.ForeColor = System.Drawing.Color.White;
            this.rButton1.Location = new System.Drawing.Point(717, 31);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(100, 32);
            this.rButton1.TabIndex = 5;
            this.rButton1.Text = "Gérer";
            this.rButton1.TextColor = System.Drawing.Color.White;
            this.rButton1.UseVisualStyleBackColor = false;
            this.rButton1.Click += new System.EventHandler(this.rButton1_Click);
            // 
            // filtrecatservice
            // 
            this.filtrecatservice.FormattingEnabled = true;
            this.filtrecatservice.Items.AddRange(new object[] {
            "Par défaut",
            "Service",
            "Produit"});
            this.filtrecatservice.Location = new System.Drawing.Point(636, 35);
            this.filtrecatservice.Name = "filtrecatservice";
            this.filtrecatservice.Size = new System.Drawing.Size(75, 24);
            this.filtrecatservice.TabIndex = 4;
            this.filtrecatservice.Text = "Catégorie";
            this.filtrecatservice.UseWaitCursor = true;
            // 
            // dsservice
            // 
            this.dsservice.AutoSize = true;
            this.dsservice.Location = new System.Drawing.Point(5, 53);
            this.dsservice.Name = "dsservice";
            this.dsservice.Size = new System.Drawing.Size(146, 16);
            this.dsservice.TabIndex = 1;
            this.dsservice.Text = "Les différents services :";
            this.dsservice.UseWaitCursor = true;
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
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(918, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // categorie
            // 
            this.categorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categorie.HeaderText = "Catégorie";
            this.categorie.MinimumWidth = 6;
            this.categorie.Name = "categorie";
            this.categorie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nom_des_services
            // 
            this.nom_des_services.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_des_services.HeaderText = "Nom des services";
            this.nom_des_services.MinimumWidth = 6;
            this.nom_des_services.Name = "nom_des_services";
            this.nom_des_services.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // prix_unitaire
            // 
            this.prix_unitaire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prix_unitaire.HeaderText = "Prix unitaire";
            this.prix_unitaire.MinimumWidth = 6;
            this.prix_unitaire.Name = "prix_unitaire";
            this.prix_unitaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // devispage
            // 
            this.devispage.Controls.Add(this.LoadGridview4);
            this.devispage.Controls.Add(this.rButton3);
            this.devispage.Controls.Add(this.filtreDevis);
            this.devispage.Controls.Add(this.ldDevis);
            this.devispage.Controls.Add(this.dataGridView4);
            this.devispage.Location = new System.Drawing.Point(4, 34);
            this.devispage.Margin = new System.Windows.Forms.Padding(2);
            this.devispage.Name = "devispage";
            this.devispage.Padding = new System.Windows.Forms.Padding(2);
            this.devispage.Size = new System.Drawing.Size(928, 476);
            this.devispage.TabIndex = 2;
            this.devispage.Text = "Devis";
            this.devispage.UseVisualStyleBackColor = true;
            // 
            // LoadGridview4
            // 
            this.LoadGridview4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.LoadGridview4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.LoadGridview4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.LoadGridview4.BorderRadius = 15;
            this.LoadGridview4.BorderSize = 0;
            this.LoadGridview4.FlatAppearance.BorderSize = 0;
            this.LoadGridview4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadGridview4.ForeColor = System.Drawing.Color.White;
            this.LoadGridview4.Location = new System.Drawing.Point(8, 18);
            this.LoadGridview4.Margin = new System.Windows.Forms.Padding(2);
            this.LoadGridview4.Name = "LoadGridview4";
            this.LoadGridview4.Size = new System.Drawing.Size(149, 32);
            this.LoadGridview4.TabIndex = 5;
            this.LoadGridview4.Text = "Charger les données";
            this.LoadGridview4.TextColor = System.Drawing.Color.White;
            this.LoadGridview4.UseVisualStyleBackColor = false;
            this.LoadGridview4.Click += new System.EventHandler(this.LoadGridview4_Click);
            // 
            // rButton3
            // 
            this.rButton3.BackColor = System.Drawing.Color.RoyalBlue;
            this.rButton3.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton3.BorderRadius = 12;
            this.rButton3.BorderSize = 0;
            this.rButton3.FlatAppearance.BorderSize = 0;
            this.rButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton3.ForeColor = System.Drawing.Color.White;
            this.rButton3.Location = new System.Drawing.Point(823, 31);
            this.rButton3.Name = "rButton3";
            this.rButton3.Size = new System.Drawing.Size(100, 32);
            this.rButton3.TabIndex = 4;
            this.rButton3.Text = "Gérer";
            this.rButton3.TextColor = System.Drawing.Color.White;
            this.rButton3.UseVisualStyleBackColor = false;
            this.rButton3.Click += new System.EventHandler(this.rButton3_Click);
            // 
            // filtreDevis
            // 
            this.filtreDevis.FormattingEnabled = true;
            this.filtreDevis.Location = new System.Drawing.Point(742, 35);
            this.filtreDevis.Name = "filtreDevis";
            this.filtreDevis.Size = new System.Drawing.Size(75, 24);
            this.filtreDevis.TabIndex = 2;
            this.filtreDevis.Text = "Filtre";
            this.filtreDevis.UseWaitCursor = true;
            // 
            // ldDevis
            // 
            this.ldDevis.AutoSize = true;
            this.ldDevis.Location = new System.Drawing.Point(5, 53);
            this.ldDevis.Name = "ldDevis";
            this.ldDevis.Size = new System.Drawing.Size(103, 16);
            this.ldDevis.TabIndex = 1;
            this.ldDevis.Text = "Liste des devis :";
            this.ldDevis.UseWaitCursor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(5, 69);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(918, 150);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // clientpage
            // 
            this.clientpage.Controls.Add(this.bSearch);
            this.clientpage.Controls.Add(this.tbScreachCustomer);
            this.clientpage.Controls.Add(this.ReadCustomer);
            this.clientpage.Controls.Add(this.Button_Delete);
            this.clientpage.Controls.Add(this.dataGridViewCustomer);
            this.clientpage.Controls.Add(this.rButton5);
            this.clientpage.Controls.Add(this.rButton4);
            this.clientpage.Controls.Add(this.listecliClient);
            this.clientpage.Location = new System.Drawing.Point(4, 34);
            this.clientpage.Margin = new System.Windows.Forms.Padding(2);
            this.clientpage.Name = "clientpage";
            this.clientpage.Padding = new System.Windows.Forms.Padding(2);
            this.clientpage.Size = new System.Drawing.Size(928, 476);
            this.clientpage.TabIndex = 3;
            this.clientpage.Text = "Client";
            this.clientpage.UseVisualStyleBackColor = true;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.bSearch.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.bSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bSearch.BorderRadius = 10;
            this.bSearch.BorderSize = 0;
            this.bSearch.FlatAppearance.BorderSize = 0;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.White;
            this.bSearch.Location = new System.Drawing.Point(595, 106);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(116, 25);
            this.bSearch.TabIndex = 10;
            this.bSearch.Text = "Recherche";
            this.bSearch.TextColor = System.Drawing.Color.White;
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbScreachCustomer
            // 
            this.tbScreachCustomer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbScreachCustomer.Location = new System.Drawing.Point(717, 107);
            this.tbScreachCustomer.Name = "tbScreachCustomer";
            this.tbScreachCustomer.Size = new System.Drawing.Size(203, 22);
            this.tbScreachCustomer.TabIndex = 9;
            this.tbScreachCustomer.TextChanged += new System.EventHandler(this.bSearch_Click);
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
            this.ReadCustomer.Location = new System.Drawing.Point(191, 86);
            this.ReadCustomer.Name = "ReadCustomer";
            this.ReadCustomer.Size = new System.Drawing.Size(150, 40);
            this.ReadCustomer.TabIndex = 8;
            this.ReadCustomer.Text = "Afficher";
            this.ReadCustomer.TextColor = System.Drawing.Color.White;
            this.ReadCustomer.UseVisualStyleBackColor = false;
            this.ReadCustomer.Click += new System.EventHandler(this.dataGridViewCustomer_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.DarkCyan;
            this.Button_Delete.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.Button_Delete.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Button_Delete.BorderRadius = 15;
            this.Button_Delete.BorderSize = 0;
            this.Button_Delete.FlatAppearance.BorderSize = 0;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.ForeColor = System.Drawing.Color.White;
            this.Button_Delete.Location = new System.Drawing.Point(8, 86);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(150, 40);
            this.Button_Delete.TabIndex = 7;
            this.Button_Delete.Text = "Supprimer";
            this.Button_Delete.TextColor = System.Drawing.Color.White;
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(5, 147);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(915, 290);
            this.dataGridViewCustomer.TabIndex = 6;
            // 
            // rButton5
            // 
            this.rButton5.BackColor = System.Drawing.Color.RoyalBlue;
            this.rButton5.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton5.BorderRadius = 12;
            this.rButton5.BorderSize = 0;
            this.rButton5.FlatAppearance.BorderSize = 0;
            this.rButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton5.ForeColor = System.Drawing.Color.White;
            this.rButton5.Location = new System.Drawing.Point(823, 31);
            this.rButton5.Name = "rButton5";
            this.rButton5.Size = new System.Drawing.Size(100, 32);
            this.rButton5.TabIndex = 5;
            this.rButton5.Text = "Ajouter";
            this.rButton5.TextColor = System.Drawing.Color.White;
            this.rButton5.UseVisualStyleBackColor = false;
            this.rButton5.Click += new System.EventHandler(this.rButton5_Click);
            // 
            // rButton4
            // 
            this.rButton4.BackColor = System.Drawing.Color.RoyalBlue;
            this.rButton4.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton4.BorderRadius = 12;
            this.rButton4.BorderSize = 0;
            this.rButton4.FlatAppearance.BorderSize = 0;
            this.rButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton4.ForeColor = System.Drawing.Color.White;
            this.rButton4.Location = new System.Drawing.Point(717, 31);
            this.rButton4.Name = "rButton4";
            this.rButton4.Size = new System.Drawing.Size(100, 32);
            this.rButton4.TabIndex = 4;
            this.rButton4.Text = "Gérer";
            this.rButton4.TextColor = System.Drawing.Color.White;
            this.rButton4.UseVisualStyleBackColor = false;
            this.rButton4.Click += new System.EventHandler(this.rButton4_Click);
            // 
            // listecliClient
            // 
            this.listecliClient.AutoSize = true;
            this.listecliClient.Location = new System.Drawing.Point(5, 53);
            this.listecliClient.Name = "listecliClient";
            this.listecliClient.Size = new System.Drawing.Size(108, 16);
            this.listecliClient.TabIndex = 1;
            this.listecliClient.Text = "Liste des clients :";
            this.listecliClient.UseWaitCursor = true;
            // 
            // parametrepage
            // 
            this.parametrepage.Location = new System.Drawing.Point(4, 34);
            this.parametrepage.Margin = new System.Windows.Forms.Padding(2);
            this.parametrepage.Name = "parametrepage";
            this.parametrepage.Padding = new System.Windows.Forms.Padding(2);
            this.parametrepage.Size = new System.Drawing.Size(928, 476);
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
            this.Load += new System.EventHandler(this.formAF_Load);
            this.pageselection.ResumeLayout(false);
            this.firstpage.ResumeLayout(false);
            this.firstpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pageselection;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_des_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_unitaire;
        private System.Windows.Forms.ComboBox filtreDevis;
        private System.Windows.Forms.Label ldDevis;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label listecliClient;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage firstpage;
        private CustomControls.RJControls.RButton rButton1;
        private CustomControls.RJControls.RButton rButton2;
        private CustomControls.RJControls.RButton rButton3;
        private CustomControls.RJControls.RButton rButton5;
        private CustomControls.RJControls.RButton rButton4;
        private CustomControls.RJControls.RButton loadgraph;
        private CustomControls.RJControls.RButton LoadGridview4;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private CustomControls.RJControls.RButton Button_Delete;
        private CustomControls.RJControls.RButton ReadCustomer;
        private System.Windows.Forms.TextBox tbScreachCustomer;
        private CustomControls.RJControls.RButton bSearch;
    }
}


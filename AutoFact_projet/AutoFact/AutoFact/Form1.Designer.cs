
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.rButton3 = new CustomControls.RJControls.RButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RefreshButtonQuotation = new CustomControls.RJControls.RButton();
            this.dataGridViewQuotation = new System.Windows.Forms.DataGridView();
            this.rButton7 = new CustomControls.RJControls.RButton();
            this.rButton8 = new CustomControls.RJControls.RButton();
            this.label1 = new System.Windows.Forms.Label();
            this.clientpage = new System.Windows.Forms.TabPage();
            this.bSearch = new CustomControls.RJControls.RButton();
            this.tbScreachCustomer = new System.Windows.Forms.TextBox();
            this.ReadCustomer = new CustomControls.RJControls.RButton();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.addButton = new CustomControls.RJControls.RButton();
            this.GererButton = new CustomControls.RJControls.RButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotation)).BeginInit();
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(541, 107);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "CA";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
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
            this.rvs.Size = new System.Drawing.Size(215, 16);
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
            this.dfdashboard.Size = new System.Drawing.Size(131, 16);
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
            this.cadashboard.Size = new System.Drawing.Size(96, 16);
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
            this.dsservice.Size = new System.Drawing.Size(147, 16);
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
            this.devispage.Controls.Add(this.rButton3);
            this.devispage.Controls.Add(this.textBox1);
            this.devispage.Controls.Add(this.RefreshButtonQuotation);
            this.devispage.Controls.Add(this.dataGridViewQuotation);
            this.devispage.Controls.Add(this.rButton7);
            this.devispage.Controls.Add(this.rButton8);
            this.devispage.Controls.Add(this.label1);
            this.devispage.Location = new System.Drawing.Point(4, 34);
            this.devispage.Margin = new System.Windows.Forms.Padding(2);
            this.devispage.Name = "devispage";
            this.devispage.Padding = new System.Windows.Forms.Padding(2);
            this.devispage.Size = new System.Drawing.Size(928, 476);
            this.devispage.TabIndex = 2;
            this.devispage.Text = "Devis";
            this.devispage.UseVisualStyleBackColor = true;
            this.devispage.Click += new System.EventHandler(this.devispage_Click);
            // 
            // rButton3
            // 
            this.rButton3.BackColor = System.Drawing.Color.SkyBlue;
            this.rButton3.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton3.BorderRadius = 10;
            this.rButton3.BorderSize = 0;
            this.rButton3.FlatAppearance.BorderSize = 0;
            this.rButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton3.ForeColor = System.Drawing.Color.White;
            this.rButton3.Location = new System.Drawing.Point(595, 107);
            this.rButton3.Name = "rButton3";
            this.rButton3.Size = new System.Drawing.Size(116, 25);
            this.rButton3.TabIndex = 24;
            this.rButton3.Text = "Recherche";
            this.rButton3.TextColor = System.Drawing.Color.White;
            this.rButton3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox1.Location = new System.Drawing.Point(717, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 23;
            // 
            // RefreshButtonQuotation
            // 
            this.RefreshButtonQuotation.BackColor = System.Drawing.Color.DarkCyan;
            this.RefreshButtonQuotation.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.RefreshButtonQuotation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RefreshButtonQuotation.BorderRadius = 15;
            this.RefreshButtonQuotation.BorderSize = 0;
            this.RefreshButtonQuotation.FlatAppearance.BorderSize = 0;
            this.RefreshButtonQuotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButtonQuotation.ForeColor = System.Drawing.Color.White;
            this.RefreshButtonQuotation.Location = new System.Drawing.Point(8, 99);
            this.RefreshButtonQuotation.Name = "RefreshButtonQuotation";
            this.RefreshButtonQuotation.Size = new System.Drawing.Size(150, 40);
            this.RefreshButtonQuotation.TabIndex = 22;
            this.RefreshButtonQuotation.Text = "Actualiser";
            this.RefreshButtonQuotation.TextColor = System.Drawing.Color.White;
            this.RefreshButtonQuotation.UseVisualStyleBackColor = false;
            this.RefreshButtonQuotation.Click += new System.EventHandler(this.RefreshButtonQuotation_Click);
            // 
            // dataGridViewQuotation
            // 
            this.dataGridViewQuotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuotation.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewQuotation.Location = new System.Drawing.Point(5, 154);
            this.dataGridViewQuotation.Name = "dataGridViewQuotation";
            this.dataGridViewQuotation.RowHeadersWidth = 51;
            this.dataGridViewQuotation.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewQuotation.Size = new System.Drawing.Size(915, 290);
            this.dataGridViewQuotation.TabIndex = 21;
            this.dataGridViewQuotation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuotation_CellContentClick);
            // 
            // rButton7
            // 
            this.rButton7.BackColor = System.Drawing.Color.RoyalBlue;
            this.rButton7.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton7.BorderRadius = 12;
            this.rButton7.BorderSize = 0;
            this.rButton7.FlatAppearance.BorderSize = 0;
            this.rButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton7.ForeColor = System.Drawing.Color.White;
            this.rButton7.Location = new System.Drawing.Point(823, 32);
            this.rButton7.Name = "rButton7";
            this.rButton7.Size = new System.Drawing.Size(100, 32);
            this.rButton7.TabIndex = 20;
            this.rButton7.Text = "Ajouter";
            this.rButton7.TextColor = System.Drawing.Color.White;
            this.rButton7.UseVisualStyleBackColor = false;
            this.rButton7.Click += new System.EventHandler(this.rButton7_Click);
            // 
            // rButton8
            // 
            this.rButton8.BackColor = System.Drawing.Color.RoyalBlue;
            this.rButton8.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rButton8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton8.BorderRadius = 12;
            this.rButton8.BorderSize = 0;
            this.rButton8.FlatAppearance.BorderSize = 0;
            this.rButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton8.ForeColor = System.Drawing.Color.White;
            this.rButton8.Location = new System.Drawing.Point(717, 32);
            this.rButton8.Name = "rButton8";
            this.rButton8.Size = new System.Drawing.Size(100, 32);
            this.rButton8.TabIndex = 19;
            this.rButton8.Text = "Gérer";
            this.rButton8.TextColor = System.Drawing.Color.White;
            this.rButton8.UseVisualStyleBackColor = false;
            this.rButton8.Click += new System.EventHandler(this.rButton8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Liste des devis:";
            this.label1.UseWaitCursor = true;
            // 
            // clientpage
            // 
            this.clientpage.Controls.Add(this.bSearch);
            this.clientpage.Controls.Add(this.tbScreachCustomer);
            this.clientpage.Controls.Add(this.ReadCustomer);
            this.clientpage.Controls.Add(this.dataGridViewCustomer);
            this.clientpage.Controls.Add(this.addButton);
            this.clientpage.Controls.Add(this.GererButton);
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
            this.bSearch.Location = new System.Drawing.Point(595, 107);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(116, 25);
            this.bSearch.TabIndex = 17;
            this.bSearch.Text = "Recherche";
            this.bSearch.TextColor = System.Drawing.Color.White;
            this.bSearch.UseVisualStyleBackColor = false;
            // 
            // tbScreachCustomer
            // 
            this.tbScreachCustomer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbScreachCustomer.Location = new System.Drawing.Point(717, 108);
            this.tbScreachCustomer.Name = "tbScreachCustomer";
            this.tbScreachCustomer.Size = new System.Drawing.Size(203, 22);
            this.tbScreachCustomer.TabIndex = 16;
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
            this.ReadCustomer.Location = new System.Drawing.Point(8, 99);
            this.ReadCustomer.Name = "ReadCustomer";
            this.ReadCustomer.Size = new System.Drawing.Size(150, 40);
            this.ReadCustomer.TabIndex = 15;
            this.ReadCustomer.Text = "Actualiser";
            this.ReadCustomer.TextColor = System.Drawing.Color.White;
            this.ReadCustomer.UseVisualStyleBackColor = false;
            this.ReadCustomer.Click += new System.EventHandler(this.ReadCustomer_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(5, 154);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(915, 290);
            this.dataGridViewCustomer.TabIndex = 14;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 12;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(823, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 32);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Ajouter";
            this.addButton.TextColor = System.Drawing.Color.White;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // GererButton
            // 
            this.GererButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.GererButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.GererButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.GererButton.BorderRadius = 12;
            this.GererButton.BorderSize = 0;
            this.GererButton.FlatAppearance.BorderSize = 0;
            this.GererButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GererButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GererButton.ForeColor = System.Drawing.Color.White;
            this.GererButton.Location = new System.Drawing.Point(717, 32);
            this.GererButton.Name = "GererButton";
            this.GererButton.Size = new System.Drawing.Size(100, 32);
            this.GererButton.TabIndex = 12;
            this.GererButton.Text = "Gérer";
            this.GererButton.TextColor = System.Drawing.Color.White;
            this.GererButton.UseVisualStyleBackColor = false;
            this.GererButton.Click += new System.EventHandler(this.GererButton_Click_1);
            // 
            // listecliClient
            // 
            this.listecliClient.AutoSize = true;
            this.listecliClient.Location = new System.Drawing.Point(5, 54);
            this.listecliClient.Name = "listecliClient";
            this.listecliClient.Size = new System.Drawing.Size(109, 16);
            this.listecliClient.TabIndex = 11;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotation)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage firstpage;
        private CustomControls.RJControls.RButton rButton1;
        private CustomControls.RJControls.RButton rButton2;
        private CustomControls.RJControls.RButton loadgraph;
        private CustomControls.RJControls.RButton rButton3;
        private System.Windows.Forms.TextBox textBox1;
        private CustomControls.RJControls.RButton RefreshButtonQuotation;
        private System.Windows.Forms.DataGridView dataGridViewQuotation;
        private CustomControls.RJControls.RButton rButton7;
        private CustomControls.RJControls.RButton rButton8;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RButton bSearch;
        private System.Windows.Forms.TextBox tbScreachCustomer;
        private CustomControls.RJControls.RButton ReadCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private CustomControls.RJControls.RButton addButton;
        private CustomControls.RJControls.RButton GererButton;
        private System.Windows.Forms.Label listecliClient;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using AutoFact.model;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Controls;
using System.Diagnostics.Eventing.Reader;

namespace AutoFact
{
    public partial class formAF : Form
    {
        public formAF()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rvs_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            gService gS = new gService();
            gS.Show();
        }

        private void rButton2_Click(object sender, EventArgs e)
        {
            aService aS = new aService();
            aS.Show();
        }

        private void rButton3_Click(object sender, EventArgs e)
        {

        }



        private void formAF_Load(object sender, EventArgs e)
        {
            CustomerModel.GetCustomer(dataGridViewCustomer);
            QuotationModel.getQuotation(dataGridViewQuotation);
            ServiceModel.GetProduct(dataGridView3);
        }
        private void fillchart()
        {
            SQLiteConnection db = Database.getInstance().getConnection();

            //List<String> list = new List<String>();
            //SQLiteCommand sqlite_cmd;
            //string Createsql = @"";

            //SQLiteCommand cmd = new SQLiteCommand(Createsql, db);
            //Creer un data reader et execute la commande
            //SQLiteDataReader dataReader = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("SELECT name, unit_price FROM Product ORDER BY unit_price DESC", db);
            adapt.Fill(ds);
            chart1.DataSource = ds;

            //chart1.Series["CA"].Points.AddXY(ds);

            chart1.Series["CA"].XValueMember = "name";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["CA"].YValueMembers = "unit_price";
            chart1.Series["CA"].LabelForeColor = Color.Transparent;
        }
        private void rButton6_Click(object sender, EventArgs e)
        {
            fillchart();

            /*SQLiteConnection db = Database.getInstance().getConnection();

            //List<String> list = new List<String>();
            //SQLiteCommand sqlite_cmd;
            //string Createsql = @"";

            //SQLiteCommand cmd = new SQLiteCommand(Createsql, db);
            //Creer un data reader et execute la commande
            //SQLiteDataReader dataReader = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter("SELECT name, unit_price FROM Product", db);
            adapt.Fill(ds);
            chart1.DataSource = ds;

            chart1.Series["CA"].XValueMember = "name";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["CA"].YValueMembers = "unit_price";



            /*using (SQLiteCommand cmd = new SQLiteCommand("SELECT name, unit_price FROM Product;", db))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(dr[0].ToString());            
                        chart1.Series["CA"].YValueMembers = dr[0];
                    }
                }
            }

            /*foreach(String uneentre in list)
            {
                //chart1.Series["CA"].Points.AddXY();
                
            }
           /* sqlite_cmd = db.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();

            chart1.Series["CA"].Points.AddXY("Ajay", "10000");
            chart1.Series["CA"].Points.AddXY("Ramesh", "8000");
            chart1.Series["CA"].Points.AddXY("Ankit", "7000");
            chart1.Series["CA"].Points.AddXY("Gurmeet", "10000");
            chart1.Series["CA"].Points.AddXY("Suresh", "8500");*/
        }

        private void servicespage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void LoadGridview4_Click(object sender, EventArgs e)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT (id) as Numéro, (name) as Nom, (total_price) as Total FROM quotation", db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);
            dataGridViewQuotation.DataSource = dt;
            db.Close();



        }

        private void dataGridViewCustomer_Click(object sender, EventArgs e)
        {
            CustomerModel.GetCustomer(dataGridViewCustomer);

        }


        //todo suppression des données 
        private void bSearch_Click(object sender, EventArgs e)
        {
            string valeur = tbScreachCustomer.Text;
            CustomerModel.recherche_client(valeur, dataGridViewCustomer);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
        }

        private void GererButton_Click(object sender, EventArgs e)
        {
        }

        private void GererButton_Click_1(object sender, EventArgs e)
        {
            gClient gC = new gClient();
            gC.Show();
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            aClient aC = new aClient();
            aC.Show();
        }

        private void ReadCustomer_Click(object sender, EventArgs e)
        {
            CustomerModel.GetCustomer(dataGridViewCustomer);
        }

        private void rButton8_Click(object sender, EventArgs e)
        {
            gDevis gD = new gDevis();
            gD.Show();
        }

        private void rButton7_Click(object sender, EventArgs e)
        {
            aDevis aD = new aDevis();
            aD.Show();
        }

        private void dataGridViewQuotation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void devispage_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButtonQuotation_Click(object sender, EventArgs e)
        {
            QuotationModel.getQuotation(dataGridViewQuotation);
        }

        private void ReadService_Click(object sender, EventArgs e)
        {
            ServiceModel.GetProduct(dataGridView3);
        }
    }

}


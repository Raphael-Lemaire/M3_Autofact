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
            gDevis gD = new gDevis();
            gD.Show();
        }



        private void rButton5_Click(object sender, EventArgs e)
        {
            aClient aC = new aClient();
            aC.Show();
        }

        private void formAF_Load(object sender, EventArgs e)
        {

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
            dataGridView4.DataSource = dt;
            db.Close();



        }

        private void dataGridViewCustomer_Click(object sender, EventArgs e)
        {

            SQLiteConnection db = Database.getInstance().getConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, (first_name) as Prenom, (last_name) as 'Nom de Famille', (phone_number) as 'Numéro de téléplhone', mail, (compagny_name) as 'Nom de la compagnie' FROM customer", db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);
            dataGridViewCustomer.DataSource = dt;
            db.Close();
        }


        //todo suppression des données 
        private void bSearch_Click(object sender, EventArgs e)
        {
            string firstNameR = tbScreachCustomer.Text;


            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string querySearch = ("SELECT id, (first_name) as Prenom, (last_name) as 'Nom de Famille', (phone_number) as 'Numéro de téléplhone', mail, (compagny_name) as 'Nom de la compagnie'\r\nFROM customer\r\nWHERE first_name LIKE @firstNameR");


            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);
            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@firstNameR", firstNameR + "%");



            // Exécuter la requête d'insertion

            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);
            dataGridViewCustomer.DataSource = dt;
            db.Close();
            dataGridViewCustomer.Refresh();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            // Variable permettant d'avoir la cellule actuel
            int rowindex = dataGridViewCustomer.CurrentCell.RowIndex;
            int columnindex = dataGridViewCustomer.CurrentCell.ColumnIndex;

            // Ligne permettant de mettre la valeur de l'id 
            int id = Convert.ToInt32(dataGridViewCustomer.Rows[rowindex].Cells[columnindex].Value);

            int numRows = dataGridViewCustomer.SelectedCells.Count;
            if (numRows > 1)
            {
                string messageError = ("Vous pouvez selectioner qu'une seule cellule.");
                string titleError = ("Erreur");
                MessageBox.Show(messageError, titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Traitement en fonction de l'option choisie par l'utilisateur
                DialogResult confirmation = MessageBox.Show("Vous avez choisi de supprimer plusieur utilisateur voulez vous vraiment supprimer ces utilisateur?", "Confirmation", MessageBoxButtons.YesNo);

                //Si le client appuis sur oui aloir
                if (confirmation == DialogResult.Yes)
                {
                    CustomerModel.deleteCustommer(id);
                }
            }
        }
        private void rButton4_Click(object sender, EventArgs e)
        {

            // Ligne permettant de mettre la valeur de l'id 
            gClient gC = new gClient();
            gC.Show();
        }

    }
}

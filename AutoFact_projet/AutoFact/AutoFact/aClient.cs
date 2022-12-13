using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact
{
    public partial class aClient : Form
    {
        public aClient()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
            
                SQLiteConnection db = Database.getInstance().getConnection();
                
                string queryString = "INSERT INTO customer (first_name, last_name, phone_number, mail, compagny_name) VALUES (@firstName,@lastName,@phone_number, @mail, @compagny )";
                 SQLiteCommand sqlite_cmd = new SQLiteCommand(queryString, db);

                string firstName = tbFirstName.Text;
                string lastName = tbLastName.Text;
                string email = tbEmail.Text;
                string numberphone = tbNumberPhone.Text;
                string compagny = tbCompagny.Text;
            // Ajouter les valeurs des paramètres de la requête

                sqlite_cmd.Parameters.AddWithValue("@firstName", firstName);
                sqlite_cmd.Parameters.AddWithValue("@lastName", lastName);
                sqlite_cmd.Parameters.AddWithValue("@phone_number", numberphone);
                sqlite_cmd.Parameters.AddWithValue("@mail", email);
                sqlite_cmd.Parameters.AddWithValue("@compagny", compagny  );


                // Exécuter la requête d'insertion
                sqlite_cmd.ExecuteNonQuery();

                
     
           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            {
                formAF AF = new formAF();
                this.Hide();

            }
        }


    }
}

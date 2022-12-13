using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact.model
{
    public static class CustomerModel
    {
        public static void addCustomer(string firstName, string lastName, string email, string numberphone, string compagny)
        {
            //Connexion a la base de données
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryString = "INSERT INTO customer (first_name, last_name, phone_number, mail, compagny_name) VALUES (@firstName,@lastName,@phone_number, @mail, @compagny )";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryString, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@firstName", firstName);
            sqlite_cmd.Parameters.AddWithValue("@lastName", lastName);
            sqlite_cmd.Parameters.AddWithValue("@phone_number", numberphone);
            sqlite_cmd.Parameters.AddWithValue("@mail", email);
            sqlite_cmd.Parameters.AddWithValue("@compagny", compagny);



            string messageSucess = "Vous avez ajouter un client";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);

            // Exécuter la requête d'insertion
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void updataCustommer(string firstName, string lastName, string email, string numberphone, string compagny)
        {
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryString = "Update INTO customer (first_name, last_name, phone_number, mail, compagny_name) SET (@firstNameChanged,@lastNameChanged,@phone_numberChanged, @mailChanged, @compagnyChanged )";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryString, db);

            // Ajouter les valeurs des paramètres de la requête


            sqlite_cmd.Parameters.AddWithValue("@firstNameChanged", firstName);
            sqlite_cmd.Parameters.AddWithValue("@lastNameChanged", lastName);
            sqlite_cmd.Parameters.AddWithValue("@phone_numberChanged", numberphone);
            sqlite_cmd.Parameters.AddWithValue("@mailChanged", email);
            sqlite_cmd.Parameters.AddWithValue("@compagnyChanged", compagny);



            string messageSucess = "Vous avez ajouter un client";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);

            // Exécuter la requête d'insertion
            sqlite_cmd.ExecuteNonQuery();
        }

    }
     

    
}

using System;
using System.Collections.Generic;
using System.Data;
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

        public static void deleteCustommer(int id)
        {
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryDelete = "DELETE FROM customer WHERE id = @id";


            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryDelete, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);


            string messageSucess = "Vous avez bien supprimer le client";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);

            // Exécuter la requête d'insertion
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void SearchCustommer(string firstNameR, string lastNameR, string emailR, string numberphoneR, string compagnyR)
        {
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string querySearch = ("SELECT id, (first_name) as Prenom, (last_name) as 'Nom de Famille', (phone_number) as 'Numéro de téléplhone', mail, (compagny_name) as 'Nom de la compagnie'\r\nFROM customer\r\nWHERE first_name LIKE '@firstNameR%'\r\nOR last_name LIKE '@lastNameR%'\r\nOR phone_number LIKE '@phone_numberR%'\r\nOR mail LIKE '@mailR%'\r\nOR compagny_name LIKE '@compagnyR%'");


            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@firstNameR", firstNameR);
            sqlite_cmd.Parameters.AddWithValue("@lastNameR", lastNameR);
            sqlite_cmd.Parameters.AddWithValue("@phone_numberR", numberphoneR);
            sqlite_cmd.Parameters.AddWithValue("@mailR", emailR);
            sqlite_cmd.Parameters.AddWithValue("@compagnyR", compagnyR);





            // Exécuter la requête d'insertion  
            sqlite_cmd.ExecuteNonQuery();
        }




    }
     

    
}

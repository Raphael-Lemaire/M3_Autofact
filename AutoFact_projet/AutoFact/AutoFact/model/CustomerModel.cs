using System.Data.SQLite;
using System.Windows.Forms;

namespace AutoFact.model
{
    public static class CustomerModel
    {
        /// <summary>
        /// L'ajout du client 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="numberphone"></param>
        /// <param name="compagny"></param>
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

        /// <summary>
        /// La suppression du client
        /// </summary>
        /// <param name="id"></param>
        /// <param name="numRows"></param>


        public static void deleteCustommer(int id,int numRows)
        {
            numRows = numRows;
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryDelete = "DELETE from customer WHERE id = @id";
               
            


            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryDelete, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);

            // Exécuter la requête d'insertion
            sqlite_cmd.ExecuteNonQuery();

            string messageSucess = "Vous avez bien supprimer le client";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);
        }


        /// <summary>
        /// Modification des clients
        /// </summary>
        /// <param name="firstNameR"></param>
        /// <param name="lastNameR"></param>
        /// <param name="emailR"></param>
        /// <param name="numberphoneR"></param>
        /// <param name="compagnyR"></param>
        public static void UpdateCustomer(string firstNameR, string lastNameR, string emailR, string numberphoneR, string compagnyR)
        {
            string querySearch = ("UPDATE CLIENT");
            SQLiteConnection db = Database.getInstance().getConnection();

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

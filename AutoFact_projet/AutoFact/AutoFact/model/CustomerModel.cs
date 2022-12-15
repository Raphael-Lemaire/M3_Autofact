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

            if (firstName == null || lastName == null || email == null || numberphone == null || compagny == null)
            {
                string messageErreurFirstName = ("Le champ ne pas être vide.");
                string titleErreur = ("Erreur !");
                MessageBox.Show(messageErreurFirstName, titleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string messageSucess = "Vous avez ajouter un client";
                string titleSucess = "Succès ! ";
                MessageBox.Show(messageSucess, titleSucess);

                // Exécuter la requête d'insertion
                sqlite_cmd.ExecuteNonQuery();
            }

           
        }

        /// <summary>
        /// La suppression du client
        /// </summary>
        /// <param name="id"></param>


        public static void deleteCustommer(int id)
        {
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
        /// <param name="firstNameU"></param>
        /// <param name="lastNameU"></param>
        /// <param name="emailU"></param>
        /// <param name="numberphoneU"></param>
        /// <param name="compagnyU"></param>
        public static void UpdateCustomer(int id, string firstNameU, string lastNameU, string emailU, string numberphoneU, string compagnyU)
        {

            string querySearch = ("UPDATE customer SET first_name = @firstNameU, last_name = @lastNameU, phone_number = @phone_numberU, mail = @mailU,compagny_name = @compagnyU WHERE id = @idU");
            SQLiteConnection db = Database.getInstance().getConnection();

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@idU", id);
            sqlite_cmd.Parameters.AddWithValue("@firstNameU", firstNameU);
            sqlite_cmd.Parameters.AddWithValue("@lastNameU", lastNameU);
            sqlite_cmd.Parameters.AddWithValue("@phone_numberU", numberphoneU);
            sqlite_cmd.Parameters.AddWithValue("@mailU", emailU);
            sqlite_cmd.Parameters.AddWithValue("@compagnyU", compagnyU);



            // Exécuter la requête d'insertion  
            sqlite_cmd.ExecuteNonQuery();
        }




    }



}

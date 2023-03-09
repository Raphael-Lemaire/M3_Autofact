using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(numberphone))
            {
                string messageErreurFirstName = ("Veuillez remplir les champs .");
                string titleErreur = ("Erreur !");
                MessageBox.Show(messageErreurFirstName, titleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string messageSucess = "Vous avez ajouté un client";
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
            string querySearch = ("UPDATE customer \r\n SET \r\n first_name = CASE \r\n WHEN @firstNameU <> '' THEN @firstNameU \r\n ELSE first_name \r\n END,\r\n last_name = CASE \r\n WHEN @lastNameU <> '' THEN @lastNameU \r\n ELSE last_name \r\n END,\r\n phone_number = CASE \r\n WHEN @phone_numberU <> '' THEN @phone_numberU \r\n ELSE phone_number \r\n END,\r\n mail = CASE \r\n WHEN @mailU <> '' THEN @mailU \r\n ELSE mail \r\n END,\r\n compagny_name = CASE \r\n WHEN @compagnyU <> '' THEN @compagnyU \r\n ELSE compagny_name \r\n END\r\n WHERE id = @id;");
            SQLiteConnection db = Database.getInstance().getConnection();

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);
            sqlite_cmd.Parameters.AddWithValue("@firstNameU", firstNameU);
            sqlite_cmd.Parameters.AddWithValue("@lastNameU", lastNameU);
            sqlite_cmd.Parameters.AddWithValue("@phone_numberU", numberphoneU);
            sqlite_cmd.Parameters.AddWithValue("@mailU", emailU);
            sqlite_cmd.Parameters.AddWithValue("@compagnyU", compagnyU);

            // Exécuter la requête d'insertion  
            sqlite_cmd.ExecuteNonQuery();
            string messageSucess = "Vous avez bien modifier l'information du client";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);

        }
    
            /// <summary>
            /// Permet de retrouver l'id selon les informations 
            /// </summary>
            /// <param name="valeur"></param>
            /// <param name="dataGridView"></param>
            /// <returns></returns>

            public static DataTable recherche_client(string valeur, DataGridView dataGridView)
        {
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string querySearch = ("SELECT id, (first_name) as Prenom, (last_name) as 'Nom de Famille', (phone_number) as 'Numéro de téléplhone', mail, (compagny_name) as 'Nom de la compagnie'\r\nFROM customer\r\nWHERE first_name LIKE @firstNameR OR last_Name Like @lastNameR OR phone_number like @phoneNumberR Or mail like @mailR Or compagny_name like @compagnyNameR");

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);
            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@firstNameR", valeur + "%");
            sqlite_cmd.Parameters.AddWithValue("@lastNameR", valeur + "%");
            sqlite_cmd.Parameters.AddWithValue("@phoneNumberR", valeur + "%");
            sqlite_cmd.Parameters.AddWithValue("@mailR", valeur + "%");
            sqlite_cmd.Parameters.AddWithValue("@compagnyNameR", valeur + "%");

            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView.DataSource = dt;
            db.Close();
            dataGridView.Refresh();

            return dt;
        }
        /// <summary>
        /// Permet de récuperer les clients
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static DataTable GetCustomer(DataGridView dataGridView)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, (first_name) as Prenom, (last_name) as 'Nom de Famille', (phone_number) as 'Numéro de téléplhone', mail, (compagny_name) as 'Nom de la compagnie' FROM customer", db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);
            dataGridView.DataSource = dt;
            db.Close();
            return dt;

        }




    }



}

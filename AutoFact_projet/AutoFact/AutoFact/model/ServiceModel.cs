using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact.model
{
    internal class ServiceModel
    {
        /// <summary>
        /// L'ajout du service
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unitPrice"></param>
        public static void addProduct(string name, string unitPrice)
        {
            //Connexion a la base de données
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryString = "INSERT INTO product (name, unit_price) VALUES (@name,@unitPrice)";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryString, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@unitPrice", unitPrice);

            if (string.IsNullOrEmpty(name))
            {
                string messageErreurFirstName = ("Veuillez remplir les champs .");
                string titleErreur = ("Erreur !");
                MessageBox.Show(messageErreurFirstName, titleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string messageSucess = "Vous avez ajouté un service";
                string titleSucess = "Succès ! ";
                MessageBox.Show(messageSucess, titleSucess);

                // Exécuter la requête d'insertion
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// La suppression du service
        /// </summary>
        /// <param name="id"></param>

        public static void deleteProduct(int id)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            //requete SQL
            string queryDelete = "DELETE from product WHERE id = @id";

            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryDelete, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);

            // Exécuter la requête d'insertion
            sqlite_cmd.ExecuteNonQuery();

            string messageSucess = "Vous avez bien supprimer le service";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);
        }
        /// <summary>
        /// Modification des services
        /// </summary>
        /// <param name="nameU"></param>
        /// <param name="unitPriceU"></param>
        public static void UpdateProduct(int id, string nameU, string unitPriceU)
        {
            string querySearch = ("UPDATE customer \r\n SET \r\n first_name = CASE \r\n WHEN @firstNameU <> '' THEN @firstNameU \r\n ELSE first_name \r\n END,\r\n last_name = CASE \r\n WHEN @lastNameU <> '' THEN @lastNameU \r\n ELSE last_name \r\n END,\r\n phone_number = CASE \r\n WHEN @phone_numberU <> '' THEN @phone_numberU \r\n ELSE phone_number \r\n END,\r\n mail = CASE \r\n WHEN @mailU <> '' THEN @mailU \r\n ELSE mail \r\n END,\r\n compagny_name = CASE \r\n WHEN @compagnyU <> '' THEN @compagnyU \r\n ELSE compagny_name \r\n END\r\n WHERE id = @id;");
            SQLiteConnection db = Database.getInstance().getConnection();

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);
            sqlite_cmd.Parameters.AddWithValue("@firstNameU", nameU);
            sqlite_cmd.Parameters.AddWithValue("@lastNameU", unitPriceU);

            // Exécuter la requête d'insertion  
            sqlite_cmd.ExecuteNonQuery();
            string messageSucess = "Vous avez bien modifier l'information du service";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);

        }

        /// <summary>
        /// Permet de retrouver l'id selon les informations 
        /// </summary>
        /// <param name="valeur"></param>
        /// <param name="dataGridView"></param>
        /// <returns></returns>

        public static DataTable recherche_service(string valeur, DataGridView dataGridView)
        {
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string querySearch = ("SELECT id, (name) as Nom du Service, (last_name) as 'Nom de Famille'\r\nFROM product\r\nWHERE name LIKE @nameR OR unit_price Like @unitPriceR");

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);
            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@nameR", valeur + "%");
            sqlite_cmd.Parameters.AddWithValue("@unitPriceR", valeur + "%");

            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView.DataSource = dt;
            db.Close();
            dataGridView.Refresh();

            return dt;
        }
        /// <summary>
        /// Permet de récuperer les services
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static DataTable GetProduct(DataGridView dataGridView)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, (name) as Nom du Service, (unit_price) as 'Prix Unitaire' FROM product", db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);
            dataGridView.DataSource = dt;
            db.Close();
            return dt;

        }
    }
}

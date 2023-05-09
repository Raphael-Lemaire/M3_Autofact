using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;

namespace AutoFact.model
{
    public static class QuotationModel
    {
        /// <summary>
        /// L'ajout du devis 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="totalPrice"></param>
        /// <param name="customerId"></param>
        public static void addQuotation(string name, float totalPrice, int customerId)
        {
            //Connexion a la base de données
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryString = "INSERT INTO quotation (name, total_price, customer_id) VALUES (@name, @totalPrice, @customerId)";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryString, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
            sqlite_cmd.Parameters.AddWithValue("@customerId", customerId);

            if (string.IsNullOrEmpty(name))
            {
                string messageErreurFirstName = ("Veuillez remplir les champs .");
                string titleErreur = ("Erreur !");
                MessageBox.Show(messageErreurFirstName, titleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string messageSucess = "Vous avez ajouté un devis";
                string titleSucess = "Succès ! ";
                MessageBox.Show(messageSucess, titleSucess);

                // Exécuter la requête d'insertion
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// La suppression du devis
        /// </summary>
        /// <param name="id"></param>

        public static void deleteQuotation(int id)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            //requete SQL
            string queryDelete = "DELETE from quotation WHERE id = @id";

            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryDelete, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);

            // Exécuter la requête d'insertion
            sqlite_cmd.ExecuteNonQuery();

            string messageSucess = "Vous avez bien supprimer le devis";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);
        }
        /// <summary>
        /// Modification des devis
        /// </summary>
        /// <param name="name"></param>
        /// <param name="totalPrice"></param>
        /// <param name="customerId"></param>
        public static void UpdateQuotation(int id, string name, float totalPrice, int customerId)
        {
            string querySearch = ("UPDATE quotation \r\n SET \r\n name = CASE \r\n WHEN @name <> '' THEN @name \r\n ELSE name \r\n END,\r\n total_price = CASE \r\n WHEN @totalPrice <> '' THEN @totalPrice \r\n ELSE total_price \r\n END,\r\n customer_id = CASE \r\n WHEN @customerId <> '' THEN @customerId \r\n ELSE customer_id \r\n END\r\n WHERE id = @id;");
            SQLiteConnection db = Database.getInstance().getConnection();

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
            sqlite_cmd.Parameters.AddWithValue("@customerId", customerId);

            // Exécuter la requête d'insertion  
            sqlite_cmd.ExecuteNonQuery();
            string messageSucess = "Vous avez bien modifier l'information du devis";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);

        }

        /// <summary>
        /// Permet de retrouver l'id selon les informations 
        /// </summary>
        /// <param name="valeur"></param>
        /// <param name="dataGridView"></param>
        /// <returns></returns>

        public static DataTable rechercheQuotation(string valeur, DataGridView dataGridView)
        {
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string querySearch = ("SELECT id, (name) as 'Nom du devis', (total_price) as 'Prix total du devis', (customer_id) as 'Nom du client' \r\nFROM quotation\r\nWHERE name LIKE @name OR total_price Like @totalPrice OR customer_id like @customerId");

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);
            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@name", valeur + "%");
            sqlite_cmd.Parameters.AddWithValue("@totalPrice", valeur + "%");
            sqlite_cmd.Parameters.AddWithValue("@customerId", valeur + "%");

            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView.DataSource = dt;
            db.Close();
            dataGridView.Refresh();

            return dt;
        }
        /// <summary>
        /// Permet de récuperer les devis
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static DataTable getQuotation(DataGridView dataGridView)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, (name) as 'Nom du devis', (total_price) as 'Prix total du devis', (customer_id) as 'Nom du client' FROM quotation", db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);
            dataGridView.DataSource = dt;
            db.Close();
            return dt;

        }




    }

}

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
        public static void addProduct(string name, string unitPrice, int category_id)
        {
            //Connexion a la base de données
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryString = "INSERT INTO product (name, unit_price, category_id) VALUES (@name,@unitPrice,@category_id)";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryString, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
            sqlite_cmd.Parameters.AddWithValue("@category_id", category_id);

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
            string querySearch = ("UPDATE product \r\n SET \r\n name = CASE \r\n WHEN @nameU <> '' THEN @nameU \r\n ELSE name \r\n END,\r\n unit_price = CASE \r\n WHEN @unitPriceU <> '' THEN @unitPriceU \r\n ELSE unit_price \r\n END\r\n WHERE id = @id;");
            SQLiteConnection db = Database.getInstance().getConnection();

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);
            sqlite_cmd.Parameters.AddWithValue("@nameU", nameU);
            sqlite_cmd.Parameters.AddWithValue("@unitPriceU", unitPriceU);

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
            string querySearch = ("SELECT id, (name) as 'Nom du Service', (last_name) as 'Nom de Famille'\r\nFROM product\r\nWHERE name LIKE @nameR OR unit_price Like @unitPriceR");

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
            SQLiteCommand cmd = new SQLiteCommand("SELECT p.id, p.name as 'Nom du Service', p.unit_price as 'Prix Unitaire', c.libelle 'Catégorie du produit' FROM product p JOIN category c ON p.category_id = c.id WHERE c.id = p.category_id; ", db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(reader);
            dataGridView.DataSource = dt;
            db.Close();
            return dt;

        }

        public static ComboBox GetListProduct(ComboBox combobox)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, name || ' ' || unit_price || '€' AS ProductPrice FROM product", db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("ProductPrice", typeof(string));

            dt.Load(reader);

            combobox.ValueMember = "id";
            combobox.DisplayMember = "ProductPrice";
            combobox.DataSource = dt;
            db.Close();
            return combobox;
        }

    }
}

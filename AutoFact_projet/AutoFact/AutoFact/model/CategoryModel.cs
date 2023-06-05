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
    class CategoryModel
    {
        public static void addCategory(string libelle)
        {
            //Connexion a la base de données
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryString = "INSERT INTO category (libelle) VALUES (@libelle)";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryString, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@libelle", libelle);

            if (string.IsNullOrEmpty(libelle))
            {
                string messageErreurFirstName = ("Veuillez remplir les champs .");
                string titleErreur = ("Erreur !");
                MessageBox.Show(messageErreurFirstName, titleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string messageSucess = "Vous avez ajouté une categorie";
                string titleSucess = "Succès ! ";
                MessageBox.Show(messageSucess, titleSucess);

                // Exécuter la requête d'insertion
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateCategory(int id)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            //requete SQL
            string queryDelete = "DELETE from category WHERE id = @id";

            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryDelete, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);

            // Exécuter la requête d'insertion
            sqlite_cmd.ExecuteNonQuery();

            string messageSucess = "Vous avez bien supprimer la catégorie";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);
        }
        /// <summary>
        /// Modification des devis
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libelle"></param>
        public static void UpdateCategory(int id, string libelle)
        {
            string querySearch = ("UPDATE category \r\n SET \r\n libelle = CASE \r\n WHEN @libelle <> '' THEN @libelle \r\n ELSE libelle \r\n END\r\n WHERE id = @id;");
            SQLiteConnection db = Database.getInstance().getConnection();

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);
            sqlite_cmd.Parameters.AddWithValue("@libelle", libelle);

            // Exécuter la requête d'insertion  
            sqlite_cmd.ExecuteNonQuery();
            string messageSucess = "Vous avez bien modifier la catégorie";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);

        }
        public static ComboBox GetListCategory(ComboBox combobox)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, libelle FROM Category", db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("libelle", typeof(string));

            dt.Load(reader);

            combobox.ValueMember = "id";
            combobox.DisplayMember = "libelle";
            combobox.DataSource = dt;
            db.Close();
            return combobox;
        }

    }
}

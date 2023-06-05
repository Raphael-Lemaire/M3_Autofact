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
    public static class TypeStatusModel
    {
        /// <summary>
        /// L'ajout du devis 
        /// </summary>
        /// <param name="libelle"></param>
        public static void addTypeStatus(string libelle)
        {
            //Connexion a la base de données
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryString = "INSERT INTO type_status (libelle) VALUES (@libelle)";
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
                string messageSucess = "Vous avez ajouté un status";
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

        public static void deleteTypeStatus(int id)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            //requete SQL
            string queryDelete = "DELETE from type_status WHERE id = @id";

            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryDelete, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);

            // Exécuter la requête d'insertion
            sqlite_cmd.ExecuteNonQuery();

            string messageSucess = "Vous avez bien supprimer le status";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);
        }
        /// <summary>
        /// Modification des devis
        /// </summary>
        /// <param name="libelle"></param>
        public static void UpdateTypeStatus(int id, string libelle)
        {
            string querySearch = ("UPDATE type_status \r\n SET \r\n libelle = CASE \r\n WHEN @libelle <> '' THEN @libelle \r\n ELSE libelle \r\n END\r\n WHERE id = @id;");
            SQLiteConnection db = Database.getInstance().getConnection();

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@id", id);
            sqlite_cmd.Parameters.AddWithValue("@libelle", libelle);

            // Exécuter la requête d'insertion  
            sqlite_cmd.ExecuteNonQuery();
            string messageSucess = "Vous avez bien modifier le status";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);

        }

        /// <summary>
        /// Permet de récuperer les devis
        /// </summary>
        /// <param name="comboBox"></param>
        /// <returns></returns>

        public static ComboBox GetListTypeStatus(ComboBox combobox)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, libelle FROM type_status", db);
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

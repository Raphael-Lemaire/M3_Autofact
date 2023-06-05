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
    class QuotationLineModel
    {
        /// <summary>
        /// L'ajout du devis 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="product_id"></param>
        /// <param name="quotation_id"></param>
        public static void addQuotationLine(int amount, int product_id, int quotation_id)
        {
            //Connexion a la base de données
            SQLiteConnection db = Database.getInstance().getConnection();

            //requete SQL
            string queryString = "INSERT INTO quotation_line (amount, product_id, quotation_id) VALUES (@amount, @product_id, @quotation_id)";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryString, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@amount", amount);
            sqlite_cmd.Parameters.AddWithValue("@product_id", product_id);
            sqlite_cmd.Parameters.AddWithValue("@quotation_id", quotation_id);

                string messageSucess = "Vous avez ajouté un produit au devis";
                string titleSucess = "Succès ! ";
                MessageBox.Show(messageSucess, titleSucess);

                // Exécuter la requête d'insertion
                sqlite_cmd.ExecuteNonQuery();
        }
    }
}

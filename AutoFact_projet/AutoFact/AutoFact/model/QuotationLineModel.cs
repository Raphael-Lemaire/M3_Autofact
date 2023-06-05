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

        public static void deleteQuotationLine(int quotation_id, int product_id)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            //requete SQL
            string queryDelete = "DELETE from quotation_line WHERE quotation_id = @quotation_id AND product_id = @product_id";

            SQLiteCommand sqlite_cmd = new SQLiteCommand(queryDelete, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@quotation_id", quotation_id);
            sqlite_cmd.Parameters.AddWithValue("@product_id", product_id);

            // Exécuter la requête d'insertion
            sqlite_cmd.ExecuteNonQuery();

            string messageSucess = "Vous avez bien supprimer une ligne dans le devis";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);
        }

        /// <summary>
        /// Modification des devis
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="quotation_id"></param>
        /// <param name="product_id"></param>
        public static void UpdateQuotationLine(int amount, int quotation_id, int product_id, int new_product_id)
        {
            string querySearch = ("UPDATE quotation_line SET amount = @amount, product_id = @new_product_id, quotation_id = @quotation_id WHERE quotation_id = @quotation_id AND product_id = @product_id ;");
            SQLiteConnection db = Database.getInstance().getConnection();

            SQLiteCommand sqlite_cmd = new SQLiteCommand(querySearch, db);

            // Ajouter les valeurs des paramètres de la requête
            sqlite_cmd.Parameters.AddWithValue("@amount", amount);
            sqlite_cmd.Parameters.AddWithValue("@quotation_id", quotation_id);
            sqlite_cmd.Parameters.AddWithValue("@product_id", product_id);
            sqlite_cmd.Parameters.AddWithValue("@new_product_id", new_product_id);

            // Exécuter la requête d'insertion  
            sqlite_cmd.ExecuteNonQuery();
            string messageSucess = "Vous avez bien modifier la ligne du devis";
            string titleSucess = "Succès ! ";
            MessageBox.Show(messageSucess, titleSucess);

        }
        public static int GetQuotationLineTotalPrice(int quotation_id)
        {

            SQLiteConnection db = Database.getInstance().getConnection();

            int totalPrice = 0;

            string query = "SELECT SUM(ql.amount * p.unit_price) AS prix_total FROM quotation_line ql JOIN product p ON ql.product_id = p.id WHERE ql.quotation_id = @quotationId";
            SQLiteCommand command = new SQLiteCommand(query, db);
            command.Parameters.AddWithValue("@quotationId", quotation_id);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalPrice = Convert.ToInt32(result);
                    }
            return totalPrice;
        }

   
        public static ComboBox GetListQuotationLineProduct(ComboBox combobox, int id)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            SQLiteCommand cmd = new SQLiteCommand("SELECT ql.amount AS 'quantité', p.name AS 'ProductName' FROM quotation_line ql JOIN product p ON ql.product_id = p.id WHERE ql.quotation_id = " + id, db);
            SQLiteDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("quantité", typeof(string));
            dt.Columns.Add("ProductName", typeof(string));

            dt.Load(reader);

            combobox.DisplayMember = "ProductName";
            combobox.ValueMember = "quantité";
            combobox.DataSource = dt;

            // Gestion de l'événement SelectedIndexChanged
            combobox.SelectedIndexChanged += (sender, e) =>
            {
                string quantite = combobox.SelectedValue.ToString();
                // Utilisez la valeur de la quantité sélectionnée ici
                // ...
            };

            db.Close();
            return combobox;
        }
    }
}

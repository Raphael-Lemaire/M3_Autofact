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
    class ModificationStatusModel
    {
        public static void addModificationStatus(int typestatus_id, int quotation_id)
        {
            SQLiteConnection db = Database.getInstance().getConnection();

            // Vérifier si la modification status existe déjà pour la quotation
            string checkQuery = "SELECT COUNT(*) FROM modification_status WHERE quotation_id = @quotation_id";
            SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, db);
            checkCmd.Parameters.AddWithValue("@quotation_id", quotation_id);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            // Si le modification status n'existe pas, effectuer un INSERT
            if (count == 0)
            {
                string insertQuery = "INSERT INTO modification_status (date_modification, typestatus_id, quotation_id) VALUES (date('now'), @typestatus_id, @quotation_id)";
                SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, db);
                insertCmd.Parameters.AddWithValue("@typestatus_id", typestatus_id);
                insertCmd.Parameters.AddWithValue("@quotation_id", quotation_id);
                insertCmd.ExecuteNonQuery();
            }
            // Sinon, effectuer un UPDATE
            else
            {
                string updateQuery = "UPDATE modification_status SET date_modification = date('now'), typestatus_id = @typestatus_id WHERE quotation_id = @quotation_id";
                SQLiteCommand updateCmd = new SQLiteCommand(updateQuery, db);
                updateCmd.Parameters.AddWithValue("@typestatus_id", typestatus_id);
                updateCmd.Parameters.AddWithValue("@quotation_id", quotation_id);
                updateCmd.ExecuteNonQuery();
            }

            string messageSuccess = "Vous avez ajouté un status au devis";
            string titleSuccess = "Succès !";
            MessageBox.Show(messageSuccess, titleSuccess);
        }
    }
}

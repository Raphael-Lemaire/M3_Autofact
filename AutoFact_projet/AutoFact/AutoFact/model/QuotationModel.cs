using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AutoFact.model
{
    public static class QuotationModel
    {
        public static void QuotationAdd(string Name, float Total_Price)
        {
            SQLiteConnection db = Database.getInstance().getConnection();
            string Query = @"insert into quotation(total_price, name) values(@Total_Price, @Name)";
            SQLiteCommand cmd = new SQLiteCommand(Query, db);
            cmd.Parameters.AddWithValue("@Total_Price", Total_Price);
            cmd.Parameters.AddWithValue("@Name", Name);



            cmd.ExecuteNonQuery();
        }
    }
}

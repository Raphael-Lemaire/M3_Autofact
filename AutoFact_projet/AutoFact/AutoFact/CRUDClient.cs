using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact
{
    internal class CRUDClient
    {
        private static SQLiteConnection db = Database.getInstance().getConnection();
        private static SQLiteCommand commande;
        private static SQLiteDataReader reader;
        public static List<Customer> ajout = new List<Customer>();
        public static void addCustomer(Customer aCustomer)
        {
            db.Open();
            SQLiteCommand AddCLient;
            int id = 0;
            string FirstName;
            string LastName;
            string Email;
            string Phone;

            commande.CommandText = @"INSERT INTO customer (first_name,last_name, phone_number, mail) VALUES ('" + FirstName + "','" + tbLastName.Text + "','" + tbNumberPhone.Text + "','" + tbAddress.Text + "');
            reader = commande.ExecuteReader();


        }
    }
}

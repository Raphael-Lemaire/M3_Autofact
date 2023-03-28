using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using System.Net;


namespace AutoFact
{


    internal class CustomerCrud
    {
       public void AddCustomer(Customer customer)
        {
          

            SQLiteConnection db = Database.getInstance().getConnection();



            SQLiteCommand sqlite_cmd;
            string Createsql = @"INSERT INTO customer VALUES (cFirstName, cLastName, cNumberPhone,cEmailAddress, cAddress )";
            sqlite_cmd = db.CreateCommand();

            var args = new Dictionary<string, object>
             {
                 {"@cFirstName", customer.getFirstName()},
                 {"@cLastName", customer.getLastName()},
                 {"@cNumberPhone", customer.getPhoneNumber()},
                 {"@cEmailAddress", customer.getEmailAddress()},
                 {"@cAddress",customer.getAddress() }
             };
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }




    }
}

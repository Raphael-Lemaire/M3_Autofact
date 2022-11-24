using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact
{
    public partial class aClient : Form
    {
        public aClient()
        {
           
            InitializeComponent();
          
        }



        private void aClient_Load(object sender, EventArgs e)
        {
           
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            string cFirstName = (tbFirstName.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            string cLastName = (tbLastName.Text);
        }

        private void tbNumberPhone_TextChanged(object sender, EventArgs e)
        {
            string cNumberPhone = (tbNumberPhone.Text);
        }

        private void tbEmailAddress_TextChanged(object sender, EventArgs e)
        {
            string cEmailAddress = (tbEmailAddress.Text);
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            string  cAddress = (tbAddress.Text);
        }
        


        private void rbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void rbAdd_Click(object sender, EventArgs e)
        {
            
        }



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
    
}


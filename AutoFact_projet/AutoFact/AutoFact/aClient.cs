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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string FirstName = (tbFirstName.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            string _LastName = (tbLastName.Text); 
        }

        private void tbNumberPhone_TextChanged(object sender, EventArgs e)
        {
            string _NumberPhone = (tbNumberPhone.Text);
        }

        private void tbEmailAddress_TextChanged(object sender, EventArgs e)
        {
            string _EmailAddress = (tbEmailAddress.Text);
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            string _Address = (tbAddress.Text);
        }

        private void rButton1_Click(object sender, EventArgs e)
        {

            SQLiteConnection db = Database.getInstance().getConnection();


            SQLiteCommand sqlite_cmd;
            string CreateUser = @"INSERT INTO customer (first_name,last_name, phone_number, mail, compagny_name)"
+ "VALUES ('Dupond','Pierre','07202684','pierre.dupond@gmail.com','test')";

            sqlite_cmd = db.CreateCommand();
            sqlite_cmd.CommandText = CreateUser;
            sqlite_cmd.ExecuteNonQuery();
            
       
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
    }
    
}


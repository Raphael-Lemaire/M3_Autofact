using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
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
            string LastName = (tbLastName.Text); 
        }

        private void tbNumberPhone_TextChanged(object sender, EventArgs e)
        {
            string NumberPhone = (tbNumberPhone.Text);
        }

        private void tbEmailAddress_TextChanged(object sender, EventArgs e)
        {
            string EmailAddress = (tbEmailAddress.Text);
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            string Address = (tbAddress.Text);
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void rbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {


                    SQLiteConnection AutoFact = new SQLiteConnection(ConnectionString);

                    AutoFact.Open();
                    SQLiteCommand AddClient= AutoFact.CreateCommand();
                    Console.WriteLine("A");
                    AddClient.CommandText = "INSERT INTO (Nom, Prenom) FROM Adherents Order By (Nom);";
                    Console.WriteLine("A");
                    AddClient.ExecuteNonQuery();
                    Console.WriteLine("A");
                    AutoFact.Close();
                }
            }
        }
    }
    
}


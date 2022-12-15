using AutoFact.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        private void rButton2_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;

            string lastName = tbLastName.Text;

            string email = tbEmail.Text;
 
            string numberphone = tbNumberPhone.Text;
     
            string compagny = tbCompagny.Text;
     
            if (firstName == null || lastName == null || email == null || numberphone == null || compagny == null)
            {
                string messageErreurFirstName = ("Le champ ne pas être vide.");
                string titleErreur = ("Erreur !");
                MessageBox.Show(messageErreurFirstName, titleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CustomerModel.addCustomer(firstName, lastName, email, numberphone, compagny);
            }
            


        }

        private void bAddCustomer_Click(object sender, EventArgs e)
        {
            formAF AF = new formAF();
            this.Hide();
        }
    }
}

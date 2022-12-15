using AutoFact.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact
{
    public partial class gClient : Form
    {
        public gClient()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            {
                formAF AF = new formAF();
                this.Hide();

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string email = tbEmail.Text;
            string numberphone = tbNumberPhone.Text;
            string compagny = tbCompagny.Text;

            CustomerModel.UpdateCustomer(firstName, lastName, email, numberphone, compagny);
        }
    }
}

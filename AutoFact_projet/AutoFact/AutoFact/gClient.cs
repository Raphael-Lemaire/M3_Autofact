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

        private void rButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbId.Text);
            string firstNameU = tbFirstName.Text;
            string lastNameU = tbLastName.Text;
            string emailU = tbEmail.Text;
            string numberphoneU = tbNumberPhone.Text;
            string compagnyU = tbCompagny.Text;
            if( firstNameU == null)


            CustomerModel.UpdateCustomer( id, firstNameU, lastNameU, emailU, numberphoneU, compagnyU);

            gClient gC = new gClient();
            this.Hide();
        }
    }
}

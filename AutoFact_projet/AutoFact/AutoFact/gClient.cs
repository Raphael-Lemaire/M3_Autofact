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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string recherche = (tbRecherche.Text);
        }
        private void recherche()
        {


        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            string FirstName = (tbFirstName.Text);
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

        private void labelEmailAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelNumberPhone_Click(object sender, EventArgs e)
        {

        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }
    }
}

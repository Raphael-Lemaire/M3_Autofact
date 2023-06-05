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
    public partial class aService : Form
    {
        public aService()
        {
            InitializeComponent();
        }

        private void bAddService_Click(object sender, EventArgs e)
        {

        }


        private void aService_Load(object sender, EventArgs e)
        {

        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void bAddService_Click_1(object sender, EventArgs e)
        {
            string name = tbName.Text;

            string unitPrice = tbUnitPrice.Text;

            if (name == null || unitPrice == null)
            {
                string messageErreurFirstName = ("Le champ ne pas être vide.");
                string titleErreur = ("Erreur !");
                MessageBox.Show(messageErreurFirstName, titleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ServiceModel.addProduct(name, unitPrice);
            }
        }

        private void bRetourService_Click_1(object sender, EventArgs e)
        {
            formAF AF = new formAF();
            this.Hide();
        }
    }
}

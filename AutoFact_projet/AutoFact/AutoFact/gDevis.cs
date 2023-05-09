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
    public partial class gDevis : Form
    {
        public gDevis()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {        

        }

        private void SaveQuote_Click(object sender, EventArgs e)
        {   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gDevis_Load(object sender, EventArgs e)
        {

        }

        private void rButtonStatus_Click(object sender, EventArgs e)
        {
            string libelle = textBoxStatus.Text;

            if (libelle == null)
            {
                string messageErreurFirstName = ("Le champ ne peux pas être vide.");
                string titleErreur = ("Erreur !");
                MessageBox.Show(messageErreurFirstName, titleErreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TypeStatusModel.addTypeStatus(libelle);
            }
        }
    }
}

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
        private void gClient_Load(object sender, EventArgs e)
        {
            CustomerModel.GetCustomer(dataGridViewCustomer);
        }



        private void tbScreachCustomer_TextChanged(object sender, EventArgs e)
        {
            string valeur = tbScreachCustomer.Text;
            CustomerModel.recherche_client(valeur, dataGridViewCustomer);
        }

        private void bAddCustomer_Click(object sender, EventArgs e)
        {
            formAF AF = new formAF();
            this.Hide();
        }

        private void ReadCustomer_Click(object sender, EventArgs e)
        {
            CustomerModel.GetCustomer(dataGridViewCustomer);
        }

        private void TBcompagnyMailUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            // Variable permettant d'avoir la cellule actuel
            int rowindex = dataGridViewCustomer.CurrentCell.RowIndex;
            int columnindex = dataGridViewCustomer.CurrentCell.ColumnIndex;

            // Ligne permettant de mettre la valeur de l'id 
            int id = Convert.ToInt32(dataGridViewCustomer.Rows[rowindex].Cells[columnindex].Value);

            int numRows = dataGridViewCustomer.SelectedCells.Count;
            if (numRows > 1)
            {
                string messageError = ("Vous pouvez selectioner qu'une seule cellule.");
                string titleError = ("Erreur");
                MessageBox.Show(messageError, titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Traitement en fonction de l'option choisie par l'utilisateur
                DialogResult confirmation = MessageBox.Show("Vous avez choisi de supprimer plusieur utilisateur voulez vous vraiment supprimer ces utilisateur?", "Confirmation", MessageBoxButtons.YesNo);

                //Si le client appuis sur oui aloir
                if (confirmation == DialogResult.Yes)
                {
                    CustomerModel.deleteCustommer(id);
                }
            }
        }

        private void ReadCustomer_Click_1(object sender, EventArgs e)
        {
            CustomerModel.GetCustomer(dataGridViewCustomer);
        }

        private void Updatebot_Click(object sender, EventArgs e)
        {
            // Variable permettant d'avoir la cellule actuel
            string firstNameU = TBfirstNameUp.Text;
            string lastNameU = TBlasttNameUpdate.Text;
            string emailU = TBmailUpdate.Text;
            string numberphoneU = TBnumberPhoneUpdate.Text;
            string compagnyU = TBcompagnyMailUpdate.Text;
            int rowindex = dataGridViewCustomer.CurrentCell.RowIndex;
            int columnindex = dataGridViewCustomer.CurrentCell.ColumnIndex;
            if (columnindex == 0)
            {
                int id = Convert.ToInt32(dataGridViewCustomer.Rows[rowindex].Cells[columnindex].Value);
                int numRows = dataGridViewCustomer.SelectedCells.Count;
                if (numRows > 1)
                {
                    string messageError = ("Vous pouvez selectioner qu'une seule cellule.");
                    string titleError = ("Erreur");
                    MessageBox.Show(messageError, titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CustomerModel.UpdateCustomer(id, firstNameU, lastNameU, emailU, numberphoneU, compagnyU);
                }
            }
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            // Variable permettant d'avoir la cellule actuel
            int rowindex = dataGridViewCustomer.CurrentCell.RowIndex;
            int columnindex = dataGridViewCustomer.CurrentCell.ColumnIndex;
            if (rowindex == 0)
            {
                // Ligne permettant de mettre la valeur de l'id 
                int id = Convert.ToInt32(dataGridViewCustomer.Rows[rowindex].Cells[columnindex].Value);
                int numRows = dataGridViewCustomer.SelectedCells.Count;
                if (numRows > 1)
                {
                    string messageError = ("Vous pouvez selectioner qu'une seule cellule.");
                    string titleError = ("Erreur");
                    MessageBox.Show(messageError, titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CustomerModel.deleteCustommer(id);
            }
            else
            {
                string messageError = ("Veuillez selectionner la colonnes ID.");
                string titleError = ("Erreur");
                MessageBox.Show(messageError, titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

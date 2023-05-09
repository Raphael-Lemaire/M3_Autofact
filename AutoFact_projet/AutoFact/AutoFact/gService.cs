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
    public partial class gService : Form
    {
        public gService()
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

        private void gService_Load(object sender, EventArgs e)
        {
            ServiceModel.GetProduct(dataGridViewProduct);
        }



        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string valeur = tbSearchProduct.Text;
            ServiceModel.recherche_service(valeur, dataGridViewProduct);
        }

        private void bAddCustomer_Click(object sender, EventArgs e)
        {
            formAF AF = new formAF();
            this.Hide();
        }

        private void ReadProduct_Click(object sender, EventArgs e)
        {
            ServiceModel.GetProduct(dataGridViewProduct);
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            // Variable permettant d'avoir la cellule actuel
            int rowindex = dataGridViewProduct.CurrentCell.RowIndex;
            int columnindex = dataGridViewProduct.CurrentCell.ColumnIndex;

            // Ligne permettant de mettre la valeur de l'id 
            int id = Convert.ToInt32(dataGridViewProduct.Rows[rowindex].Cells[columnindex].Value);

            int numRows = dataGridViewProduct.SelectedCells.Count;
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
                    ServiceModel.deleteProduct(id);
                }
            }
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            // Variable permettant d'avoir la cellule actuel
            string nameU = TBnameUpdate.Text;
            string unitPriceU = TBunitPriceUpdate.Text;
            int rowindex = dataGridViewProduct.CurrentCell.RowIndex;
            int columnindex = dataGridViewProduct.CurrentCell.ColumnIndex;
            if (columnindex == 0)
            {
                int id = Convert.ToInt32(dataGridViewProduct.Rows[rowindex].Cells[columnindex].Value);
                int numRows = dataGridViewProduct.SelectedCells.Count;
                if (numRows > 1)
                {
                    string messageError = ("Vous pouvez selectioner qu'une seule cellule.");
                    string titleError = ("Erreur");
                    MessageBox.Show(messageError, titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ServiceModel.UpdateProduct(id, nameU, unitPriceU);
                    TBnameUpdate.Text = string.Empty;
                    TBunitPriceUpdate.Text = string.Empty;
                }
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            // Variable permettant d'avoir la cellule actuel
            int rowindex = dataGridViewProduct.CurrentCell.RowIndex;
            int columnindex = dataGridViewProduct.CurrentCell.ColumnIndex;
            if (columnindex == 0)
            {
                // Ligne permettant de mettre la valeur de l'id 
                int id = Convert.ToInt32(dataGridViewProduct.Rows[rowindex].Cells[columnindex].Value);
                int numRows = dataGridViewProduct.SelectedCells.Count;
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

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewProduct.CurrentCell.RowIndex; if (rowindex >= 0)
            {
                // Récupérez la ligne sur laquelle vous avez cliqué
                DataGridViewRow row = dataGridViewProduct.Rows[rowindex];
                // Récupérez toutes les informations de la ligne
                string col1Value = row.Cells[1].Value.ToString();
                string col2Value = row.Cells[2].Value.ToString();
                // Ajoutez autant de colonnes que nécessaire 
                // Utilisez les informations récupérées pour effectuer les traitements souhaités   
                // Par exemple, afficher les informations dans une zone de texte 
                TBnameUpdate.Text = $"{col1Value}";
                TBunitPriceUpdate.Text = $"{col2Value}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

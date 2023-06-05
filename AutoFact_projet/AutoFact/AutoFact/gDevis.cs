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
            TypeStatusModel.GetListTypeStatus(comboBoxGStatus);
            TypeStatusModel.GetListTypeStatus(comboBoxStatus);
            CustomerModel.GetListCustomer(comboBoxClientGQuotation);
            ServiceModel.GetListProduct(comboBoxService);
            QuotationModel.getQuotation(dataGridViewQuotation);
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

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadCustomer_Click(object sender, EventArgs e)
        {
            TypeStatusModel.GetListTypeStatus(comboBoxGStatus);
            TypeStatusModel.GetListTypeStatus(comboBoxStatus);
        }

        private void UpdateButtonStatus_Click(object sender, EventArgs e)
        {
            string libelle = textBoxUpdateStatus.Text;
            int selectedValue = Convert.ToInt32(comboBoxGStatus.SelectedValue);

            TypeStatusModel.UpdateTypeStatus(selectedValue, libelle);
            TypeStatusModel.GetListTypeStatus(comboBoxGStatus);
            TypeStatusModel.GetListTypeStatus(comboBoxStatus);
        }

        private void DeleteButtonStatus_Click(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(comboBoxGStatus.SelectedValue);

            TypeStatusModel.deleteTypeStatus(selectedValue);
            TypeStatusModel.GetListTypeStatus(comboBoxGStatus);
            TypeStatusModel.GetListTypeStatus(comboBoxStatus);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewQuotation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewQuotation.CurrentCell.RowIndex; if (rowindex >= 0)
            {
                // Récupérez la ligne sur laquelle vous avez cliqué
                DataGridViewRow row = dataGridViewQuotation.Rows[rowindex];
                // Récupérez toutes les informations de la ligne
                string col1Value = row.Cells[1].Value.ToString();
                int col2Value = Convert.ToInt32(row.Cells[2].Value);
                // Ajoutez autant de colonnes que nécessaire 
                // Utilisez les informations récupérées pour effectuer les traitements souhaités   
                // Par exemple, afficher les informations dans une zone de texte 
                TBQuotationName.Text = $"{col1Value}";
                TBTotalPrice.Text = $"{col2Value}";
            }
        }

        private void rButton4_Click(object sender, EventArgs e)
        {
            // Variable permettant d'avoir la cellule actuel
            int rowindex = dataGridViewQuotation.CurrentCell.RowIndex;
            int columnindex = dataGridViewQuotation.CurrentCell.ColumnIndex;
            if (columnindex == 0)
            {
                // Ligne permettant de mettre la valeur de l'id 
                int id = Convert.ToInt32(dataGridViewQuotation.Rows[rowindex].Cells[columnindex].Value);
                int numRows = dataGridViewQuotation.SelectedCells.Count;
                if (numRows > 1)
                {
                    string messageError = ("Vous pouvez selectioner qu'une seule cellule.");
                    string titleError = ("Erreur");
                    MessageBox.Show(messageError, titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                int selectedValue = Convert.ToInt32(comboBoxService.SelectedValue);
                int amount;
                if (int.TryParse(textBoxAmount.Text, out amount))
                {
                    QuotationLineModel.addQuotationLine(amount, selectedValue, id);          
                }
                else
                {
                    string messageError = ("Entrez une quantité valide");
                    string titleError = ("Erreur");
                    MessageBox.Show(messageError, titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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

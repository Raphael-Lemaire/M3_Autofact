using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using AutoFact.model;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Controls;
using System.Diagnostics.Eventing.Reader;

namespace AutoFact
{
    public partial class aDevis : Form
    {
        public aDevis()
        {
            InitializeComponent();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aDevis_Load(object sender, EventArgs e)
        {
            CustomerModel.GetListCustomer(comboBoxClient);
        }

        private void CreateQuotationButton_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            int selectedValue = Convert.ToInt32(comboBoxClient.SelectedValue);

            QuotationModel.addQuotation(firstName, 0, selectedValue);
        }

        private void bAddCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            string Name;
            float Total_Price;
            Total_Price = Int32.Parse(this.tbTotal_Price.Text) ;
            Name = this.tbName.Text;
            QuotationModel.QuotationAdd(Name, Total_Price);
            
            
        }
    }
}

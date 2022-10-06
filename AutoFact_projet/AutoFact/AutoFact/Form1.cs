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
    public partial class formAF : Form
    {
        public formAF()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gererService_Click(object sender, EventArgs e)
        {
            gService gS = new gService();
            gS.Show();
        }

        private void gererDevis_Click(object sender, EventArgs e)
        {
            gDevis gD = new gDevis();
            gD.Show();
        }

        private void addService_Click(object sender, EventArgs e)
        {
            aService aS = new aService();
            aS.Show();
        }

        private void gererClient_Click(object sender, EventArgs e)
        {
            gClient gC = new gClient();
            gC.Show();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            aClient aC = new aClient();
            aC.Show();
        }

        private void rvs_Click(object sender, EventArgs e)
        {

        }
    }
}

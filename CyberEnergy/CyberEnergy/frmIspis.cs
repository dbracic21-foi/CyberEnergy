using CyberEnergy.Models;
using CyberEnergy.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberEnergy
{
    public partial class frmIspis : Form
    {
        public frmIspis()
        {
            InitializeComponent();
        }
        private void Ispis_Load(object sender, EventArgs e)
        {
            showtablica();
        }
        private void showtablica()
        {
            var unospodataka = RepositoryZgrade.GetZgrade();
            dgvTablica.DataSource = unospodataka;
            dgvTablica.Columns[1].Width = 100;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void showpretrazivanje()
        {
            var zgrade = RepositoryZgrade.GetZgradeSearch(label.Text);
            dgvTablica.DataSource = zgrade;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var zgrade = RepositoryZgrade.GetZgradeSearch(txtPretrazivanje.Text);
            dgvTablica.DataSource = zgrade;
            if (txtPretrazivanje.Text=="")
            {
                showtablica();

            }
        }
    }
}

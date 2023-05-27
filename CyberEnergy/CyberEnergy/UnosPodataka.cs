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
    public partial class UnosPodataka : Form
    {
        public UnosPodataka()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ShowZgrade()
        {

            List<Zgrade> zgrade = RepositoryZgrade.GetZgrade();
            cmbZgrade.DataSource = zgrade;
        }
        private void UnosPodataka_Load(object sender, EventArgs e)
        {
            ShowZgrade();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

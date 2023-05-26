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
    public partial class frmPregledPodataka : Form
    {
        public frmPregledPodataka()
        {
            InitializeComponent();
        }

        private void frmPregledPodataka_Load(object sender, EventArgs e)
        {
            ShowZgrade();
        }
        private void ShowZgrade()
        {
          
            List<Zgrade> zgrade = RepositoryZgrade.GetZgrade();
            cmbZgrade.DataSource = zgrade;
        }



        private void cmbAdministrator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

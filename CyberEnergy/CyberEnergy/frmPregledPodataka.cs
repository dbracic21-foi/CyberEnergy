using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using System.Data.SqlClient;
using CyberEnergy.Models;
using CyberEnergy.Repository;

namespace CyberEnergy
{
    public partial class frmPregledPodataka : Form
    {
        public frmPregledPodataka()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void ShowAdministrators()
        {
            List<Administrator> administrators = repositoryAdministrator.GetAdministrators();
            cmbAdministrator.DataSource = administrators;
        }

        private void frmPregledPodataka_Load(object sender, EventArgs e)
        {
            ShowAdministrators();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUnosPodataka frmUnos = new frmUnosPodataka();
            frmUnos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

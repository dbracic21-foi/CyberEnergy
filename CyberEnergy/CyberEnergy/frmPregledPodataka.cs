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
            
        }

        private void frmPregledPodataka_Load(object sender, EventArgs e)
        {
            ShowAdministrators();
        }
    }
}

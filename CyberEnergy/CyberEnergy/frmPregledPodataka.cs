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
           
        }
      



        private void cmbAdministrator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
                                                                                                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUnosPodataka frmunos = new frmUnosPodataka();
            frmunos.ShowDialog();
        }
    }
}

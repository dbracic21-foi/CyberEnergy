﻿using CyberEnergy.Models;
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
    //forma za pocetni pregled podataka
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

           frmUnosPodataka unosPodataka = new frmUnosPodataka();
            unosPodataka.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMijenjanjePodataka mijenjanjepodataka = new frmMijenjanjePodataka();
            mijenjanjepodataka.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBrisanje frmBrisanje = new frmBrisanje();
            frmBrisanje.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIspis frmIspis = new frmIspis();
            frmIspis.ShowDialog();
        }
    }
}

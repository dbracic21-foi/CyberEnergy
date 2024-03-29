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
    //forma za Brisanje stavki pomocu Id-a
    public partial class frmBrisanje : Form
    {
        public frmBrisanje()
        {

            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void showid()
        {
            List<UnosPodataka> unospodataka = RepositoryUnosaPodataka.GetUnosPodataka();
            List<int> ids = new List<int>();
            for (int i = 0; i < unospodataka.Count; i++)
            {
                ids.Add(unospodataka[i].Id_UnosaPodataka);
            }
            comboBox1.DataSource = ids;

        }
   

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            UnosPodataka unosPodataka = new UnosPodataka();
            var unospodataka = RepositoryUnosaPodataka.GetUnosPodataka(unosPodataka.Id_UnosaPodataka);
            RepositoryUnosaPodataka.DeleteUnosaPodataka(int.Parse(comboBox1.Text));
            MessageBox.Show("Uspješno ste obrisali podatke");
        }

        private void frmBrisanje_Load(object sender, EventArgs e)
        {
            showid();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
      

        
    }
}

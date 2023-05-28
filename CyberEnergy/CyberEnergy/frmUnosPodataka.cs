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
    public partial class frmUnosPodataka : Form
    {
        public frmUnosPodataka()
        {
            InitializeComponent();
        }

      
        private void ShowZgrade()
        {

            List<Zgrade> zgrade = RepositoryZgrade.GetZgrade();
            cmbZgrade.DataSource = zgrade;
        }
        private void ShowMjerna()
        {

            List<VrstaEnergije> vrstaenergije = RepositoryVrstaEnergije.GetEnergija();
            cmbVrste.DataSource = vrstaenergije;
        }
        private void ShowEnergije()
        {

            List<MjernaJedinica> mjernajedinica = RepositoryMjerneJedinice.GetMjernaJedinica();
            cmbMjerna.DataSource = mjernajedinica;
        }
      /*  private void ShowKolicine()
        {

            List<Kolicina> kolicina = RepositoryKolicine.GetKolicina();
          txtKolicine.Text = kolicina.ToString();
        }
      */
        private void UnosPodataka_Load(object sender, EventArgs e)
        {
            ShowZgrade();
            ShowMjerna();
            ShowEnergije();
           // ShowKolicine();

        }
       
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
          var mjernajedinica = cmbMjerna.SelectedItem as MjernaJedinica;
            var zgrade = cmbZgrade.SelectedItem as Zgrade;
            var vrstaenergije = cmbVrste.SelectedItem as VrstaEnergije;
           // var kolicina = txtKolicine.Text;
            Kolicina kolicina = new Kolicina();
            kolicina.UkupnaKolicina = txtKolicine.Text;
           


           

            RepositoryUnosaPodataka.InsertUnosa(zgrade, mjernajedinica, vrstaenergije,kolicina);
                MessageBox.Show("Pritisnut");
     
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

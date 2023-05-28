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
    public partial class frmMijenjanjePodataka : Form
    {
        public frmMijenjanjePodataka()
        {
            InitializeComponent();
        }

        private void frmMijenjanjePodataka_Load(object sender, EventArgs e)
        {
            ShowZgrade();
            ShowMjerna();
            ShowEnergije();
            ShowKolicine();
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
       

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var mjernajedinica = cmbMjerna.SelectedItem as MjernaJedinica;
            var zgrade = cmbZgrade.SelectedItem as Zgrade;
            var vrstaenergije = cmbVrste.SelectedItem as VrstaEnergije;
            var korisnik = frmPrijava.LoggedKorisnik;
            var combobox = int.Parse(comboBox1.Text);
            

            var unospodataka = RepositoryUnosaPodataka.GetUnosPodataka(zgrade);

            RepositoryUnosaPodataka.UpdateUnosaPodataka(zgrade,vrstaenergije, mjernajedinica,combobox);
            MessageBox.Show("Pritisnut");
        }
        private void ShowKolicine()
        {
            List<UnosPodataka> unospodataka = RepositoryUnosaPodataka.GetUnosPodataka();
            comboBox1.DataSource = unospodataka;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

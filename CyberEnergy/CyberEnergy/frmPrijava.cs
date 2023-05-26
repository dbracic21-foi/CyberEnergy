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
    public partial class frmPrijava : Form
    {
        public static Korisnik LoggedKorisnik { get; set; }

        public frmPrijava()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                LoggedKorisnik = RepositoryKorisnika.GetKorisnik(txtUsername.Text);
                if (LoggedKorisnik != null && LoggedKorisnik.CheckPassword(txtPassword.Text))



                {


                }


                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }


            LoggedKorisnik = RepositoryKorisnika.GetKorisnik(txtUsername.Text);
            if (LoggedKorisnik != null && LoggedKorisnik.CheckPassword(txtPassword.Text))

            {

                frmPregledPodataka frmPodaci = new frmPregledPodataka();

                frmPodaci.ShowDialog();

            }
            else
            {
                MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }

            Close();
        }
    }
}

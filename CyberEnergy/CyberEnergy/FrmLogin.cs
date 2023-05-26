using CyberEnergy.Models;
using CyberEnergy.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CyberEnergy
{

    public partial class frmLogin : Form
    {

        public static Korisnik LoggedKorisnik {get;set;}
        //string username = "covjek";
        //string password = "ljudina";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            showKorisnici();

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
                
                //if (txtUsername.Text == username && txtPassword.Text == password)
                
                  
                    {

                        MessageBox.Show("Dobrodošli!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
             
            
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void showKorisnici()
        {
            List<Uloga> uloge = RepositoryUloge.GetUloge();
            cmbKorisnici.DataSource = uloge;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
    }


}


        
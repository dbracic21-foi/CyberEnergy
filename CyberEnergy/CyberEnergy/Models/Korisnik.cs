using CyberEnergy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberEnergy.Models
{
    //Model Korisnika
    public class Korisnik:Persons
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }

           
        
        }
    }


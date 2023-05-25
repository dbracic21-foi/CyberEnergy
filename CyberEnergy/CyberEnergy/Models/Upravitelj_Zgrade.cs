using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CyberEnergy.Models
{
    public class Upravitelj_Zgrade:Korisnik
    {

        public int Id_Upravitelja { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }


    }
}

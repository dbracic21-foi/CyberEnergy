using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CyberEnergy.Models
{
    public class Administrator : Korisnik
    {
        public int Id_Administratora { get; set; }
        public string Usename { get; set; }
        public string Password { get; set; }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CyberEnergy.Models
{
    public class Upravitelj_Objekta:Korisnik
    {
        public string Ime { get; set; }    
        public string Prezime { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}

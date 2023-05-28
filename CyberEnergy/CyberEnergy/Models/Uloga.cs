using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberEnergy.Models
{
    //Model za uloge
    public class Uloga
    {
        public int Id_Oznaka { get; set; }
        public string Naziv_Uloge { get; set; }

        public override string ToString()
        {
            return Naziv_Uloge;
        }
    }
}

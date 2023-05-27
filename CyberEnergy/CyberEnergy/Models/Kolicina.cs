using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberEnergy.Models
{
    public class Kolicina
    {
        public int Id { get; set; }
        public string UkupnaKolicina { get; set; }

        public override string ToString()
        {
            return UkupnaKolicina;
        }
    }
}

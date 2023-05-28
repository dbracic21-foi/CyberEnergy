using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberEnergy.Models
{
    //Model apstrakne klase Persosns
    public abstract class Persons
    {
        public int Id_Korisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}

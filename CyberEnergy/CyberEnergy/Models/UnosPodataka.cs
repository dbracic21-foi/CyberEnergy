using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberEnergy.Models
{
    public class UnosPodataka
    {
        public int Id_UnosaPodataka { get; set; }   
        public Korisnik Korisnik { get; set; }
        public Zgrade Zgrade { get; set; }
        public MjernaJedinica MjernaJedinica { get; set; }
        public VrstaEnergije VrstaEnergije { get; set; }
        
        public Kolicina Kolicina { get; set; }


        public override string ToString()
        {
            return Id_UnosaPodataka.ToString();
        }


    }
}

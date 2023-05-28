using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberEnergy.Models
{
    //Model mjerne jedinice
    public class MjernaJedinica
    {
        public int Id_MjerneJedinice { get; set; }
        public string Naziv_Mjerne_Jedinice { get; set; }

        public override string ToString()
        {
            return Naziv_Mjerne_Jedinice;
        }
    }
}

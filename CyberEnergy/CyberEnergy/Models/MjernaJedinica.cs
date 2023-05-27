using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberEnergy.Models
{
    public class MjernaJedinica
    {
        public int Id_VrstePotrosnje { get; set; }
        public string NazivPotrosnje { get; set; }

        public override string ToString()
        {
            return NazivPotrosnje;
        }
    }
}

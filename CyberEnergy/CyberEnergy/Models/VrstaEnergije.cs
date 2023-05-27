using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberEnergy.Models
{
    public class VrstaEnergije
    {
      public int Id_VrstePotrosnje { get; set; }
        public string Naziv_Vrste_Potrosnje { get; set; }

        public override string ToString()
        {
            return Naziv_Vrste_Potrosnje;
        }

    }
}

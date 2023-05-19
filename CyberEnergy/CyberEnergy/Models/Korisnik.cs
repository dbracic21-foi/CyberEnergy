using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberEnergy.Models
{
    public abstract class Korisnik:Object
    {
        public int Username { get; set; }
       public string Password { get; set; }

      
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CyberEnergy.Models
{
    public class Zgrade
    {
        public int Id_Zgrade { get; set; } 
        public string Naziv_Zgrade { get; set; }
        public override string ToString()
        {
            return Naziv_Zgrade;
        }
    }
}

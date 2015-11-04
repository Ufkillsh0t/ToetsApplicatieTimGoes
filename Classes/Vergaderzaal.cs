﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie.Classes
{
    public class Vergaderzaal : Verhuur
    {
        public BTWTarief BTWTarief { get; }
        public decimal Prijs { get; set; }

        public Vergaderzaal(DateTime tijdstip, int urenVerhuurd) 
            : base(tijdstip, urenVerhuurd)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Sterkedrank : Verkoop
    {
        public BTWTarief BTWTarief { get; }
        public decimal Prijs { get; set; }

        public Sterkedrank(int aantal)
            : base(aantal)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

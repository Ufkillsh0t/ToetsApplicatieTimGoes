using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Snacks : Verkoop
    {
        public BTWTarief BTWTarief { get; }
        public decimal Prijs { get; set; }

        public Snacks(int aantal)
            : base(aantal)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

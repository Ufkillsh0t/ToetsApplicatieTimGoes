using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Feestzaal
    {
        public BTWTarief BTWTarief { get; }
        public decimal Prijs { get; set; }

        public Feestzaal(DateTime tijdstip, int urenVerhuurd)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

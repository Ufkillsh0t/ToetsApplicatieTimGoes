using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie.Classes
{
    public class Sportzaal : Verhuur
    {
        public BTWTarief BTWTarief { get; }
        public decimal Prijs { get; set; }

        public Sportzaal(DateTime tijdstip, int urenVerhuurd)
            : base(tijdstip, urenVerhuurd)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public abstract class Verhuur : IInkomsten
    {
        public int UrenVerhuurd { get; set; }
        public decimal Bedrag { get; set; }
        public DateTime TijdStip { get; set; }
        public BTWTarief BTWTarieg { get; }
        public decimal PrijsPerUur { get; }

        public Verhuur(DateTime tijdstip, int urenVerhuurd)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

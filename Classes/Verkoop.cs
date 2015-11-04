using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public abstract class Verkoop : IInkomsten
    {
        public int Aantal { get; set; }
        public decimal Bedrag { get; set; }
        public DateTime TijdStip { get; set; }
        public BTWTarief BTWTarief { get; }
        public decimal Prijs { get; }

        public Verkoop(int aantal)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

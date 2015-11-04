using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Frisdrank : Verkoop
    {
        public BTWTarief BTWTarief { get; }
        public decimal Prijs { get; set; }

        public Frisdrank(int aantal)
            : base (aantal)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

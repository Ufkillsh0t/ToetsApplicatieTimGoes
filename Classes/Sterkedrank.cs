using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Sterkedrank
    {
        public BTWTarief BTWTarief { get; }
        public decimal Prijs { get; set; }

        public Sterkedrank(int aantal)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

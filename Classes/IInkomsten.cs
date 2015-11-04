using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public interface IInkomsten
    {
        public decimal Bedrag { get; }
        public BTWTarief BTWTarief { get; }
        public DateTime Tijdstip { get; }
    }
}

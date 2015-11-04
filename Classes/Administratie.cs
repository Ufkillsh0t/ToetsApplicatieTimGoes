using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Administratie
    {
        public List<Verkoop> verkopen { get; set; }
        public List<Verhuur> verhuringen { get; set; }

        public Administratie()
        {
            verkopen = new List<Verkoop>();
            verhuringen = new List<Verhuur>();
        }

        public void Voegtoe(Verhuur verhuur)
        {
            verhuringen.Add(verhuur);
        }

        public void Voegtoe(Verkoop verkoop)
        {
            verkopen.Add(verkoop);
        }
    }
}

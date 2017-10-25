using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefenmap
{
    class brouwer
    {
        public int BrowerNr { get; set; }
        public string Brouwernaam { get; set; }
        public bool Belgisch { get; set; }
        public List<Bier> Bieren { get; set; }
        public override string ToString()
        {
            return "brouwerij "+ Brouwernaam + "(" + (Belgisch?"belgisch":"niet belgisch")+")";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefenmap
{
    [Serializable]
    public class pizza
    {
        public string Naam { get; set; }
        public List<string> Onderdelen { get; set; }
        public decimal Prijs { get; set; }
        public override string ToString()
        {
            return this.Naam+ ": "+this.Prijs + "EUR";
        }
    }
}

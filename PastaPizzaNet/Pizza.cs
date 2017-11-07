using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Pizza : Gerecht
    {
        public Pizza(string naam, decimal prijs, List<string> onderdelen) : base(naam, prijs)
        {
            this.Onderdelen = onderdelen;
        }
        public List<string> Onderdelen { get; set; }
        public override string ToString()
        {
            string lijstOnderdelen = string.Empty;
            foreach (string onderdeel in Onderdelen)
                lijstOnderdelen += onderdeel + " - ";
            lijstOnderdelen = lijstOnderdelen.Substring(0, lijstOnderdelen.Length - 3);
            return $"{base.ToString()} {lijstOnderdelen}";
        }
    }
}

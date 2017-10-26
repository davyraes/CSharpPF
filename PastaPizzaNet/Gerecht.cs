using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public abstract class Gerecht
    {
        public Gerecht(string naam ,decimal prijs)
        {
            this.Naam = naam;
            this.Prijs = prijs;
        }
        public string Naam { get; set; }
        private decimal prijsValue;

        public decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                if (value < 0)
                    throw new Exception("onjuiste prijs ingegeven:kan geen negatieve waarde bevatten");
                prijsValue=value;
            }
        }
        public override string ToString()
        {
            return $"{Naam} ({Prijs} euro)";
        }
    }
}

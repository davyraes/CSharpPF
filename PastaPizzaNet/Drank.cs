using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edrank = PastaPizzaNet.enums.Drank ;

namespace PastaPizzaNet
{
    public abstract class Drank:IBedrag
    {
        public Drank ()
        {

        }
        public Drank(Edrank naam,decimal prijs)
        {
            this.Naam = naam;
            this.Prijs = prijs;
        }
        public Edrank Naam { get; set; }
        private decimal prijsValue;

        public decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                if (value < 0)
                    throw new Exception("onjuiste prijs ingegeven");
                prijsValue = value;                    
            }
        }
        public override string ToString()
        {
            return Naam.ToString()+" ("+Prijs.ToString()+" euro)";
        }

        public decimal BerekenBedrag()
        {
            return this.Prijs;
        }
        
    }
}

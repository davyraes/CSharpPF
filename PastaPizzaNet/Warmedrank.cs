using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PastaPizzaNet.enums;
using Edrank = PastaPizzaNet.enums.Drank;

namespace PastaPizzaNet
{
    class Warmedrank : Drank
    {
        public Warmedrank(enums.Drank naam) : base(naam,Warmedrank.Prijs)
        {
            this.Naam = naam;
        }
        private Edrank naamValue;

        public new Edrank Naam
        {
            get { return naamValue; }
            set
            {
                if (!(value == Edrank.Koffie || value == Edrank.Thee))
                    throw new Exception("verkeerde dranknaam");
                naamValue = value;
            }
        }
        private static decimal prijsValue;

        public new static decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                if (value < 0)
                    throw new Exception("negatieve prijs ingegeven");
                prijsValue = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edrank = PastaPizzaNet.enums.Drank;

namespace PastaPizzaNet
{
    class Frisdrank : Drank
    {
        public Frisdrank()
        {

        }
        public Frisdrank(Edrank naam):base (naam,Frisdrank.Prijs)
        {
            this.Naam = naam;
        }
        private Edrank naamValue;

        public new Edrank Naam
        {
            get { return naamValue; }
            set
            {
                if (value == Edrank.Thee || value == Edrank.Koffie)
                    throw new Exception("Verkeerde dranknaam");
                naamValue = value;
            }
        }
        private static decimal prijsValue;

        public static new decimal Prijs
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

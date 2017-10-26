using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDessert = PastaPizzaNet.enums.Dessert;

namespace PastaPizzaNet
{
    class Dessert:IBedrag
    {
        public Dessert(EDessert naam)
        {
            this.Naam = naam;
        }
        private EDessert naamValue;

        public EDessert Naam
        {
            get { return naamValue; }
            set
            {
                naamValue = value;
                switch (Naam)
                {
                    case EDessert.Tiramisu:
                        this.Prijs = 3.0m;
                        break;
                    case EDessert.Ijs:
                        this.Prijs = 3.0m;
                        break;
                    case EDessert.Cake:
                        this.Prijs = 2.0m;
                        break;
                }                 
            }
        }
        private decimal prijsValue;

        public decimal Prijs
        {
            get { return prijsValue; }
            set
            {
                if (value < 0)
                    throw new Exception("prijs kan niet negatief zijn");
                prijsValue = value; }
        }


        public decimal BerekenBedrag()
        {
            return this.Prijs;
        }
        public override string ToString()
        {
            return $"{Naam.ToString()} ({Prijs.ToString()})";
        }
    }
}

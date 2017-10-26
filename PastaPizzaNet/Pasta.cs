using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Pasta : Gerecht
    {
        public Pasta (string naam,decimal prijs):base (naam,prijs)
        {

        }
        public Pasta(string naam, decimal prijs,string omschrijving) : base(naam, prijs)
        {
            this.Omschrijving = omschrijving;
        }
        public string Omschrijving { get; set; }
        public override string ToString()
        {
            StringBuilder resultaat = new StringBuilder();
            resultaat.Append(base.ToString());
            if (Omschrijving != null)
                resultaat.Append(" " + Omschrijving + " ");
            return resultaat.ToString();
        }
    }
}

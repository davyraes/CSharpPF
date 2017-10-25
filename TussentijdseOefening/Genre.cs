using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefening
{
    public class Genre
    {
        public Genre(string naam,Doelgroep doelgroep)
        {
            this.Naam = naam;
            this.DoelGroep = doelgroep;
        }

        private string naamValue;
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != null)
                    naamValue = value;
            }
        }
        public Doelgroep DoelGroep { get; set; }
       

    }
}

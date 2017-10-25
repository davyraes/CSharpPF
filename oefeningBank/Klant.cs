using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningBank
{
    public class Klant
    {
        public Klant(string voornaam,string achternaam)
        {
            this.Voornaam = voornaam;
            this.Naam = achternaam;
        }
        private string voornaamValue;
        public string Voornaam
        {
            get
            {
                return voornaamValue;
            }
            set
            {
                voornaamValue = value;
            }
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
                naamValue = value;
            }
        }
        public void afbeelden()
        {
            Console.WriteLine("Voornaam: {0}", this.Voornaam);
            Console.WriteLine("Familienaam: {0}", this.Naam);
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Voornaam, Naam);
        }
    }
}

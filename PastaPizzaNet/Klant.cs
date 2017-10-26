using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Klant 
    {
        public Klant(int klantId=0,string naam = "onbekende klant")
        {
            this.KlantId = klantId;
            this.Naam = naam;
        }
        public int KlantId { get; set; }
        public string Naam { get; set; }
        public override string ToString()
        {
            return Naam ;
        }
        
    }
}

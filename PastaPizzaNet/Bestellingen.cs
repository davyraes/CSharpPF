using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Bestellingen
    {
        public List<Bestelling> BestellingLijst { get; set; }
        public void AddBestelling(Bestelling bestelling)
        {
            if (BestellingLijst == null)
                BestellingLijst = new List<Bestelling>();
            BestellingLijst.Add(bestelling);
        }
    }
}

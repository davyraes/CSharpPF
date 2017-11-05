using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PastaPizzaNet
{
    
    public class Klanten
    {
        public List<Klant> KlantenBestand { get; set; }

        public void AddKlant(Klant klant)
        {
            if (KlantenBestand == null)
                KlantenBestand = new List<Klant>();
            KlantenBestand.Add(klant);
            
        }
    }
}

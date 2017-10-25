using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Personeel
{
    public class bediende:werknemer
    {
        public bediende(string naam, DateTime indienst, geslacht geslacht, decimal wedde) : base(naam, indienst, geslacht)
        {
            Wedde = wedde;
        }

        private decimal weddeValue;
        public decimal Wedde
        {
            get
            {
                return weddeValue;
            }
            set
            {
                if (value>0)
                {
                    weddeValue = value;
                }
            }
        }
        public override void afbeelden()
        {
            base.afbeelden();
            Console.WriteLine("wedde: {0}",Wedde);
        }
        public override string ToString()
        {
            return base.ToString() + " " + Wedde + " euro/maand";
        }
        public override decimal premie
        {
            get
            {
                return this.Wedde * 2m;
            }
        }
        public override decimal Bedrag
        {
            get
            {
                return Wedde*12m;
            }
        }
        public void DoeOnderhoud(Firma.Materiaal.Fotokopiemachine machine)
        {
            Console.WriteLine($"{Naam} onderhoudt machine {machine.SerieNr}");
        }
    }
}

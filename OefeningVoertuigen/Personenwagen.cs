using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningVoertuigen
{
    class Personenwagen:voertuig,IVervuiler
    {
        public Personenwagen(string polishouder = "onbepaald", decimal kostprijs = 0, int pk = 0, float gemiddeldVerbruik = 0f, string nummerplaat = "onbepaald", int aantalDeuren =4, int aantalPassagiers = 5): base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            AantalDeuren = aantalDeuren;
            AantalPassagiers = aantalPassagiers;
        }
        private int aantalDeurenValue;
        public int AantalDeuren
        {
            get
            {
                return aantalDeurenValue;
            }
            set
            {
                if (value > 0)
                    aantalDeurenValue = value;
            }
        }
        private int aantalPassagiersValue;
        public int AantalPassagiers
        {
            get
            {
                return aantalPassagiersValue;
            }
            set
            {
                if (value > 0)
                    aantalPassagiersValue = value;
            }
        }
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Aantal passagiers :{0}", this.AantalPassagiers);
            Console.WriteLine("Aantal deuren :{0}", this.AantalDeuren);
        }
        public override double GetKyotoScore()
        {
            return this.gemiddeldVerbruik * this.pk / this.AantalPassagiers;
        }

        public double GeefVervuiling()
        {
            return GetKyotoScore() * 5;
        }
    }
}

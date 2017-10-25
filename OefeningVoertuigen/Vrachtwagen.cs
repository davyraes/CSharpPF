using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningVoertuigen
{
    class Vrachtwagen:voertuig,IVervuiler
    {
        public Vrachtwagen(string polishouder = "onbepaald", decimal kostprijs = 0, int pk = 0, float gemiddeldVerbruik = 0f, string nummerplaat = "onbepaald", Single maximumLading = 10000f):base(polishouder,kostprijs,pk,gemiddeldVerbruik,nummerplaat)
        {
            maxLoad = maximumLading;
        }
        private Single maxLoadValue;
        public Single maxLoad
        {
            get
            {
                return maxLoadValue;
            }
            set
            {
                if (value > 0)
                    maxLoadValue = value;
            }
        }
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Maximum lading :{0}", this.maxLoad);
        }
        public override double GetKyotoScore()
        {
            return this.gemiddeldVerbruik * this.pk / this.maxLoad;
        }

        public double GeefVervuiling()
        {
            return GetKyotoScore() * 20;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningBank
{
    public class Zichtrekening:Rekening
    {
        public Zichtrekening(string rekeningnummer,Klant eigenaar,decimal maxKrediet):base(rekeningnummer,eigenaar)
        {
            MaxKrediet = maxKrediet;
        }
        private decimal maxKredietValue;
        public decimal MaxKrediet
        {
            get
            {
                return maxKredietValue;
            }
            set
            {
                if (value > 0)
                    throw new Exception("positieve kredietwaarde");
                maxKredietValue = value;
            }
        }
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Maximum kredtiet: {0}", MaxKrediet);
        }
    }
}

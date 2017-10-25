using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningBank
{
    public class SpaarRekening : Rekening
    {
        public SpaarRekening(string rekeningnummer,Klant eigenaar) : base(rekeningnummer,eigenaar)
        {

        }
        static SpaarRekening()
        {
            SpaarRekening.Intrest = 1.5;
        }
 
        private static double intrestValue;
        public static double Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("negatieve intrestwaarde");
                intrestValue = value;
            }
        }
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("intrest: {0}",SpaarRekening.Intrest);
        }
        public static void SetIntrest(double intrest)
        {
            Intrest = intrest;
        }
       
    }

}

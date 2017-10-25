using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningBank
{
     public class Kasbon:ISpaarmiddel
    {
        public Kasbon(DateTime aankoopdatum,decimal bedrag,int looptijd,Klant eigenaar)
        {
            this.AankoopDatum = aankoopdatum;
            this.Bedrag = bedrag;
            this.Looptijd = looptijd;
            this.Eigenaar = eigenaar;
        }
        static Kasbon()
        {
            Kasbon.Intrest = 4;
        }
        private DateTime aankoopDatumValue;
        public DateTime AankoopDatum
        {
            get
            {
                return aankoopDatumValue;
            }
            set
            {
                if (value < new DateTime(1990, 1, 1))
                    throw new Exception("onjuiste aankoopdatum");
                aankoopDatumValue = value;
            }
        }
        private decimal bedragValue;
        public decimal Bedrag
        {
            get
            {
                return bedragValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("negatieve bedrag waarde");
                bedragValue = value;
            }
        }
        private int looptijdValue;
        public int Looptijd
        {
            get
            {
                return looptijdValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("negatieve looptijd");
                looptijdValue = value;
            }
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
                    throw new Exception("negatieve intrest");
                intrestValue = value;
            }
        }
        private Klant eigenaarValue;
        public Klant Eigenaar
        {
            get
            {
                return eigenaarValue;
            }
            set
            {
                eigenaarValue = value;
            }
        }

        public void Afbeelden()
        {
            this.Eigenaar.afbeelden();
            Console.WriteLine("AankoopDatum :{0}", this.AankoopDatum);
            Console.WriteLine("Bedrag :{0}", this.Bedrag);
            Console.WriteLine("Looptijd :{0}", this.Looptijd);
            Console.WriteLine("Intrest :{0}", Kasbon.Intrest);
        }
    }
}

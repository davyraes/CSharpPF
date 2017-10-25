using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Personeel
{
    public class arbeider:werknemer
    {
        public arbeider(string naam, DateTime inDienst, geslacht Geslacht,decimal uurloon,byte ploegenstelsel):base(naam,inDienst,Geslacht)
        {
            this.uurloon = uurloon;
            this.ploegenstelsel = ploegenstelsel;
        }
        private decimal uurloonValue;
        public decimal uurloon
        {
            get
            {
                return uurloonValue;
            }
            set
            {
                if (value >= 0)
                    uurloonValue = value; 
            }
        }
        private byte ploegensteselValue;
        public byte ploegenstelsel
        {
            get
            {
                return ploegensteselValue;
            }
            set
            {
                if (value>=1&&value<=3)
                    ploegensteselValue = value;
            }
        }
        public override void afbeelden()
        {
            base.afbeelden();
            Console.WriteLine("uurloon: {0}", uurloon);
            Console.WriteLine("Ploegenstelsel: {0}", ploegenstelsel);
        }
        public override string ToString()
        {
            return base.ToString()+ " " + uurloon + " euro/uur";
        }
        public override decimal premie
        {
            get
            {
                return this.uurloon * 150m;
            }
        }
        public override decimal Bedrag
        {
            get
            {
                return uurloon*2000m;
            }
        }
    }
}

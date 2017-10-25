using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningVoertuigen
{
    public abstract class voertuig:IPrivaat,IMilieu
    {
        public voertuig(string polishouder,decimal kostprijs,int pk,float gemiddeldVerbruik,string nummerplaat)
        {
            this.kostprijs = kostprijs;
            this.pk = pk;
            this.gemiddeldVerbruik = gemiddeldVerbruik;
            this.polishouder = polishouder;
            this.nummerplaat = nummerplaat;
        }
        private string polishouderValue;
        private decimal kostprijsValue;
        private int pkValue;
        private float gemiddeldVerbruikValue;
        private string nummerplaatValue;

        public string polishouder
        {
            get
            {
                return polishouderValue;
            }
            set
            {
               polishouderValue= value;
            }
        }
        public decimal kostprijs
        {
            get
            {
                return kostprijsValue;
            }
            set
            {
                if (value>0)
                    kostprijsValue = value;
            }
        }
        public int pk
        {
            get
            {
                return pkValue;
            }
            set
            {
                pkValue = value;
            }
        }
        public float gemiddeldVerbruik
        {
            get
            {
                return gemiddeldVerbruikValue;
            }
            set
            {
                if (value >= 0)
                    gemiddeldVerbruikValue = value;
            }
        }
        public string nummerplaat
        {
            get
            {
                return nummerplaatValue;
            }
            set
            {
                nummerplaatValue = value;
            }
        }
        public virtual void Afbeelden()
        {
            Console.WriteLine("polishouder :{0}",this.polishouder);
            Console.WriteLine("kostprijs :{0}",this.kostprijs);
            Console.WriteLine("pk :{0}",this.pk);
            Console.WriteLine("gemiddeld verbruik :{0}",this.gemiddeldVerbruik);
            Console.WriteLine("nummerplaat :{0}",this.nummerplaat);
        }
        public abstract double GetKyotoScore();

        public string GeefPrivateData()
        {
            return string.Format($"polishouder : {this.polishouder}  nummerplaat : {this.nummerplaat} ");
        }

        public string GeefMilieuData()
        {
            return string.Format($"pk : {this.pk}  Kostprijs : {this.kostprijs} Verbruik : {this.gemiddeldVerbruik}");
        }
    }
}

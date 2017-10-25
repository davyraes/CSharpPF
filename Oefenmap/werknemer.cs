using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Firma.Personeel
{
    public abstract partial class werknemer:Ikost
    {
        
        static werknemer()
        {
            personeelsfeest = new DateTime(DateTime.Today.Year, 2, 1);
            while (personeelsfeest.DayOfWeek != DayOfWeek.Friday)
                personeelsfeest = personeelsfeest.AddDays(1);
        }
        public werknemer()
        {

        }
        public werknemer(string naam,DateTime inDienst,geslacht Geslacht)
        {
            this.Naam = naam;
            this.Indienst = inDienst;
            this.geslacht = Geslacht;
        }
        private string naamValue;
        private DateTime inDienstValue;
        private static DateTime personeelsfeestValue;
        private geslacht geslachtValue;
        private Afdeling afdelingValue;
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != string.Empty)
                    naamValue = value;
            }
        }

        public DateTime Indienst
        {
            get
            {
                return inDienstValue;
            }

            set
            {
                inDienstValue = value;
            }
        }
        public static DateTime personeelsfeest
        {
            get
            {
                return personeelsfeestValue;
            }
            set
            {
                personeelsfeestValue = value;

            }
        }

        public geslacht geslacht
        {
            get
            {
                return geslachtValue;
            }

            set
            {
                geslachtValue = value;
            }
        }
        public Afdeling afdeling
        {
            get
            {
                return afdelingValue;
            }
            set
            {
                afdelingValue = value;
            }
        }






        public bool verjaarAncien
        {
            get
            {
                return inDienstValue.Month == DateTime.Today.Month && inDienstValue.Day == DateTime.Today.Day;
            }
        }

        public virtual void afbeelden()
        {
            Console.WriteLine("naam : {0}", this.Naam);
            Console.WriteLine("Geslacht : {0}", this.geslacht);
            Console.WriteLine("In dienst : {0}",this.Indienst);
            Console.WriteLine("personeelsfeest : {0}",personeelsfeest);
            if (afdeling!=null)
                Console.WriteLine(afdeling);
        }
        public override string ToString()
        {
            return Naam + "  " +geslacht;
        }
        public override bool Equals(object obj)
        {
            if (obj is werknemer)
            {
                werknemer eenAnder = (werknemer)obj;
                return this.Naam == eenAnder.Naam;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return Naam.GetHashCode();
        }
        public abstract decimal premie
        {
            get;
        }
        private WerkRegime regimeValue;
        public WerkRegime Regime
        {
            get
            {
                return regimeValue;
            }
            set
            {
                regimeValue = value;
            }
        }

        public virtual decimal Bedrag
        {
            get;
            
        }

        public bool Menselijk
        {
            get
            {
                return true;
            }
        }
        public static void UitgebreideWerknemersLijst(werknemer[]werknemers)
        {
            Console.WriteLine("uitgebreide werknemerslijst : ");
            foreach (werknemer werknemer in werknemers)
                werknemer.afbeelden();
        }
        public static void KorteWernemersLijst(werknemer[]werknemers)
        {
            Console.WriteLine("verkorte werknemerslijst : ");
            foreach(werknemer werknemer in werknemers)
                Console.WriteLine(werknemer.ToString());
        }


        
    }
}

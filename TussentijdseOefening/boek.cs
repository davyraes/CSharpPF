using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefening
{
    public abstract class boek:IVoorwerpen,IAankoop
    {
        public boek(string titel,string auteur,decimal aankoopprijs,Genre genre)
        {
            this.Titel = titel;
            this.Auteur = auteur;
            this.aankoopPrijs = aankoopprijs;
            this.Genre = genre; 
        }
        static boek()
        {
            Eigenaar = "VDAB";
        }

        private string titelValue;
        public string Titel
        {
            get
            {
                return titelValue;
            }
            set
            {
                if (value != null)
                    titelValue = value;
            }
        }
        private string auteurValue;
        public string Auteur
        {
            get
            {
                return auteurValue;
            }
            set
            {
                if (value != null)
                    auteurValue = value;
            }
        }
        private static string eigenaarValue;
        private static string Eigenaar
        {
            get
            {
                return eigenaarValue;
            }
            set
            {
                if (value != null)
                    eigenaarValue = value;
            }
        }
        public Genre Genre { get; set; }

        public abstract decimal winst
        {
            get;
        }
        private decimal aankoopPrijsValue;
        public decimal aankoopPrijs
        {
            get
            {
                return aankoopPrijsValue;
            }
            set
            {
                if (value > 0)
                    aankoopPrijsValue = value;
            }
        }

        public virtual void GegevensTonen()
        {
            Console.WriteLine("Titel : {0}", Titel);
            Console.WriteLine("Auteur : {0}", Auteur);
            Console.WriteLine("Eigenaar : {0}", Eigenaar);
            Console.WriteLine("Aankoopprijs : {0} euro", aankoopPrijs);
            Console.WriteLine("genre : {0}",Genre.Naam);
            Console.WriteLine("doelgroep leeftijd : {0}",Genre.DoelGroep.Leeftijd);
            Console.WriteLine("doelgroep categorie : {0}",Genre.DoelGroep.Categorie);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefening
{
    class Woordenboek : boek
    {
        public Woordenboek(string titel, string auteur, decimal aankoopprijs, Genre genre,string taal) : base(titel, auteur, aankoopprijs, genre)
        {
            this.Taal = taal;
        }

        private string taalValue;
        public string Taal
        {
            get
            {
                return taalValue;
            }
            set
            {
                if (value != null)
                    taalValue = value;
            }
        }
        public override decimal winst
        {
            get
            {
                return this.aankoopPrijs*1.75m;
            }
        }
        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine("Taal : {0}", this.Taal);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefening
{
    class Leesboek : boek
    {
        public Leesboek(string titel, string auteur, decimal aankoopprijs, Genre genre,string onderwerp) : base(titel, auteur, aankoopprijs, genre)
        {
            this.Onderwerp = onderwerp;
        }

        private string onderwerpValue;
        public string Onderwerp
        {
            get
            {
                return onderwerpValue;
            }
            set
            {
                if (value != null)
                    onderwerpValue = value;
            }
        }
        public override decimal winst
        {
            get
            {
                return this.aankoopPrijs*1.5m;
            }
        }
        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine("Onderwerp : {0}", Onderwerp);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PastaPizzaNet.enums;

namespace PastaPizzaNet
{
    class BesteldGerecht:IBedrag
    {
        public BesteldGerecht(Gerecht gerecht,Grootte grootte)
        {
            this.Gerecht = gerecht;
            this.Grootte = grootte;
            this.Extras = new List<Extra> { };
        }
        public BesteldGerecht(Gerecht gerecht,Grootte grootte,List<Extra>extras):this(gerecht,grootte)
        {
            this.Extras = extras;
        }
        public Gerecht Gerecht { get; set; }
        public Grootte Grootte { get; set; }
        public List<Extra> Extras { get; set; }
        public override string ToString()
        {
            StringBuilder resultaat = new StringBuilder();
            resultaat.Append (Gerecht.ToString()+" ("+Grootte+")");
            if (Extras.Count!=0)
                resultaat.Append (" extra: ");
                foreach (Extra extra in Extras)
                {
                    resultaat.Append(extra+" ");
                }
            return resultaat.ToString();
        }
        public decimal BerekenBedrag()
        {
            var bedrag = Gerecht.Prijs+(decimal)Extras.Count ;
            if (this.Grootte == Grootte.Groot)
                bedrag += 3m;
            return bedrag;
        }
    }
}

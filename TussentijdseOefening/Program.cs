using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefening
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal totaleWinst = 0;
            Genre thriller = new Genre("thriller", new Doelgroep(25));
            Genre Strip = new Genre("Strip", new Doelgroep(6));
            IVoorwerpen[] voorwerpen = new IVoorwerpen[3];
            voorwerpen[0] = new Leesboek("silence of the lambs", "weet ik veel", 65, thriller, "stilte");
            voorwerpen[1] = new Woordenboek("den dikke", "van daele", 35, Strip, "nederlands");
            voorwerpen[2] = new Boekenrek(123.3, 45.6, 55.60m);
            foreach (IVoorwerpen voorwerp in voorwerpen)
            {
                totaleWinst += voorwerp.winst;
                voorwerp.GegevensTonen();
            }
            Console.WriteLine("Totale winst : {0}",totaleWinst);
        }
    }
}

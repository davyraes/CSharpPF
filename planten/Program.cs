using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planten
{
    class Program
    {
        static void Main(string[] args)
        {
            var bloemen = new List<Plant>
            {
              new Plant {PlantId=1,Plantennaam="Tulp",Kleur="Rood",Prijs=0.50m,Soort="bol" },
              new Plant {PlantId=2,Plantennaam="Krokus",Kleur="Wit",Prijs=0.20m,Soort="bol" },
              new Plant {PlantId=3,Plantennaam="Narcis",Kleur="Geel",Prijs=0.30m,Soort="bol" },
              new Plant {PlantId=4,Plantennaam="Blauw druifje",Kleur="Blauw",Prijs=0.20m,Soort="bol" },
              new Plant {PlantId=5,Plantennaam="Azalea",Kleur="Rood",Prijs=3.00m,Soort="heester" },
              new Plant {PlantId=6,Plantennaam="Forsythia",Kleur="Geel",Prijs=2.00m,Soort="heester" },
              new Plant {PlantId=7,Plantennaam="Magnolia",Kleur="Wit",Prijs=4.00m,Soort="heester"},
              new Plant {PlantId=8,Plantennaam="Waterlelie",Kleur="Wit",Prijs=2.00m,Soort="water" },
              new Plant {PlantId=9,Plantennaam="Lisdodde",Kleur="Geel",Prijs=3.00m,Soort="water" },
              new Plant {PlantId=10,Plantennaam="Kalmoes",Kleur="Geel",Prijs=2.50m,Soort="water" },
              new Plant {PlantId=11,Plantennaam="Bieslook",Kleur="Paars",Prijs=1.50m,Soort="kruid" },
              new Plant {PlantId=12,Plantennaam="Rozemarijn",Kleur="Blauw",Prijs=1.25m,Soort="kruid" },
              new Plant {PlantId=13,Plantennaam="Munt",Kleur="Wit",Prijs=1.10m,Soort="kruid" },
              new Plant {PlantId=14,Plantennaam="Dragon",Kleur="Wit",Prijs=1.30m,Soort="kruid" },
              new Plant {PlantId=15,Plantennaam="Basilicum",Kleur="Wit",Prijs=1.50m,Soort="kruid" }
            };
            var bloemenOpPrijsWit = from bloem in bloemen
                                 where bloem.Kleur=="Wit"
                                 orderby bloem.Prijs
                                 select bloem;
            foreach (var bloem in bloemenOpPrijsWit)
                Console.WriteLine($"{bloem.Plantennaam} {bloem.Kleur} {bloem.Prijs}");
            Console.WriteLine();
            var wittePlanten = from bloem in bloemen
                               where bloem.Kleur == "Wit"
                               select bloem;
            Console.WriteLine("aantal witte planten : {0}",wittePlanten.Count());
            Console.WriteLine();
            var heesters = from bloem in bloemen
                           where bloem.Soort == "heester"
                           select bloem;
            Console.WriteLine("gemiddelde prijs van de heesters : {0}",heesters.Average(bloem=>bloem.Prijs));
            Console.WriteLine();
            var kruiden = from bloem in bloemen
                          where bloem.Soort == "kruid"
                          select bloem;
            Console.WriteLine("gemiddelde prijs van de kruiden :{0}",kruiden.Average(bloem=>bloem.Prijs));
            Console.WriteLine("maximum prijs van de kruiden :{0}",kruiden.Max(bloem=>bloem.Prijs));
            Console.WriteLine();
            var beginB = from bloem in bloemen
                         where bloem.Plantennaam[0] == 'B'
                         select bloem;
            foreach(var bloem in beginB)
                Console.WriteLine(bloem.Plantennaam);
            Console.WriteLine();
            var kleuren = from bloem in bloemen
                            group bloem by bloem.Kleur;
                          
            foreach(var kleur in kleuren)
                Console.WriteLine(kleur.Key);
            Console.WriteLine();
            var naamOpKleur = from bloem in bloemen
                              group bloem by bloem.Kleur;
            foreach (var kleur in naamOpKleur)
            {
                Console.WriteLine(kleur.Key);
                foreach (var naam in kleur)
                    Console.WriteLine(naam.Plantennaam);
                Console.WriteLine();
            }
            Console.WriteLine();
            var prijsPerSoort = from bloem in bloemen
                                group bloem by bloem.Soort;
            foreach(var soort in prijsPerSoort)
            {
                Console.WriteLine(soort.Key);
                Console.WriteLine(soort.Max(bloem=>bloem.Prijs));
                Console.WriteLine();
            }
            Console.WriteLine();
            var perSoort = from bloem in bloemen
                           orderby bloem.Soort
                           group bloem by bloem.Soort;
                           
            foreach (var soort in perSoort)
            {
                Console.WriteLine(soort.Key);
                Console.WriteLine(soort.Count());
                foreach(var naam in soort)
                    Console.WriteLine(naam.Plantennaam);
                Console.WriteLine();
                  
            }
            var soortKleur = from bloem in bloemen
                             orderby bloem.Soort
                             orderby bloem.Kleur
                             group bloem by bloem.Soort;
                            
                foreach (var bloem in soortKleur)
                {
                    Console.WriteLine(bloem.Key);
                    foreach (var soort in bloem)
                        Console.WriteLine(soort.Plantennaam + " " + soort.Kleur);
                    Console.WriteLine();
                {

                }

                }     
        }
    }
}

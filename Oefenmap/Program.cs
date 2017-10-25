using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firma;
using Firma.Materiaal;
using Firma.Personeel;
using MateriaalStatus = Firma.Materiaal.Status;
using PersoneelStatus = Firma.Personeel.Status;
using System.IO;
namespace Oefenmap
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            //var getallen = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1, -2, -3,-4, -5, -6, -7, -8, -9 ,- 10, 0 };
            //Func<int,bool> IsEvenGetal = getal => getal % 2 == 0;
            //Func<int, bool> IsOneven = getal => getal % 2 != 0;
            //Func<int, bool> IsPositief = getal => getal > 0;
            //Func<int, bool> IsNegatief = getal => getal < 0;
            //Func<int, bool> Isnull = getal => getal == 0;

            //foreach (var getal in getallen)
            //{
            //    if (IsEvenGetal(getal))
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    else if (IsOneven(getal))
            //        Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write($"{getal}, ");
            //}
            //Console.WriteLine();

            //foreach (var getal in getallen)
            //{
            //    if (IsPositief(getal))
            //        Console.ForegroundColor = ConsoleColor.White;
            //    else if (IsNegatief(getal))
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //    else if (Isnull(getal))
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.Write($"{getal}, ");
            //}
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine();
            //var getallenGroterDanDrie = getallen.Where(getal => getal > 3);
            //foreach(var getal in getallenGroterDanDrie)
            //    Console.WriteLine(getal);
            //var gesorteerdeGetallen = getallen.OrderBy(getal => getal);
            //foreach(var getal in gesorteerdeGetallen)
            //    Console.WriteLine(getal);
            //Console.WriteLine(getallen.Sum(getal => getal)  ); 
            //var brouwers = new brouwers().GetBrouwers();
            //var belgischeBrouwers = from brouwer in brouwers
            //                        where brouwer.Belgisch
            //                        select brouwer;
            //Console.WriteLine("aantal belgische brouwers : {0}",belgischeBrouwers.Count());
            //var allebieren = from brouwer in brouwers
            //                 from bier in brouwer.Bieren
            //                 select bier;
            //Console.WriteLine("aantal bieren : {0}",allebieren.Count());
            //Console.WriteLine("aantal bieren : {0}",(from brouwer in brouwers from Bier in brouwer.Bieren select Bier).Count());
            //var belgischeBieren = from brouwer in brouwers
            //                      from Bier in brouwer.Bieren
            //                      select Bier;
            //Console.WriteLine("aantal belgische bieren:{0}",belgischeBieren.Count());
            //var bieren = from brouwer in brouwers
            //             from Bier in brouwer.Bieren
            //             select Bier;
            //Console.WriteLine("het gemiddelde alcoholgehalte van de bieren : {0}",bieren.Average(Bier=>Bier.Alcohol));
            //string directorynaam = @"c:/Data";
            //string file = "pizzas.txt";
            //string bestand = directorynaam + @"/" + file;

            //Directory.CreateDirectory(directorynaam);

            //if(!File.Exists(bestand))
            //{
            //    Console.WriteLine("het bestand {0} bestaat niet",bestand);
            //    Console.WriteLine("het wordt gecreëerd");
            //    string tekst = "Pizza Margherita (tomatensaus - mozzarella): 8 EUR";
            //    File.WriteAllText(bestand, tekst);
            //    tekst = Environment.NewLine + "Pizza Vegetariana (tomatensaus-mozzarella-groenten): 9,5EUR";
            //    File.AppendAllText(bestand, tekst);
            //}
            //else
            //{
            //    Console.WriteLine("Het bestand {0} bestaat",bestand);
            //    string bestandsinfo = "Datum creatie: " + File.GetCreationTime(bestand) +
            //        System.Environment.NewLine +
            //        "datum laatst gebruikt: " + File.GetLastAccessTime(bestand);
            //    Console.WriteLine(bestandsinfo);
            //    Console.WriteLine("De inhoud van het bestand:");
            //    string tekst = File.ReadAllText(bestand);
            //    Console.WriteLine(tekst);
            //    File.Delete(bestand);
            List<pizza> pizzas = new List<pizza>
            {
                new pizza
                {
                    Naam="Pizza Margherita",
                    Onderdelen = new List<string> {"Tomatensaus","Mozzarella" },
                    Prijs = 8m
                },
                new pizza
                {
                    Naam="Pizza Vegetariana",
                    Onderdelen = new List<string> {"Tomatensaus","Mozzarella","Groenten" },
                    Prijs = 9.5m
                },
                new pizza
                {
                    Naam="Pizza Napoli",
                    Onderdelen= new List<string> {"Tomatensaus","Mozzarella","Ansjovis","Kappers","Olijven" },
                    Prijs = 10m
                }
            };
            string locatie = @"c:\data\";
            StringBuilder pizzaRegel;
            try
            {
                using(var schrijver = new StreamWriter(locatie+"pizzas.txt"))
                {
                    foreach(var pizza in pizzas)
                    {
                        pizzaRegel = new StringBuilder();
                        pizzaRegel.Append(pizza.Naam + ":");
                        pizzaRegel.Append(pizza.Onderdelen.Count.ToString() + ":");
                        foreach (var onderdeel in pizza.Onderdelen)
                            pizzaRegel.Append(onderdeel + ":");
                        pizzaRegel.Append(pizza.Prijs);
                        schrijver.WriteLine(pizzaRegel);
                    }
                }
            }
            catch(IOException)
            {
                Console.WriteLine("Fout bij het schrijven naar het bestand!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
       

    }
}
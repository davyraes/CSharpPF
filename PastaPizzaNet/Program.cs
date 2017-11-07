using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PastaPizzaNet.enums;
using Edrank = PastaPizzaNet.enums.Drank;
using Edessert = PastaPizzaNet.enums.Dessert;
namespace PastaPizzaNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //prijzen dranken
            Frisdrank.Prijs = 2m;
            Warmedrank.Prijs = 2.5m;
            Klanten klanten = bestanden.LeesKlanten();
            gerechten gerechten = bestanden.LeesGerechten();
            Bestellingen bestellingen = bestanden.LeesBestellingen();
            //Klanten klanten = new Klanten()
            //{
            //    KlantenBestand = new List<Klant>
            //    {
            //        new Klant(),
            //        new Klant(1, "Jan Janssen"),
            //        new Klant(2, "Piet Peeters"),
            //    }
            //};
            //gerechten gerechten = new gerechten()
            //{
            //    GerechtenLijst = new List<Gerecht>
            //    {
            //        new Pizza("Pizza Margherita", 8m, new List<string> { "Tomatensaus", "Mozzarella" }),
            //        new Pizza("Pizza Napoli", 10m, new List<string> { "Tomatensaus", "Mozzarella", "Ansjovis", "Kappers", "Olijven" }),
            //        new Pizza("Pizza Lardiera",9.5m,new List<string> {"Tomatensaus","Mozzarella","Spek" }),
            //        new Pizza("Pizza Vegetariana",9.5m,new List<string> {"Tomatensaus","Mozzarella","Groenten" }),
            //        new Pasta ("Spaghetti Bolognese", 12m, "met gehaktsaus"),
            //        new Pasta("Spaghetti Carbonara", 13m, "spek, roomsaus en parmezaanse kaas"),
            //        new Pasta("Penne Arrabbiata",13m,"met pittige tomatensaus"),
            //        new Pasta("Lasagne", 15m)
            //    }
            //};
            //Bestellingen bestellingen = new Bestellingen()
            //{
            //    BestellingLijst = new List<Bestelling>
            //    {
            //        new Bestelling(klanten.KlantenBestand[1], new BesteldGerecht(gerechten.GerechtenLijst[0], Grootte.Groot, new List<enums.Extra> { Extra.Kaas, Extra.Look }), new Frisdrank(Edrank.Water), new Dessert(Edessert.Ijs), 2),
            //        new Bestelling(klanten.KlantenBestand[2], new BesteldGerecht(gerechten.GerechtenLijst[0], Grootte.Klein), new Frisdrank(Edrank.Water), new Dessert(Edessert.Tiramisu)),
            //        new Bestelling(klanten.KlantenBestand[2], new BesteldGerecht(gerechten.GerechtenLijst[1], Grootte.Groot), new Warmedrank(Edrank.Thee), new Dessert(Edessert.Ijs)),
            //        new Bestelling(klanten.KlantenBestand[0], new BesteldGerecht(gerechten.GerechtenLijst[7], Grootte.Klein, new List<Extra> { Extra.Look })),
            //        new Bestelling(klanten.KlantenBestand[1], new BesteldGerecht(gerechten.GerechtenLijst[5], Grootte.Klein), new Frisdrank(Edrank.CocaCola)),
            //        new Bestelling(klanten.KlantenBestand[2], new BesteldGerecht(gerechten.GerechtenLijst[4], Grootte.Groot, new List<Extra> { Extra.Kaas }), new Frisdrank(Edrank.CocaCola), new Dessert(Edessert.Cake)),
            //        new Bestelling(klanten.KlantenBestand[2], new Warmedrank(Edrank.Koffie), 3),
            //        new Bestelling(klanten.KlantenBestand[1], new Dessert(Edessert.Tiramisu))
            //    }
            //};

            ////menu

            //Pizza pizzaMargherita = new Pizza("Pizza Margherita", 8m, new List<string> { "Tomatensaus", "Mozzarella" });
            //Pizza pizzaNapoli = new Pizza("Pizza Napoli", 10m, new List<string> { "Tomatensaus", "Mozzarella", "Ansjovis", "Kappers", "Olijven" });
            //Pasta lasagne = new Pasta("Lasagne", 15m);
            //Pasta spaghettiBolognese = new Pasta("Spaghetti Bolognese", 12m, "met gehaktsaus");
            //Pasta spaghettiCarbonara = new Pasta("Spaghetti Carbonara", 13m, "spek, roomsaus en parmezaanse kaas");

            ////lijst van bestellingen
            //List<Bestelling> bestellingen2 = new List<Bestelling>
            //{
            //new Bestelling(new Klant(1, "Jan Janssen"), new BesteldGerecht(pizzaMargherita, Grootte.Groot, new List<enums.Extra> { Extra.kaas, Extra.Look }), new Frisdrank(Edrank.Water), new Dessert(Edessert.Ijs), 2),
            //new Bestelling(new Klant(2, "Piet Peeters"), new BesteldGerecht(pizzaMargherita, Grootte.Klein), new Frisdrank(Edrank.Water), new Dessert(Edessert.Tiramisu)),
            //new Bestelling(new Klant(2, "Piet Peeters"), new BesteldGerecht(pizzaNapoli, Grootte.Groot), new Warmedrank(Edrank.Thee), new Dessert(Edessert.Ijs)),
            //new Bestelling(new Klant(), new BesteldGerecht(lasagne, Grootte.Klein, new List<Extra> { Extra.Look })),
            //new Bestelling(new Klant(1, "Jan Janssen"), new BesteldGerecht(spaghettiCarbonara, Grootte.Klein), new Frisdrank(Edrank.CocaCola)),
            //new Bestelling(new Klant(2, "Piet Peeters"), new BesteldGerecht(spaghettiBolognese, Grootte.Groot, new List<Extra> { Extra.kaas }), new Frisdrank(Edrank.CocaCola), new Dessert(Edessert.Cake)),
            //new Bestelling(new Klant(2, "Piet Peeters"), new Warmedrank(Edrank.Koffie), 3),
            //new Bestelling(new Klant(1, "Jan Janssen"), new Dessert(Edessert.Tiramisu))
            //};
            try
            {
                int i = 1;
                foreach (Bestelling bestelling in bestellingen.BestellingLijst)
                {
                    Console.WriteLine($"bestelling {i++}:");
                    bestelling.ToonBestelling();
                    Console.WriteLine();
                    for (int j = 0; j < 30; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                //bestelling van Jan Janssen
                var bestellingVanJan = from Bestelling in bestellingen.BestellingLijst
                                       where Bestelling.Klant.Naam == "Jan Janssen"
                                       select Bestelling;
                Console.WriteLine("bestellingen van Jan Janssen");
                Console.WriteLine();
                decimal totaalJan = 0m;
                foreach (var bestelling in bestellingVanJan)
                {
                    bestelling.ToonBestelling();
                    Console.WriteLine();
                    totaalJan += bestelling.BerekenBedrag();
                }
                Console.WriteLine("totaal bedrag van de bestellingen: " + totaalJan);
                Console.WriteLine();
                for (int j = 0; j < 30; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                //bestellingen per klant
                var bestellingenPerKlant = from bestelling in bestellingen.BestellingLijst
                                           where bestelling.Klant.KlantId != 0
                                           group bestelling by bestelling.Klant.Naam
                                         into bestellingPerKlant
                                           orderby bestellingPerKlant.Key
                                           select bestellingPerKlant;
                foreach (var klant in bestellingenPerKlant)
                {
                    decimal totaalklant = 0m;
                    Console.WriteLine($"bestellingen van {klant.Key}");
                    Console.WriteLine();
                    foreach (var bestelling in klant)
                    {
                        bestelling.ToonBestelling();
                        Console.WriteLine();
                        totaalklant += bestelling.BerekenBedrag();

                    }
                    Console.WriteLine($"Het totale bedrag van {klant.Key.ToString()} bedraagt {totaalklant} euro");
                    Console.WriteLine();
                    for (int j = 0; j < 30; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }
                var bestellingenOnbekendeKlanten = from bestelling in bestellingen.BestellingLijst
                                                   where bestelling.Klant.KlantId == 0
                                                   select bestelling;
                Console.WriteLine("onbekende klanten");
                Console.WriteLine();
                foreach (var bestelling in bestellingenOnbekendeKlanten)
                {
                    bestelling.ToonBestelling();
                    Console.WriteLine();
                    for (int j = 0; j < 30; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine ("bestanden niet geopend");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            bestanden.SchrijkKlanten(klanten);
            bestanden.SchrijfGerecht(gerechten);
            bestanden.SchrijfBestelling(bestellingen);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PastaPizzaNet
{
   
    public static class bestanden
    {
        const string bestandKlanten = @"c:\data\klanten.txt";
        const string bestandGerechten = @"c:\data\gerechten.txt";
        const string bestandBestellingen = @"c:\data\bestellingen.txt";
        public static void SchrijkKlanten(Klanten klanten)
        {
            try
            {
                
                using (var schrijver = new StreamWriter(bestandKlanten))
                {
                    foreach (Klant klant in klanten.KlantenBestand)
                    {
                        if (klant.KlantId != 0)
                        {
                            var regel = new StringBuilder();
                            regel.Append(klant.KlantId);
                            regel.Append("#");
                            regel.Append(klant.Naam);
                            schrijver.WriteLine(regel);
                        }
                    }
                }
                
            }
            catch (IOException)
            {
                throw new Exception("bestand niet gevonden");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Klanten LeesKlanten()
        {
            try
            {
                if (!File.Exists(bestandKlanten))
                    throw new Exception("bestand niet gevonden");
                
                using (var lezer = new StreamReader(bestandKlanten))
                {
                    Klanten klanten = new Klanten();
                    var regel = lezer.ReadLine();
                    while (regel != null)
                    {
                        var woorden = regel.Split(new[] { '#' });
                        Klant klant = new Klant
                        {
                            KlantId = Convert.ToInt16(woorden[0]),
                            Naam = woorden[1]
                        };
                        klanten.AddKlant(klant);
                        regel = lezer.ReadLine();
                    }

                    return klanten;
                }
            }
            catch(IOException)
            {
                throw new Exception("bestand niet gevonden");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void SchrijfGerecht(gerechten gerechten) 
        {
            try
            {

                using (var schrijver = new StreamWriter(bestandGerechten))
                {
                    var pizzas = from Pizza in gerechten.GerechtenLijst
                                 where Pizza is Pizza
                                 select Pizza;
                    foreach (Pizza gerecht in pizzas)
                    {
                        var regel = new StringBuilder();
                        regel.Append($"Pizza#{ gerecht.Naam}#{gerecht.Prijs}");
                        foreach (var ingredient in gerecht.Onderdelen)
                            regel.Append($"#{ingredient.ToString()}");
                        schrijver.WriteLine(regel);
                    }
                    var pastas = from pasta in gerechten.GerechtenLijst
                                 where pasta is Pasta
                                 select pasta;
                    foreach (Pasta gerecht in pastas)
                    {
                        var regel = new StringBuilder();
                        regel.Append($"Pasta#{gerecht.Naam}#{gerecht.Prijs}#");
                        if (gerecht.Omschrijving != null)
                            regel.Append(gerecht.Omschrijving);
                    }
                }
            }
            catch (IOException)
            {
                throw new Exception("bestand niet gevonden");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static gerechten LeesGerechten()
        {
            try
            {
                if (!File.Exists(bestandGerechten))
                    throw new Exception("bestand niet gevonden");
                using (var lezer = new StreamReader(bestandGerechten))
                {
                    gerechten gerechten = new gerechten();
                    var regel = lezer.ReadLine();
                    while (regel!=null)
                    {
                        var woorden = regel.Split(new[] { '#' });
                        var naam = woorden[1];
                        var prijs = Convert.ToDecimal(woorden[2]);
                        if (woorden[0]=="Pizza")
                        {
                            var onderdelen = new List<string>();
                            for (int i = 3; i < woorden.Length; i++)
                                    onderdelen.Add(woorden[i]);
                            gerechten.AddGerechten(new Pizza(naam, prijs, onderdelen));
                        }
                        else if (woorden[0]=="Pasta")
                        {
                            string omschrijving;
                            if (woorden[3] != null)
                            {
                                omschrijving = woorden[3];
                                gerechten.AddGerechten(new Pasta(naam, prijs, omschrijving));
                            }
                            else
                                gerechten.AddGerechten(new Pasta(naam, prijs));     
                        }
                        regel = lezer.ReadLine();
                    }
                    return gerechten;
                }
                
            }
            catch(IOException)
            {
                throw new Exception("bestand niet gevonden");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void SchrijfBestelling(Bestellingen bestellingen)
        {
            try
            {
                using (var schrijver = new StreamWriter(bestandBestellingen))
                {
                    foreach (Bestelling bestelling in bestellingen.BestellingLijst)
                    {
                        var regel = new StringBuilder();
                        regel.Append($"{ bestelling.Klant.KlantId}#");
                        if (bestelling.BesteldGerecht != null)
                        {
                            regel.Append($"{bestelling.BesteldGerecht.Gerecht.Naam}-{bestelling.BesteldGerecht.Grootte}-{bestelling.BesteldGerecht.Extras.Count}");
                            if (bestelling.BesteldGerecht.Extras.Count != 0)
                                foreach (var extra in bestelling.BesteldGerecht.Extras)
                                    regel.Append($"-{extra}");
                        }
                        regel.Append("#");
                        if (bestelling.Drank is Frisdrank)
                            regel.Append($"F-{bestelling.Drank.Naam}");
                        else if (bestelling.Drank is Warmedrank)
                            regel.Append($"W-{bestelling.Drank.Naam}");
                        regel.Append("#");
                        if (bestelling.Dessert != null)
                            regel.Append($"{bestelling.Dessert.Naam}");
                        regel.Append($"#{bestelling.Aantal}");
                        schrijver.WriteLine(regel);
                    }
                }
            }
            catch (IOException)
            {
                throw new Exception("bestand niet gevonden");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static Bestellingen LeesBestellingen()
        {
            try
            {
                if (!File.Exists(bestandBestellingen))
                    throw new Exception("bestand niet gevonden");
                using (var lezer = new StreamReader(bestandBestellingen))
                {
                    var bestellingen = new Bestellingen();
                    var regel = lezer.ReadLine();
                    var klant = new Klant();
                    var klanten = LeesKlanten();
                    var gerechten = LeesGerechten();
                    while(regel!=null)
                    {
                        var woorden = regel.Split(new[] { '#' });
                        var klantid = Convert.ToInt32 (woorden[0])-1;
                        if (!(klantid < 0))
                            klant = klanten.KlantenBestand[klantid];
                        else
                            klant = new Klant();
                        BesteldGerecht besteldGerecht = new BesteldGerecht();
                        Drank drinken = null;
                        Dessert dessert = null;

                        if (!string.IsNullOrEmpty(woorden[1]))
                        {

                            var gerecht = woorden[1].Split(new[] { '-' });
                            besteldGerecht.Gerecht = gerechten.GerechtenLijst.Find(g => g.Naam == gerecht[0]);


                            //foreach (Gerecht Gerecht in gerechten.GerechtenLijst)
                            //    if (Gerecht.Naam == gerecht[0])
                            //    {
                            //        besteldGerecht.Gerecht = Gerecht;
                            //        break;
                            //    }



                            if (gerecht[1] == "Groot")
                                besteldGerecht.Grootte = enums.Grootte.Groot;
                            else
                                besteldGerecht.Grootte = enums.Grootte.Klein;
                            var aantalExtras = Convert.ToInt32(gerecht[2]);
                            var extras = new List<enums.Extra>();
                            if (aantalExtras > 0)
                            {
                                for (int i = 0; i < aantalExtras; i++)
                                    switch (gerecht[i + 3].ToLower())
                                    {
                                        case "kaas":
                                            extras.Add(enums.Extra.Kaas);
                                            break;
                                        case "look":
                                            extras.Add(enums.Extra.Look);
                                            break;
                                        case "brood":
                                            extras.Add(enums.Extra.Brood);
                                            break;
                                    }
                            }
                            besteldGerecht.Extras = extras;
                        }
                        else
                            besteldGerecht = null;
                        if (!string.IsNullOrEmpty(woorden[2]))
                        {
                            var drank = woorden[2].Split(new[] { '-' });
                            if(drank[0]=="F")
                            {
                                switch(drank[1].ToLower())
                                {
                                    case "water":
                                        drinken = new Frisdrank(enums.Drank.Water);
                                        break;
                                    case "cocacola":
                                        drinken = new Frisdrank(enums.Drank.CocaCola);
                                        break;
                                    case "limonade":
                                        drinken = new Frisdrank(enums.Drank.Limonade);
                                        break;
                                    default:
                                        drinken = null;
                                        break;
                                }
                            }
                            else if (drank[0]=="W")
                            {
                                switch(drank[1].ToLower())
                                {
                                    case "koffie":
                                        drinken = new Warmedrank(enums.Drank.Koffie);
                                        break;
                                    case "thee":
                                        drinken = new Warmedrank(enums.Drank.Thee);
                                        break;
                                    default:
                                        drinken = null;
                                        break;
                                }
                            }
                        }
                        if (!string.IsNullOrEmpty(woorden[3]))
                        {
                            switch(woorden[3].ToLower())
                            {
                                case "ijs":
                                    dessert = new Dessert(enums.Dessert.Ijs);
                                    break;
                                case "cake":
                                    dessert = new Dessert(enums.Dessert.Cake);
                                    break;
                                case "tiramisu":
                                    dessert = new Dessert(enums.Dessert.Tiramisu);
                                    break;
                            }
                        }
                        var aantal = Convert.ToInt32(woorden[4]);
                        bestellingen.AddBestelling(new Bestelling()
                        {
                            Klant = klant,                           
                            BesteldGerecht = besteldGerecht,
                            Drank = drinken,
                            Dessert = dessert,
                            Aantal = aantal
                        });
                        regel = lezer.ReadLine();
                    }
                    return bestellingen;
                }
            }
            catch (IOException)
            {
                throw new Exception("bestand niet gevonden");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PastaPizzaNet
{
   
    public class bestanden
    {
        const string bestandKlanten = @"c:\data\klanten.txt";
        const string bestandGerechten = @"c:\data\gerechten.txt";
        const string bestandBestellingen = @"c:\data\bestellingen.txt";
        public void SchrijkKlanten(Klanten klanten)
        {
            try
            {
                if (!File.Exists(bestandKlanten))
                    File.Create(bestandKlanten); 
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
        public void LeesKlanten()
        {
            try
            {
                if (!File.Exists(bestandKlanten))
                    File.Create(bestandKlanten);
                using (var lezer = new StreamReader(bestandKlanten))
                {
                    while (lezer.ReadLine()!=null)
                    {
                        
                        var regel = lezer.ReadLine();
                        var woorden[] = regel.Split('#');
                    }
                }
            }
            catch(IOException)
            {
                throw new Exception("bestand niet gevonden");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SchrijfGerecht(gerechten gerechten) 
        {
            try
            {
                if (!File.Exists(bestandGerechten))
                    File.Create(bestandGerechten);
                using (var schrijver = new StreamWriter(bestandGerechten, true))
                {
                    var gerechtenPerSoort = gerechten.GerechtenLijst.OrderBy(type => gerechten.GetType());
                    foreach (Pizza gerecht in gerechtenPerSoort)
                    {
                        var regel = new StringBuilder();
                        regel.Append(gerecht.GetType());
                        regel.Append("#");
                        regel.Append(gerecht.Naam);
                        regel.Append("#");
                        regel.Append(gerecht.Prijs);
                        regel.Append("#");
                        foreach (var ingredient in gerecht.Onderdelen)
                            regel.Append(ingredient.ToString());                         
                        schrijver.WriteLine(regel);
                    }
                    foreach(Pasta gerecht in gerechtenPerSoort)
                    {
                        var regel = new StringBuilder();
                        regel.Append(gerecht.GetType());
                        regel.Append("#");
                        regel.Append(gerecht.Naam);
                        regel.Append("#");
                        regel.Append(gerecht.Prijs);
                        regel.Append("#");
                        if (gerecht.Omschrijving!= null)
                            regel.Append(gerecht.Omschrijving);
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
        public void PrintDish()
        {

        }
        public void SchrijfBestellingenNaarBestand(Bestellingen bestellingen)
        {
            try
            {
                using (var schrijver = new StreamWriter(bestandBestellingen, true))
                {
                    foreach (Bestelling bestelling in bestellingen.BestellingLijst)
                    {
                        var regel = new StringBuilder();
                        regel.Append(bestelling.Klant.KlantId);
                        if (bestelling.BesteldGerecht != null)
                        {
                            regel.Append($"#{bestelling.BesteldGerecht.Gerecht.Naam}-{bestelling.BesteldGerecht.Grootte}-{bestelling.BesteldGerecht.Extras.Count}");
                            if (bestelling.BesteldGerecht.Extras.Count != 0)
                                foreach (var extra in bestelling.BesteldGerecht.Extras)
                                    regel.Append($"-{extra}");
                        }
                        if (bestelling.Drank is Frisdrank)
                            regel.Append($"#F-{bestelling.Drank.Naam}");
                        else if (bestelling.Drank is Warmedrank)
                            regel.Append($"#W-{bestelling.Drank.Naam}");
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
        public void ToonBestellingenVanBestand()
        {
            try
            {
                using (var lezer = new StreamReader(bestandBestellingen))
                {
                    var regel = lezer.ReadLine();
                }
            }
        }
    }
}

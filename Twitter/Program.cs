using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        { 
            var twitter = new Twitter();
            int keuze = MaakKeuze();
            while (keuze != 4)
            {
                string gebruiker, bericht;
                switch (keuze)
                {
                    case 1:
                        Console.WriteLine("Geef gebruikersnaam:");
                        gebruiker = Console.ReadLine();
                        Console.WriteLine("schrijf je bericht(max140 tekens):");
                        bericht = Console.ReadLine();
                        Tweet tweet = new Tweet() { Naam = gebruiker, Bericht = bericht, Tijdstip = DateTime.Now };
                        twitter.BerichtPlaatsen(tweet);
                        break;
                    case 2:
                        var tweets = twitter.AlleTweets();
                        foreach(var eentweet in tweets)
                            Console.WriteLine(eentweet);
                        break;
                    case 3:
                        Console.WriteLine("Geef de gebruikersnaam waarvan u de berichten wil zien.");
                        gebruiker = Console.ReadLine();
                        var tweetsVan = twitter.TweetsVan(gebruiker);
                        if (tweetsVan.Count!=0)
                            foreach(var eenTweetvan in tweetsVan)
                                Console.WriteLine(eenTweetvan);
                        else
                            Console.WriteLine("geen tweets van deze gebruiker gevonden");
                        break;
                    default:
                        keuze = 0;
                        break;

                }
               keuze = MaakKeuze();

            }
        }
        private static int MaakKeuze()
        {
            int keuze;
            Console.WriteLine("maak een keuze uit volgende menu");
            Console.WriteLine("1.Een twitterbericht plaatsen.");
            Console.WriteLine("2.Alle twitterberichten lezen");
            Console.WriteLine("3.Twitter berichten van een gebruiker lezen");
            Console.WriteLine("4.Stoppen");
            while(!int.TryParse(Console.ReadLine(),out keuze)||(keuze!=1&&keuze!=2&&keuze!=3&&keuze!=4))
                Console.WriteLine("Verkeerde keuze,geef een getal (1 ,2 ,3 of 4):");
            return keuze;        
        }
    }
}

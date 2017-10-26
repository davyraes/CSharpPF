using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PastaPizzaNet
{
    class Bestelling:IBedrag
    {
        const string bestand = @"c:\data\bestellingen.txt"; 
        public Bestelling(Klant klant,int aantal =1)
        {
            this.Klant = klant;
            this.Aantal = aantal;
        }
        public Bestelling(Klant klant, BesteldGerecht besteldGerecht, int aantal = 1):this(klant,aantal)
        {
            this.BesteldGerecht = besteldGerecht;
        }
        public Bestelling(Klant klant,Drank drank,int aantal=1):this(klant ,aantal)
        {
            this.Drank = drank;
        }
        public Bestelling(Klant klant ,Dessert dessert,int aantal=1):this(klant,aantal)
        {
            this.Dessert = dessert;
        }
        public Bestelling(Klant klant,BesteldGerecht besteldgerecht,Drank drank,int aantal =1):this(klant,besteldgerecht,aantal)
        {
            this.Drank = drank;
        }
        public Bestelling(Klant klant,BesteldGerecht besteldgerecht,Dessert dessert,int aantal =1):this(klant,besteldgerecht,aantal)
        {
            this.Dessert = dessert;
        }
        public Bestelling(Klant klant,BesteldGerecht besteldgerecht,Drank drank ,Dessert dessert,int aantal = 1):this(klant,besteldgerecht,drank,aantal)
        {
            this.Dessert = dessert;
        }
        public Klant Klant { get; set; }
        public BesteldGerecht BesteldGerecht { get; set; }
        public Drank Drank { get; set; }
        public Dessert Dessert { get; set; }
        private int aantalValue;

        public int Aantal
        {
            get { return aantalValue; }
            set
            {
                if (value < 0)
                    throw new Exception("onmogelijk aantal : waarde mag niet negatief zijn");
                aantalValue = value;
            }
        }
        public void ToonBestelling()
        {
            Console.WriteLine("klant: " + Klant.ToString());
            if (BesteldGerecht!=null)
                Console.WriteLine($"gerecht: {BesteldGerecht.ToString()} (bedrag: {BesteldGerecht.BerekenBedrag().ToString()} euro)");
            if (Drank != null)
                Console.WriteLine("Drank: " + Drank);
            if (Dessert!=null)
                Console.WriteLine("Dessert: "+Dessert);
            Console.WriteLine("Aantal: "+Aantal.ToString());
            Console.WriteLine($"bedrag van deze bestelling: {this.BerekenBedrag()} euro");
            
        }

        public decimal BerekenBedrag()
        {
            decimal rekening=0m;
            if (BesteldGerecht!=null)
                rekening = BesteldGerecht.BerekenBedrag();
            if (Drank!=null)
                rekening += Drank.BerekenBedrag();
            if (Dessert != null)
                rekening += Dessert.BerekenBedrag();
            if (BesteldGerecht!=null&&Drank != null && Dessert != null)
                rekening *= 0.9m;

            return rekening*Aantal;
        }
        public void BestellingNaarBestand()
        {
            try
            {
                using (var schrijver = new StreamWriter(bestand, true))
                {
                    var regel = new StringBuilder();
                    regel.Append(Klant.KlantId);
                    if (BesteldGerecht != null)
                    {                        
                        regel.Append($"#{BesteldGerecht.Gerecht.Naam}-{BesteldGerecht.Grootte}-{BesteldGerecht.Extras.Count}");
                        if (BesteldGerecht.Extras.Count!=0)
                            foreach (var extra in BesteldGerecht.Extras)
                                regel.Append($"-{extra}");
                    }
                    if (this.Drank is Frisdrank)
                        regel.Append($"#F-{Drank.Naam}");
                    else if (this.Drank is Warmedrank)
                        regel.Append($"#W-{Drank.Naam}");
                    if (this.Dessert != null)
                        regel.Append($"{Dessert.Naam}");
                    regel.Append($"#{Aantal}");
                    schrijver.WriteLine(regel);

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
        public void BestandNaarBestelling()
        {

        }
    }
}

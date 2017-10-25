using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    [Serializable]
    public class Tweet
    {
        public string Naam { get; set; }
        private string berichtValue;
        
        public string Bericht
        {
            get { return berichtValue; }
            set
            {
                berichtValue = value.Length <= 140 ? value : value.Substring(0, 140);
            }
        }
        public DateTime Tijdstip { get; set; }
        public override string ToString()
        {
            StringBuilder tweet = new StringBuilder ( $"{Naam} : {Bericht} : " );
            TimeSpan verschil = DateTime.Now - this.Tijdstip;
            if (verschil.Days > 0)
                tweet.Append(this.Tijdstip.ToShortDateString());
            else if (verschil.Hours > 0)
                tweet.Append(verschil.Hours + "uur geleden");
            else if (verschil.Minutes > 0)
                tweet.Append(verschil.Minutes + (verschil.Minutes == 1 ? " minuut" : " minuten") + " geleden");
            else
                tweet.Append(this.Tijdstip.ToShortDateString());
            return tweet.ToString();
        }
    }
}

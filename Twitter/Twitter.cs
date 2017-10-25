using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Twitter
{
    [Serializable]
    public class Twitter
    {
        const string bestandslocatie = @"c:\data\twitter.obj";     
        public void BerichtPlaatsen(Tweet tweet)
        {
            Tweets tweets;
            if (File.Exists(bestandslocatie))
            {
                tweets = LeesTweets();
            }
            else
            {
                tweets = new Tweets();
            }
               
            tweets.AddTweet(tweet);
            SchrijfTweets(tweets);
        }
        public List<Tweet> AlleTweets()
        {
            if (File.Exists(bestandslocatie))
            {
                var tweets = LeesTweets();
                return tweets.Berichten().OrderByDescending(t=>t.Tijdstip).ToList();
            }
            else
            {
                throw new Exception("het bestand is niet gevonden");
            }

        }
        public List<Tweet> TweetsVan (string gebruiker)
        {
            return AlleTweets().Where(t => t.Naam.ToUpper() == gebruiker.ToUpper()).ToList();
        }
        private Tweets LeesTweets()
        {
            try
            {
                using (var bestand = File.Open(bestandslocatie, FileMode.Open, FileAccess.Read))
                {
                    var lezer = new BinaryFormatter();
                    return ((Tweets)lezer.Deserialize(bestand));
                }
            }
            catch(IOException)
            {
                throw new Exception("fout bij het openen van het bestand!");
            }
            catch(SerializationException)
            {
                throw new Exception("fout bij het deserialiseren");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void SchrijfTweets(Tweets tweets)
        {
            try
            {
                using(var bestand = File.Open(bestandslocatie, FileMode.OpenOrCreate))
                {
                    var schrijver = new BinaryFormatter();
                    schrijver.Serialize(bestand, tweets);
                }
            }
            catch(IOException)
            {
                throw new Exception("fout bij het openen van het bestand");
            }
            catch(SerializationException)
            {
                throw new Exception("fout bij het serialiseren");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefenmap
{
    class brouwers
    {
        public List<brouwer>GetBrouwers()
        {
            brouwer palm = new brouwer { BrowerNr = 1, Brouwernaam = "palm", Belgisch = true };
            palm.Bieren = new List<Bier>
            {
            new Bier {BierNr=1,Biernaam="palm dobbel",Alcohol=6.2f,Brouwer=palm },
            new Bier { BierNr = 2, Biernaam = "palm green", Alcohol = 0.1f, Brouwer = palm },
            new Bier { BierNr = 3, Biernaam = "palm royal", Alcohol = 7.5f, Brouwer = palm }
            };
            brouwer hertogJan = new brouwer { BrowerNr = 2, Brouwernaam = "hertog jan", Belgisch = false };
            hertogJan.Bieren = new List<Bier>
            {
                new Bier {BierNr=4,Biernaam="hertog jan dubbel",Alcohol=7.0f,Brouwer=hertogJan },
                new Bier {BierNr=5,Biernaam="hertog jan grand prestige",Alcohol=10.0f,Brouwer =hertogJan }
            };
            brouwer inbev = new brouwer { BrowerNr = 3, Brouwernaam = "inbev", Belgisch = true };
            inbev.Bieren = new List<Bier>
            {
                new Bier {BierNr=6,Biernaam="Belle-vue kriek L.A",Alcohol=1.2f,Brouwer=inbev },
                new Bier {BierNr=7,Biernaam="belle-vue kriek",Alcohol=5.2f,Brouwer=inbev },
                new Bier {BierNr=8,Biernaam="leffe radieuse",Alcohol=8.2f,Brouwer=inbev },
                new Bier {BierNr=9,Biernaam="leffe triple",Alcohol=8.5f,Brouwer=inbev }
            };
            return new List<brouwer> { palm, hertogJan, inbev };
        }
    }
}

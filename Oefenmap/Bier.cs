using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefenmap
{
    class Bier
    {
        public int BierNr { get; set; }
        public string Biernaam { get; set; }
        public float Alcohol { get; set; }
        public brouwer Brouwer { get; set; }
        public override string ToString()
        {
            return Biernaam+": "+Alcohol +"% alcohol";
        }


    }

}

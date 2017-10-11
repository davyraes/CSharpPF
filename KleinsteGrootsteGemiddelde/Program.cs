using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleinsteGrootsteGemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            //kleinste,grootste en gemiddelde
            int kleinste, grootste, invoer, aantal, som;
            kleinste = int.MaxValue;
            grootste = 0;
            aantal = 1;
            som = 0;
            Console.WriteLine("geef een getal. -1 om te stoppen.");
            invoer = int.Parse(Console.ReadLine());
            while (invoer != -1)
            {

                if (invoer < kleinste)
                    kleinste = invoer;
                if (invoer > grootste)
                    grootste = invoer;

                som += invoer;
                Console.WriteLine("geef een getal. -1 om te stoppen.");
                invoer = int.Parse(Console.ReadLine());
                aantal++;
            }
            Console.WriteLine($"de kleinste ={kleinste} de grootste ={grootste} het gemiddelde  ={som / aantal:0.00}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeerprogramma
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] code ={'Q','S','P','A','T','V','X','B','C','R','J','Y','E','D','U','O','H','Z','G','I','F','L','N','W','K','M'};
            Console.Write("Geef de zin die je wil coderen : ");
            string zin = (Console.ReadLine()).ToUpper();
            string codezin = string.Empty;
            for (int i=0;i<zin.Length;i++)
            {
                if (zin[i] >= 65 && zin[i] <= 90)
                    codezin += (code[zin[i] - 65]);
                else
                    codezin += (zin[i]);
            }
            Console.WriteLine("De gecodeerde zin is : {0}",codezin);
        }
    }
}

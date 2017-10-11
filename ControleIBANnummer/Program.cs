using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleIBANnummer
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = string.Empty;
            Console.Write("geef een IBANnummer om te controleren : ");
            string ibanString = Console.ReadLine();
            while (ibanString.Length != 19)
            {
                Console.Write("geef een IBANnummer om te controleren : ");
                ibanString = Console.ReadLine();
            }
                    
            for(int i=0;i<ibanString.Length;)
                if (ibanString[i] == ' ')
                    ibanString = ibanString.Remove(i, 1);
                else
                    i++;
            
            temp = ibanString.Substring(0, 4);
            ibanString = ibanString.Substring(4) + temp;
      
            for (int i = 0; i < ibanString.Length; i++)
                if (ibanString[i] > 64 && ibanString[i] < 91)
                {
                    temp = (ibanString[i] - 55).ToString();
                    ibanString = ibanString.Remove(i, 1);
                    ibanString = ibanString.Insert(i, temp);
                }
            if (long.Parse(ibanString) % 97 == 1)
                Console.WriteLine("Dit is een geldig IBANnummer.");
            else
                Console.WriteLine("Dit is geen geldig IBANnummer.");

        }
    }
}

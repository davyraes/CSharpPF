using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANRekeningnummerGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //IBAN rekeningnummer generator
            Console.Write("geef het rekeningnummer fff-fffffff-ff:");
            string rkngNr = Console.ReadLine();
            string rknNr = rkngNr;
            string ctrlString = string.Empty;
            long getal,controle;
            while (rknNr.Length!=14 && rknNr[3]!='-'&&rknNr[11]!='-')
            {
                Console.WriteLine("verkeerde ingave");
                Console.Write("geef het rekeningnummer fff-fffffff-ff:");
                rkngNr = Console.ReadLine();
            }
            for (int i = 0; i < rknNr.Length;)
                if (rknNr[i] == '-')
                    rknNr = rknNr.Remove(i, 1);
                else
                    i++;
            rknNr += "BE00";
            for (int i = 0; i < rknNr.Length; i++)
                if (rknNr[i] < '0' || rknNr[i] > '9')
                {
                    getal = rknNr[i] - 55;
                    rknNr = rknNr.Remove(i, 1);
                    rknNr = rknNr.Insert(i, getal.ToString());
                }
            controle = 98 - (long.Parse(rknNr) % 97);
            if (controle < 10)
                ctrlString = '0' + controle.ToString();
            else
                ctrlString = controle.ToString();
            rknNr = "BE" + ctrlString + rkngNr;
            rknNr = rknNr.Remove(7, 1);
            rknNr = rknNr.Remove(14, 1);
            for (int i = 4; i < rknNr.Length; i += 5)
                rknNr = rknNr.Insert(i, " ");
            Console.WriteLine(rknNr);
        }
    }
}

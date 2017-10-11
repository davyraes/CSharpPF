using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priemgetal
{
    class Program
    {
        static void Main(string[] args)
        {
            //priemgetal
            Console.Write("geef een getal :");
            int getal = int.Parse(Console.ReadLine());
            bool priemgetal = true;
            string delers = string.Empty;
            for (int i = 1; i <= getal; i++)
            {
                if (getal % i == 0)
                {
                    if (i == 1 || i == getal)
                    {

                    }
                    else
                        priemgetal = false;
                    delers += i.ToString() + ',';
                }
            }
            if (priemgetal)
                Console.WriteLine("dit is een priemgetal");
            else
                Console.WriteLine($"dit is geen priemgetal. deelbaar door {delers}");


        }
    }
}

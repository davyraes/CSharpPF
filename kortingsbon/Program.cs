using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kortingsbon
{
    class Program
    {
        static void Main(string[] args)
        {
            //koritngsbon
            Console.Write("geef het bedrag van de aankoop :");
            decimal aankoopBedrag = decimal.Parse(Console.ReadLine());
            decimal korting;
            if (aankoopBedrag >= 100)
                korting = aankoopBedrag * 5 / 100;
            else if (aankoopBedrag >= 75)
                korting = aankoopBedrag * 3 / 100;
            else if (aankoopBedrag >= 50)
                korting = aankoopBedrag * 2 / 100;
            else if (aankoopBedrag >= 25)
                korting = aankoopBedrag * 1 / 100;
            else
                korting = 0;
            Console.WriteLine($"de korting bedraagt :{korting}");
        }
    }
}

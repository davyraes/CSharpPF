using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //schrikkeljaar
            Console.Write("geef het jaartal in :");
            int jaartal = int.Parse(Console.ReadLine());
            if ((jaartal % 4 == 0 && jaartal % 100 != 0) || jaartal % 400 == 0)
                Console.WriteLine("dit is een schrikkeljaar");
            else
                Console.WriteLine("dit is geen schrikkeljaar");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lichtkrant
{
    class Program
    {
        static void Main(string[] args)
        {
            //lichtkrant
            Console.WriteLine("geef een datum in (dd/mm/jjjj):");
            string invoer = Console.ReadLine();
            string openingsuren, boodschap;
            DateTime datum = new DateTime(int.Parse(invoer.Substring(6, 4)), int.Parse(invoer.Substring(3, 2)), int.Parse(invoer.Substring(0, 2)));
            switch ((int)datum.DayOfWeek)
            {
                case 0:
                    openingsuren = "gesloten.";
                    boodschap = "We wensen u een prettig weekend!";
                    break;
                case 6:
                    openingsuren = "10u00 tot 12u00.";
                    boodschap = "We wensen u een prettig weekend!";
                    break;
                default:
                    openingsuren = "9u00 tot 12u00 en van 13u00 tot 18u00";
                    boodschap = "We wensen u een prettige werkdag!";
                    break;

            }
            Console.WriteLine(openingsuren + boodschap);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Parašykite programą, kuri išvestų žodį “Labas” ir  jūsų vardą toje pačioje eilutėje.
             */

            var vardas = "Ieva";

            Console.WriteLine("Labas, " + vardas);

            // arba:
            Console.WriteLine("Labas, {0}", vardas);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_00_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "HJhsdghdb";
            var pavarde = "hshd";
            var amzius = 54;

            Console.WriteLine("Labas");
            Console.WriteLine("Krabas");

            Console.WriteLine(vardas);
            Console.WriteLine(pavarde);
            Console.WriteLine(amzius);

            // parasot cw ir tada du kartus spausti tab

            Console.WriteLine("Vardas: " + vardas);
            Console.WriteLine("Pavarde: " + pavarde);
            Console.WriteLine("Amzius: " + amzius);

            Console.WriteLine("Vardas: {0}", vardas);
            Console.WriteLine("Pavarde: {0}", pavarde);
            Console.WriteLine("Amzius: {0}", amzius);

            Console.WriteLine("Vardas ir pavarde: " + vardas + " " + pavarde);
            Console.WriteLine("Vardas ir pavarde: {0} {1}", vardas, pavarde);

            Console.WriteLine(vardas + " " + pavarde + " (" + amzius + " m.)");
            Console.WriteLine("{0} {1} ({2} m.)", vardas, pavarde, amzius);
        }
    }
}

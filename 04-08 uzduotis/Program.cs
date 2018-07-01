using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 Liepkite įvesti tris skaičius. Išveskite įvestus
                 skaičius, jų kvadratus, juos pakeltus trečiuoju
                 laipsniu, tą skaičių padalintą iš dviejų.
             */

            Console.WriteLine("Iveskite tris skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1} {2} {3}", pirmas, pirmas * pirmas, Math.Pow(pirmas, 3), (double)pirmas / 2);
            Console.WriteLine("{0} {1} {2} {3}", antras, antras * antras, Math.Pow(antras, 3), (double)antras / 2);
            Console.WriteLine("{0} {1} {2} {3}", trecias, trecias * trecias, Math.Pow(trecias, 3), (double)trecias / 2);
        }
    }
}

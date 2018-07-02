using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite įvesti trijų egzaminų rezultatus. Suraskite
                pažymių vidurkį. Atlikite šiuos patikrinimus:
                - ar gautas vidurkis yra [8-10];
                - ar gautas vidurkis yra [5-8);
                - ar gautas vidurkis yra < 5.
             */

            Console.WriteLine("Iveskite triju egzaminu rezultatus");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());

            var vidurkis = (double) (pirmas + antras + trecias) / 3;

            if (vidurkis >= 8 && vidurkis <= 10)
            {
                Console.WriteLine("gautas vidurkis yra [8-10]");
            }
            else if (vidurkis >= 5 && vidurkis < 8)
            {
                Console.WriteLine("gautas vidurkis yra [5-8)");
            }
            else if (vidurkis < 5)
            {
                Console.WriteLine("gautas vidurkis yra < 5");
            }
        }
    }
}

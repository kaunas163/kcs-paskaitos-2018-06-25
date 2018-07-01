using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti penkis savo pažymius,
                raskite šių pažymių vidurkį, patikrinkite
                ar vidurkis yra lygus arba didesnis už 5.
            */

            Console.WriteLine("Iveskite 5 savo pazymius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            var ketvirtas = Convert.ToInt32(Console.ReadLine());
            var penktas = Convert.ToInt32(Console.ReadLine());

            var vidurkis = (double) (pirmas + antras + trecias + ketvirtas + penktas) / 5;

            if (vidurkis >= 5)
            {
                Console.WriteLine("Jusu vidurkis teigiamas");
            }
        }
    }
}

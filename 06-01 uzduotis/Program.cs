using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti tris skaičius, parašyti
                šią patikrinimo sąlygą, naudojant else if dalis:
                - ar pirmas skaičius didesnis už antrą;
                - ar antras skaičius didesnis už trečią;
                - ar trečias skaičius didesnis už pirmą;
                - ar pirmi du skaičiai lygūs;
             */

            Console.WriteLine("Iveskite tris skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());

            if (pirmas > antras)
            {
                Console.WriteLine("pirmas didesnis uz antra");
            }
            else if (antras > trecias)
            {
                Console.WriteLine("antras didesnis uz trecia");
            }
            else if (trecias > pirmas)
            {
                Console.WriteLine("trecias didesnis uz pirma");
            }
            else if (pirmas == antras)
            {
                Console.WriteLine("pirmi du skaiciai lygus");
            }
        }
    }
}

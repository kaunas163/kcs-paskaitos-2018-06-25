using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti du skaičius. Raskite
                kuris skaičius yra didesnis. Su viena if
                sąlyga (bei visomis jos dalimis) atlikite šiuos patikrinimus:
                - ar pirmas skaičius didesnis už antrą skaičių;
                - ar antras skaičius didesnis už pirmą;
                - jei niekas neatitinka - tuomet skaičiai lygūs.
             */

            Console.WriteLine("Iveskite du skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            if (pirmas > antras)
            {
                Console.WriteLine("pirmas didesnis");
            }
            else if (antras > pirmas)
            {
                Console.WriteLine("antras didesnis");
            }
            else
            {
                Console.WriteLine("skaiciai lygus");
            }
        }
    }
}

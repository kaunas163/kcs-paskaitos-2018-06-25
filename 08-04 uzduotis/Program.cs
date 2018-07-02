using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
                - ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
                - ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
                - ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
                - ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100;
             */

            Console.WriteLine("Iveskite du skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            if (pirmas > antras || pirmas == 0)
            {
                Console.WriteLine("pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0");
            }

            if (antras > pirmas || antras == 5)
            {
                Console.WriteLine("antras skaičius yra didesnis už pirmąjį, arba yra lygus 5");
            }

            if (pirmas > antras && pirmas == 20)
            {
                Console.WriteLine("pirmas skaičius yra didesnis už antrąjį ir yra lygus 20");
            }

            if (antras > pirmas && antras < 100)
            {
                Console.WriteLine("antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100");
            }
        }
    }
}

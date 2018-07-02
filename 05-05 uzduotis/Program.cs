using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite įvesti skaičių.
                - Jei skaičius dalinasi iš 5, tuomet išveskite
                  šio skaičiaus daugybos lentelę nuo 1 iki 5.
                - Jei skaičius lyginis, tuomet išveskite šį
                  skaičių, bei jo penktą laipsnį.
                - Jei skaičius nesidalina iš 4, tuomet liepkite
                  įveskite antrąjį skaičių. Išveskite abiejų skaičių
                  sumą ir sandaugą.
             */

            Console.WriteLine("Iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            // ar skaičius dalinasi iš 5?

            if (skaicius % 5 == 0)
            {
                Console.WriteLine("{0} * 1 = {1}", skaicius, skaicius * 1);
                Console.WriteLine("{0} * 2 = {1}", skaicius, skaicius * 2);
                Console.WriteLine("{0} * 3 = {1}", skaicius, skaicius * 3);
                Console.WriteLine("{0} * 4 = {1}", skaicius, skaicius * 4);
                Console.WriteLine("{0} * 5 = {1}", skaicius, skaicius * 5);
            }

            // ar skaičius lyginis?

            if (skaicius % 2 == 0)
            {
                Console.WriteLine("skaiciaus {0} penktas laipsnis {1}", skaicius, Math.Pow(skaicius, 5));
            }

            // ar skaičius nesidalina iš 4?

            if (skaicius % 4 != 0)
            {
                Console.WriteLine("Iveskite skaiciu");
                var antras = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}", skaicius, antras, skaicius + antras);
                Console.WriteLine("{0} * {1} = {2}", skaicius, antras, skaicius * antras);
            }
        }
    }
}

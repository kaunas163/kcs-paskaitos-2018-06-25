using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti bet kokį teigiamą
                skaičių. Parašykite šias atskiras if sąlygas:
                - patikrinti ar skaičius neigiamas, jei taip - aprėkti vartotoją :)
                - patikrinti ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
                - patikrinti ar skaičius lyginis;
                - patikrinti ar skaičius dalinasi iš 4;
                - patikrinti ar skaičius yra didesnis nei 10.
             */

            Console.WriteLine("Iveskite bet koki teigiama skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            // ar skaičius neigiamas, jei taip - aprėkti vartotoją :)

            if (skaicius < 0)
            {
                Console.WriteLine("REIKEJO IVESTI TEIGIAMA SKAICIU");
                Console.WriteLine("SKAITYK KAS RASOMA!!!");
            }

            // ar skaičius teigiamas, jei taip - pasveikinti vartotoją

            if (skaicius > 0)
            {
                Console.WriteLine("mldc :)");
            }

            // ar skaičius lyginis

            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Skaicius lyginis");
            }

            // ar skaičius dalinasi iš 4

            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }

            // ar skaičius yra didesnis nei 10

            if (skaicius > 10)
            {
                Console.WriteLine("Skaicius didesnis uz 10");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti vieną norimą skaičių. Su
                viena if sąlyga (ir visomis jos dalimis),
                patikrinkite šiuos dalykus:
                - ar skaičius neigiamas;
                - ar skaičius teigiamas;
                - ar skaičius lygus 0.
             */

            Console.WriteLine("Iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius < 0)
            {
                Console.WriteLine("skaicius neigiamas");
            }
            else if (skaicius > 0)
            {
                Console.WriteLine("skaicius teigiamas");
            }
            else
            {
                Console.WriteLine("skaicius lygus 0");
            }
        }
    }
}

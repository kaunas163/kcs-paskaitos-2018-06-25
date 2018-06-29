using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti bet kokį skaičių.
                Išveskite į ekraną šio skaičiaus kvadratą.
             */

            Console.WriteLine("Iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            // 1 būdas

            Console.WriteLine(skaicius * skaicius);

            // 2 būdas

            Console.WriteLine(Math.Pow(skaicius, 2));
        }
    }
}

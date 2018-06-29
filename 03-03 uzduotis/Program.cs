using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Išveskite į ekraną trijų skaičių sandaugą.
             */

            var skaicius1 = 4;
            var skaicius2 = 8;
            var skaicius3 = 3;

            // 1 būdas

            Console.WriteLine(skaicius1 * skaicius2 * skaicius3);

            // 2 būdas

            Console.WriteLine("{0} * {1} * {2} = {3}", skaicius1, skaicius2, skaicius3, skaicius1 * skaicius2 * skaicius3);

            // 3 būdas

            var sandauga = skaicius1 * skaicius2 * skaicius3;
            Console.WriteLine("{0} * {1} * {2} = {3}", skaicius1, skaicius2, skaicius3, sandauga);
        }
    }
}

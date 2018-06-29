using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir
                dalmenį, kiekvieną kartą nurodant atliekamą veiksmą ir šių
                skaičių reikšmes. Pvz.:
                4 + 5 = 9
                4 - 5 = -1
                …
             */

            var skaicius1 = 7;
            var skaicius2 = 5;

            // 1 būdas (iškeliant atsakymus į atskirus kintamuosius)

            var suma = skaicius1 + skaicius2;
            var skirtumas = skaicius1 - skaicius2;
            var sandauga = skaicius1 * skaicius2;
            var dalmuo = (double) skaicius1 / skaicius2;

            Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, suma);
            Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, sandauga);
            Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, dalmuo);

            // 2 būdas (arba skaičiavimai iškart išvedime)

            Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, skaicius1 + skaicius2);
            Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skaicius1 - skaicius2);
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, skaicius1 * skaicius2);
            Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, (double)skaicius1 / skaicius2);
        }
    }
}

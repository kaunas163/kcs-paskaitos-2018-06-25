using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Išveskite pasirinkto skaičiaus daugybos lentelę. Pvz.:
                5 * 0 = 0
                5 * 1 = 5
                …
                5 * 10 = 50
             */

            // 1 būdas

            var skaicius = 5;

            Console.WriteLine("{0} * {1} = {2}", skaicius, 1, skaicius * 1);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 2, skaicius * 2);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 3, skaicius * 3);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 4, skaicius * 4);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 5, skaicius * 5);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 6, skaicius * 6);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 7, skaicius * 7);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 8, skaicius * 8);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 9, skaicius * 9);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 10, skaicius * 10);

            // 2 būdas

            var skaicius2 = 5;
            var daugiklis = 1;

            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
        }
    }
}

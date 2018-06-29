using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5. Pvz.:
                2 * 1 = 2
                …
                2 * 5 = 10
             */

            Console.WriteLine("Iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            // 1 būdas

            Console.WriteLine("{0} * {1} = {2}", skaicius, 1, skaicius * 1);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 2, skaicius * 2);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 3, skaicius * 3);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 4, skaicius * 4);
            Console.WriteLine("{0} * {1} = {2}", skaicius, 5, skaicius * 5);

            // 2 būdas

            var daugiklis = 1;

            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
        }
    }
}

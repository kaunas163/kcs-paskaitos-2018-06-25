using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_00_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var hhsdbh = 45 + 44;
            var shgbh = hhsdbh + 8484;
            var hsgbhd = 8 + 9 + 2 + 8;
            var afgsyd = hsgbhd * 6 + hhsdbh;

            Console.WriteLine(hhsdbh);
            Console.WriteLine(545 + 86);
            Console.WriteLine((58 + 5) * 3);
            Console.WriteLine("{0} + {1} = {2}", 1, 3, 1 + 3);

            var aaa = 5;
            aaa++; // 6
            aaa++; // 7
            aaa--; // 6

            aaa = aaa + 10; // 16
            aaa = aaa - 6; // 10

            aaa += 10; // 20
            aaa -= 5; // 15
            aaa *= 2; // 30
            aaa /= 2; // 15
            aaa += 2; // 17

            //var aaa = 8;
            aaa = 8; // 8

            var bbb = 1;
            Console.WriteLine(bbb++); // 1
            // bbb = 2
            Console.WriteLine(bbb++); // 2
            // 3
            Console.WriteLine(bbb--); // 3
            // 2
            Console.WriteLine(++bbb); // 3
            // 3
            Console.WriteLine(bbb--); // 3
            // 2
            Console.WriteLine(--bbb); // 1
            // 1
            Console.WriteLine(bbb++); // 1
            // 2

            Console.WriteLine(2 * 2 * 2);
            Console.WriteLine(Math.Pow(2, 3)); //skaicius, laipsnis
        }
    }
}

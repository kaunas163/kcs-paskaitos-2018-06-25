using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Išveskite į ekraną pasirinką skaičių, jo kvadratą
                ir jį pakeltą trečiuoju laipsniu.
             */

            var skaicius = 2;

            Console.WriteLine(skaicius);
            Console.WriteLine(skaicius * skaicius);
            
            // 1 būdas

            Console.WriteLine(skaicius * skaicius * skaicius);

            // 2 būdas

            Console.WriteLine(Math.Pow(skaicius, 3));
        }
    }
}

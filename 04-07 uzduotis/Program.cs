using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Parašykite programą, kuri laipsnius paverstų į kelvinus ir fahrenheitus.
             */

            Console.WriteLine("Iveskite laipsnius");
            var laipsniai = Convert.ToInt32(Console.ReadLine());
            var kelvinai = laipsniai + 273.15;
            var fahrenheitai = (double)laipsniai * 9 / 5 + 32;
            Console.WriteLine("{0} laipsniu yra {1} kelvinais", laipsniai, kelvinai);
            Console.WriteLine("{0} laipsniu yra {1} fahrenheitais", laipsniai, fahrenheitai);
        }
    }
}

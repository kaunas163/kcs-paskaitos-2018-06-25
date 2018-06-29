using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti bet kokį simbolį.
                Atspausdinkite 3x3 kvadratą iš to simbolio.
             */

            Console.WriteLine("Iveskite simboli");
            var simbolis = Convert.ToChar(Console.Read());
            Console.ReadLine();

            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
        }
    }
}

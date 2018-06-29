using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti savo vardą ir amžių. Į ekraną išveskite:
                “Jūsų vardas {vardas},  o amžius {amžius}.”
             */

            Console.Write("Iveskite varda: ");
            var vardas = Console.ReadLine();
            Console.Write("Iveskite amziu: ");
            var amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusu vardas {0}, o amzius {1}", vardas, amzius);
        }
    }
}

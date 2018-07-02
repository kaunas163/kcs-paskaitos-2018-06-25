using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti šios dienos oro
                temperatūrą, atlikite šiuos patikrinimus:
                - ar temperatūra < 0 - išvesti “žiauriai šalta”;
                - ar temperatūra < 10 - išvesti “labai šalta”;
                - ar temperatūra < 20 - išvesti “šalta”;
                - ar temperatūra < 30 - išvesti “normali temperatūra”;
                - ar temperatūra < 40 - išvesti “karšta”;
                - ar temperatūra >= 40 - išvesti “visiškai degina”;
             */

            Console.WriteLine("Iveskite sios dienos temperatura");
            var temperatura = Convert.ToInt32(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.WriteLine("ziauriai salta");
            }
            else if (temperatura < 10)
            {
                Console.WriteLine("labai salta");
            }
            else if (temperatura < 20)
            {
                Console.WriteLine("salta");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("normali temperatura");
            }
            else if (temperatura < 40)
            {
                Console.WriteLine("karsta");
            }
            else if (temperatura >= 40)
            {
                Console.WriteLine("visiskai degina");
            }
        }
    }
}

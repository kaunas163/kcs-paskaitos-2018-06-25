using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti gautą pažymį, atlikite šiuos veiksmus:
                - jei 10 - išveskite “Puikiai”;
                - jei 8-9 - išveskite “Labai gerai”;
                - jei 5-7 - išveskite “Patenkinamai”;
                - jei 3-4 - išveskite “Prastai”;
                - jei 1-2 - išveskite “Labai blogai”;
             */

            Console.WriteLine("Iveskite pazymi");
            var pazymys = Convert.ToInt32(Console.ReadLine());

            if (pazymys == 10)
            {
                Console.WriteLine("puikiai");
            }
            else if (pazymys >= 8)
            {
                Console.WriteLine("labai gerai");
            }
            else if (pazymys >= 5)
            {
                Console.WriteLine("patenkinamai");
            }
            else if (pazymys >= 3)
            {
                Console.WriteLine("prastai");
            }
            else if (pazymys >= 1)
            {
                Console.WriteLine("labai blogai");
            }
        }
    }
}

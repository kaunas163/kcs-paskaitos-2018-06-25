using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti egzamino rezultatą [0-100],
                su viena sąlyga, per atskiras else if dalis,
                patikrinti šias ribas:
                - ar gautas rezultatas yra lygus 100;
                - ar gautas rezultatas yra lygus arba didesnis nei 80;
                - ar gautas rezultatas yra lygus arba didesnis nei 50;
                - ar gautas rezultatas yra lygus arba didesnis nei 20;
                - ar gautas rezultatas yra mažesnis nei 20;
             */

            Console.WriteLine("Iveskite egzamino rezultata [0-100]");
            var rezultatas = Convert.ToInt32(Console.ReadLine());

            if (rezultatas == 100)
            {
                Console.WriteLine("Rezultatas puikus - 100");
            }
            else if (rezultatas >= 80)
            {
                Console.WriteLine("Rezultatas [80-100)");
            }
            else if (rezultatas >= 50)
            {
                Console.WriteLine("Rezultatas [50-80)");
            }
            else if (rezultatas >= 20)
            {
                Console.WriteLine("Rezultatas [20-50)");
            }
            else if (rezultatas < 20)
            {
                Console.WriteLine("Rezultatas [0-20)");
            }
        }
    }
}

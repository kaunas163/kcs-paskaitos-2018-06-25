using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti gyvūno rūšį. Su switch patikrinkite:
                - ar įvestas gyvūnas yra šuo;
                - ar įvestas gyvūnas yra katė;
                - ar įvestas gyvūnas yra žiurkėnas;
                - ar įvestas gyvūnas yra triušis;
                - ar įvestas gyvūnas yra papūga.
             */

            Console.WriteLine("Iveskite gyvuno rusi");
            var gyvunas = Console.ReadLine();

            switch (gyvunas)
            {
                case "suo":
                    Console.WriteLine("pasirinktas suo");
                    break;
                case "kate":
                    Console.WriteLine("pasirinkta kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("pasirinktas ziurkenas");
                    break;
                case "triusis":
                    Console.WriteLine("pasirinktas triusis");
                    break;
                case "papuga":
                    Console.WriteLine("pasirinkta papuga");
                    break;
            }
        }
    }
}

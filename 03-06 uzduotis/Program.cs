using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus
                reikšme. Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.
             */

            var skaicius = 45;

            var pirmas = skaicius / 10;
            var antras = skaicius % 10;

            var sandauga = pirmas * antras;

            Console.WriteLine(sandauga);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus
                toje pačioje eilutėje su tarpais tarp šių skaičių (skaičius - 25,
                rezultatas - 25 25 25 25 25).
             */

            var skaicius = 25;

            // 1 būdas:

            Console.Write(skaicius + " ");
            Console.Write(skaicius + " ");
            Console.Write(skaicius + " ");
            Console.Write(skaicius + " ");
            Console.WriteLine(skaicius);

            // 2 būdas:

            Console.WriteLine(skaicius + " " + skaicius + " " + skaicius + " " + skaicius + " " + skaicius);

            // 3 būdas:

            Console.WriteLine("{0} {0} {0} {0} {0}", skaicius);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_00_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i < 20; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 50; i += 5)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 1; i <= 25; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();

            //for (;;)
            //{
            //    Console.Write("labas ");
            //}

            var suma = 0;

            for (int i = 0; i < 100; i++)
            {
                suma += i;
            }

            Console.WriteLine("suma: " + suma);

            var sandauga = 1;

            for (int i = 1; i <= 10; i++)
            {
                sandauga *= i;
            }

            Console.WriteLine("sandauga: " + sandauga);

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + " ");
                }

                Console.WriteLine();
            }

            /*
                i	j

                1	1	1
                1	2	2
                1	3	3
                1	4	4
                1	5	5

                2	1
                2	2
                2	3
                2	4
                2	5

                3	1
                3	2
                3	3
                3   ...
                ....
             */

            var lyginiuSuma = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    lyginiuSuma += i;
                    //lyginiuSuma = lyginiuSuma + i;
                }
            }

            Console.WriteLine("lyginiu suma: " + lyginiuSuma);

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);

                if (i % 3 == 0)
                {
                    break; // iseiti is ciklo / nutraukti cikla
                }
            }

            Console.WriteLine();

            // [2-10)

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // 2, 4, 6, 8, 10

            for (int i = 2; i <= 10; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite įvesti tris skaičius. Suraskite
                kuris iš šių skaičių yra mažiausias.
             */

            Console.WriteLine("Iveskite tris skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());

            if (pirmas < antras && pirmas < trecias)
            {
                Console.WriteLine("pirmas maziausias");
            }
            else if (antras < pirmas && antras < trecias)
            {
                Console.WriteLine("antras maziausias");
            }
            else if (trecias < pirmas && trecias < antras)
            {
                Console.WriteLine("trecias maziausias");
            }
            else
            {
                Console.WriteLine("skaiciai lygus");
            }
        }
    }
}

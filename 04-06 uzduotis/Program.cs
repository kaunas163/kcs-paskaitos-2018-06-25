using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti tris skaičius. Į ekraną
                išveskite šiuos skaičius ir jų vidurkį. Pvz.:
                Įvestų skaičių 4, 5, 8 vidurkis: 5,6.
             */

            Console.WriteLine("Iveskite tris skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (double) (pirmas + antras + trecias) / 3;
            Console.WriteLine("Ivestu skaiciu {0}, {1}, {2} vidurkis {3}", pirmas, antras, trecias, vidurkis);
        }
    }
}

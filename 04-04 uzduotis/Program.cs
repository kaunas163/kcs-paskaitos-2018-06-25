using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti tris skaičius. Išveskite visų
                šių skaičių sumą, skirtumą, sandaugą ir dalmenį, nurodant
                atliekamus veiksmus ir šių skaičių reikšmes ekrane. Pvz.:
                5 + 3 + 8 = 16
                5 - 3 - 8 = -6
                ...
             */

            Console.WriteLine("Iveskite tris skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());

            var suma = pirmas + antras + trecias;
            var skirtumas = pirmas - antras - trecias;
            var sandauga = pirmas * antras * trecias;
            var dalmuo = (double) pirmas / antras / trecias;

            Console.WriteLine("{0} + {1} + {2} = {3}", pirmas, antras, trecias, suma);
            Console.WriteLine("{0} - {1} - {2} = {3}", pirmas, antras, trecias, skirtumas);
            Console.WriteLine("{0} * {1} * {2} = {3}", pirmas, antras, trecias, sandauga);
            Console.WriteLine("{0} / {1} / {2} = {3}", pirmas, antras, trecias, dalmuo);
        }
    }
}

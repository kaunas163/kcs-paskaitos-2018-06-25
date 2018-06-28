using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite į ekraną tekstą su
                šiuo amžiumi: “Įvestas amžius: {amžius}”. Tarp {} nurodytas kintamasis,
                kurio reikšmė toje vietoje turi būti įstatyta.
             */

            var amzius = 20;

            Console.WriteLine("Ivestas amzius: " + amzius);

            // arba:
            Console.WriteLine("Ivestas amzius: {0}", amzius);
        }
    }
}

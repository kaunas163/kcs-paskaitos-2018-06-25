using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Susikurkite reikiamus kintamuosius užduočiai atlikti. Į ekraną išveskite:
                Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.
                Tarp {} nurodyti reikiami kintamieji, šiose vietose jų reikšmės turi būti įsistatytos.
             */

            var marke = "Tesla";
            var modelis = "Model S";
            var metai = 2018;
            var rida = 5000;

            // 1 būdas:

            Console.WriteLine("Automobilio " + marke + " " + modelis + " (" + metai + " m.) rida - " + rida + " km.");

            // 2 būdas:

            Console.WriteLine("Automobilio {0} {1} ({2} m.) rida - {3} km.", marke, modelis, metai, rida);
        }
    }
}

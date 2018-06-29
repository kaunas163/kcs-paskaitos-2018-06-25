using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_00_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jusu vardas?");
            var vardas = Console.ReadLine();

            Console.WriteLine("Jusu pavarde?");
            var pavarde = Console.ReadLine();

            Console.WriteLine("Ka vairuojate?");
            var auto = Console.ReadLine();

            Console.WriteLine("Megstamiausia spalva?");
            var spalva = Console.ReadLine();

            Console.WriteLine("Jusu amzius?");
            var amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusu ugis?");
            var ugisTekstas = Console.ReadLine();
            var ugis = Convert.ToInt32(ugisTekstas);

            Console.WriteLine("Gyvenamoji vieta????");
            var vieta = Console.ReadLine();

            Console.WriteLine("Korteles numeris? Greit tik");
            var kortelesNr = Console.ReadLine();

            Console.WriteLine("PIN kodas?");
            var pin = Convert.ToInt32(Console.ReadLine());

            // gimimo data
            // lyti

            Console.WriteLine("Jusu suvesti duomenys:");

            // patys sugalvokite isvedima, pvz:

            // {vardas} {pavarde} ({amzius} m.)
            // Jusu vairuojamas auto: ...
            // Jusu megstamiausia spalva: ...
            // Nebe jusu korteles duomenys: ...

            /*
             suvesti šią informaciją apie gyvūną to klausinėjant
             vartotojo:
             - vardas
             - kailio spalva
             - kilmė
             - rūšis
             - greitis
             šią informaciją išvesti po visų įvedimų kaip nors gražiai
             */

            Console.WriteLine("Gyvūno vardas?");
            var gyvunoVardas = Console.ReadLine();

            // ...

            /* liepti vartotojui suvesti 5 skaičius vieną po kito
             * išvesti į ekraną pirmą ir paskutinį skaičius
             * išvesti į ekraną antro, trečio ir ketvirto skaičių sumą
             */
        }
    }
}

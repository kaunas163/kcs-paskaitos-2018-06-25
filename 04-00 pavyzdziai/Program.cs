using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            Console.WriteLine("Gimimo data?");
            var gimimoData = Console.ReadLine();

            Console.WriteLine("Lytis?");
            var lytis = Console.ReadLine();

            Console.WriteLine("Jusu suvesti duomenys:");
            Console.WriteLine(vardas + " " + pavarde + " vairuoja " + auto);
            Console.WriteLine("Asmuo gimes " + gimimoData + ", jo amzius " + amzius + ", yra " + lytis + ", jo ugis " + ugis + " m.");
            Console.WriteLine("Siuo metu gyvena " + vieta);
            Console.WriteLine("Megstamiausia spalva " + spalva);
            Console.WriteLine("Korteles numeris " + kortelesNr + ", kurios pin kodas " + pin);

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

            Console.Write("Gyvūno vardas: ");
            var gyvunoVardas = Console.ReadLine();

            Console.Write("Kailio spalva: ");
            var kailis = Console.ReadLine();

            Console.Write("Kilme: ");
            var kilme = Console.ReadLine();

            Console.Write("Rusis: ");
            var rusis = Console.ReadLine();

            Console.Write("Greitis km/h: ");
            var greitis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GYVUNO DUOMENYS");
            Console.WriteLine("Vardas: " + gyvunoVardas);
            Console.WriteLine("Kailio spalva: " + kailis);
            Console.WriteLine("Kilme: " + kilme);
            Console.WriteLine("Rusis: " + rusis);
            Console.WriteLine("Greitis: " + greitis + " km/h");

            /* liepti vartotojui suvesti 5 skaičius vieną po kito
             * išvesti į ekraną pirmą ir paskutinį skaičius
             * išvesti į ekraną antro, trečio ir ketvirto skaičių sumą
             */

            Console.WriteLine("Suveskite 5 skaicius, po kiekvieno spausdami enter mygtuka");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            var ketvirtas = Convert.ToInt32(Console.ReadLine());
            var penktas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(pirmas + " " + penktas);
            Console.WriteLine(antras * trecias * ketvirtas);
        }
    }
}

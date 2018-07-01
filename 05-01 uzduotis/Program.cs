using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Liepkite vartotojui įvesti tris sveikuosius skaičius.
                Parašykite šias atskiras if sąlygas:
                - patikrinkite ar pirmas ir antras skaičiai yra lygūs;
                - patikrinkite ar antras ir trečias skaičiai yra lygūs;
                - patikrinkite ar pirmas skaičius yra didesnis už antrąjį;
                - patikrinkite ar antras skaičius yra didesnis už dvigubą
                  trečiojo skaičiaus reikšmę (trečias skaičius padaugintas iš dviejų);
                - patikrinkite ar pirmas skaičius yra lyginis (dalinti
                  per % iš 2 ir žiūrėti ar gautas atsakymas yra lygus nuliui);
                - patikrinkite ar antras skaičius yra nelyginis (dalinti
                  per % iš 2 ir žiūrėti ar gautas atsakymas nėra lygus nuliui);
                - patikrinkite ar trečias skaičius yra teigiamas (daugiau už 0);
                - patikrinkite ar trečias skaičius yra neigiamas (mažiau už 0).
             */

            Console.WriteLine("Iveskite tris skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());

            // ar pirmas ir antras skaičiai yra lygūs

            if (pirmas == antras)
            {
                Console.WriteLine("pirmas ir antras skaiciai yra lygus");
            }

            // ar antras ir trečias skaičiai yra lygūs

            if (antras == trecias)
            {
                Console.WriteLine("antras ir trecias skaiciai yra lygus");
            }

            // ar pirmas skaičius yra didesnis už antrąjį

            if (pirmas > antras)
            {
                Console.WriteLine("pirmas skaicius didesnis uz antraji");
            }

            // ar antras skaičius yra didesnis už dvigubą trečiojo
            // skaičiaus reikšmę (trečias skaičius padaugintas iš dviejų)

            if (antras > trecias * 2)
            {
                Console.WriteLine("antras skaicius yra didenis uz dviguba treciojo skaiciaus reiksme");
            }

            // ar pirmas skaičius yra lyginis (dalinti per % iš 2 ir
            // žiūrėti ar gautas atsakymas yra lygus nuliui)

            if (pirmas % 2 == 0)
            {
                Console.WriteLine("pirmas skaicius yra lyginis");
            }

            // ar antras skaičius yra nelyginis (dalinti per % iš 2 ir
            // žiūrėti ar gautas atsakymas nėra lygus nuliui)

            if (antras % 2 != 0)
            {
                Console.WriteLine("antras skaicius yra nelyginis");
            }

            // ar trečias skaičius yra teigiamas (daugiau už 0)

            if (trecias > 0)
            {
                Console.WriteLine("trecias skaicius yra teigiamas");
            }

            // ar trečias skaičius yra neigiamas (mažiau už 0)

            if (trecias < 0)
            {
                Console.WriteLine("trecias skaicius yra neigiamas");
            }
        }
    }
}

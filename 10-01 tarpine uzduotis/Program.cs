using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_01_tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Tikslas: Suskaičiuoti kiek duonos kepalų kepykla sugebės iškepti
                per dieną, ar spės įgyvendinti visus dienos užsakymus, suskaičiuoti
                kiek iš jų uždirbs pelno.

                Iš anksto žinoma informacija:
                - Darbo valandų per dieną 8 val.

                Vartotojo įvedama informacija:
                - Kiek darbuotojas gali iškepti kepalų per valandą.
                - Kiek darbuotojų turi kepykla.
                - Vieno kepalo savikaina.
                - Vieno kepalo pardavimo kaina.
                - Kiek kepykla turi tą dieną iškepti kepalų (užsakymai).

                Suskaičiuoti kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų.
                
                Apskaičiuoti visų kepalų savikainą, gautas pajamas pardavus ir iš to
                gauto pelno dalį.
                
                Patikrinti ar kepykla spės iškepti visus tos dienos užsakymus. Jei ne,
                suskaičiuoti kiek kepalų nespės iškepti.
             */

            var darboValandos = 8;

            Console.Write("Kiek darbuotojas gali iskepti kepalu per valanda: ");
            var darbuotojasKepaluPerValanda = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kiek darbuotoju turi kepykla: ");
            var darbuotojai = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vieno kepalo savikaina: ");
            var kepaloSavikaina = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vieno kepalo pardavimo kaina: ");
            var kepaloPardavimoKaina = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kepyklos dienos uzsakymai: ");
            var uzsakymai = Convert.ToInt32(Console.ReadLine());

            var kepaluPerDiena = darboValandos * darbuotojasKepaluPerValanda * darbuotojai;
            var visuKepaluSavikaina = kepaluPerDiena * kepaloSavikaina;
            var pajamos = kepaluPerDiena * kepaloPardavimoKaina;
            var pelnas = pajamos - visuKepaluSavikaina;

            Console.WriteLine();
            Console.WriteLine("Kepalu per diena: " + kepaluPerDiena);
            Console.WriteLine("Visu kepalu savikaina: " + visuKepaluSavikaina + " eur");
            Console.WriteLine("Pajamos: " + pajamos + " eur");
            Console.WriteLine("Pelnas: " + pelnas + " eur");

            if (uzsakymai < kepaluPerDiena)
            {
                Console.WriteLine("Kepykla spes igyvendinti visus uzsakymus.");
            }
            else
            {
                Console.WriteLine("Kepykla nespes igyvendinti {0} uzsakymu.", uzsakymai - kepaluPerDiena);
            }
        }
    }
}

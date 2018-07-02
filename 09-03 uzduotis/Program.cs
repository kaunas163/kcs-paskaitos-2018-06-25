using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Į ekraną išveskite kelis sunumeruotus pasirinkimus
                (pvz.: 1 - vanduo, 2 - kava, 3 - arbata…). Liepkite
                vartotojui įvesti pasirinkimo numerį. Pagal įvestą
                numerį išveskite atitinkamą tekstą (pvz.: jūs
                pasirinkote vandenį). Neradus tinkamo varianto
                išvesti, kad tokio pasirinkimo nėra.
             */

            Console.WriteLine("Pasirinkite:");
            Console.WriteLine("1 - vanduo");
            Console.WriteLine("2 - kava");
            Console.WriteLine("3 - arbata");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("jus pasirinkote vandeni");
                    break;
                case 2:
                    Console.WriteLine("jus pasirinkote kava");
                    break;
                case 3:
                    Console.WriteLine("jus pasirinkote arbata");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }
        }
    }
}

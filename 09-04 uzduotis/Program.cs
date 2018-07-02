using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Į ekraną išveskite kelis sunumeruotus pasirinkimus
                (pvz.: 1 - stacionarus kompiuteris, 2 - nešiojamas
                kompiuteris, 3 - planšetė...). Liepkite vartotojui
                įvesti pasirinkimo numerį. Pagal įvestą numerį išveskite
                atitinkamą tekstą (pvz.: nešiojamuoju kompiuteriu
                galite naudotis visur). Neradus tinkamo varianto
                išvesti, kad tokio pasirinkimo nėra.
             */

            Console.WriteLine("Pasirinkite:");
            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nesiojamas kompiuteris");
            Console.WriteLine("3 - plansete");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("pc master race");
                    break;
                case 2:
                    Console.WriteLine("jega, galite bet kur dirbti");
                    break;
                case 3:
                    Console.WriteLine("nu gal kam nors panaudojamas daiktas");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
                Išveskite į ekraną norimo dydžio tuščiavidurį kvadratą iš žvaigždučių.
                ****
                *  *
                *  *
                ****
                
             */

            // 1 būdas:

            Console.WriteLine("****");
            Console.WriteLine("*  *");
            Console.WriteLine("*  *");
            Console.WriteLine("****");

            // 2 būdas:

            var simbolis = '*';

            Console.WriteLine("{0}{0}{0}{0}", simbolis);
            Console.WriteLine("{0}  {0}", simbolis);
            Console.WriteLine("{0}  {0}", simbolis);
            Console.WriteLine("{0}{0}{0}{0}", simbolis);

            // 3 būdas:

            Console.WriteLine("{0}{0}{0}{0}\n{0}  {0}\n{0}  {0}\n{0}{0}{0}{0}", simbolis);
        }
    }
}

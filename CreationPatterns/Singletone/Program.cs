using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
           // var st = SingletoneClassic.GetInstanse();

            Console.WriteLine("Starting Main... ");
            if (args.Length == 1)
            {
                Console.WriteLine(SingletoneStatic.S);
            }
            Console.ReadKey();
        }
    }
}

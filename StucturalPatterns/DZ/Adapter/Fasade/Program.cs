using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade
{
    class Program
    {
        static void Main(string[] args)
        {
            FasadeMathOperation.Plus(5,10,10,10,123);
            FasadeMathOperation.Minus(123, 10, 123);
            FasadeMathOperation.Multiplication(10,5,12);
            FasadeMathOperation.Division(0,10,3);
            FasadeMathOperation.Sqrt(10);
            FasadeMathOperation.Factorial(6);

            Console.ReadKey();
        }
    }
}

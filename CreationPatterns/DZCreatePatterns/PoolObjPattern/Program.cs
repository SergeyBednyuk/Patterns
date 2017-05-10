using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolObjPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger big = new BigInteger(1);

            for (int i = 1; i < 1000; i++)
            {
                big *= i;
            }

            Console.WriteLine(big);

            Console.ReadKey();
        }
    }
}

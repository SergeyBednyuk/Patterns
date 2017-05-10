using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new Creator();
            for (int i = 0; i <= 12; i++)
            {
                var product = creator.GetProduct(i);
                Console.WriteLine(product);
            }
            

            Console.ReadKey();
        }
    }
}

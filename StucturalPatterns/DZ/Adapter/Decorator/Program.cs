using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct product = new Product() {Name = "Phone",Cost = 1000.0, VenderCode = 12345 };
            product.PrintInfo();

            IProduct strih = new ComponentShtrih(product) {Symbol = '#'};
            strih.PrintInfo();

            Console.ReadKey();
        }
    }
}

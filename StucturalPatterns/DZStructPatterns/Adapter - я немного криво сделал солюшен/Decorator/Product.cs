using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Product : IProduct
    {
        public double Cost { get; set; }
        public string Name { get; set; }
        public int VenderCode { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Product name : {0} Cost - {1} Vender code - {2}",Name,Cost,VenderCode);
        }
    }
}

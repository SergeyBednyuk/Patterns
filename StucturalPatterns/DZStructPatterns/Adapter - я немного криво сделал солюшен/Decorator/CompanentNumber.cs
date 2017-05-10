using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CompanentNumber:ProductDecorator
    {
        public char Symbol { get; set; }
        public CompanentNumber(IProduct product):base(product) { }

        public override void PrintInfo()
        {
            Console.WriteLine("Product name : {0} Cost - {1} Articl {2}{3}", Name, Cost, Symbol, VenderCode);
        }
    }
}

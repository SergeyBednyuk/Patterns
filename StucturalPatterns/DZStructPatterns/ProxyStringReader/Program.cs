using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyStringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxySR = new ProxyStringReader();
            proxySR.LoadText("12asd334235fgn345456");
            Console.WriteLine(proxySR.GetCollSymbol('1'));
            Console.WriteLine(proxySR);

            Console.ReadKey();
        }
    }
}

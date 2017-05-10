using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory gucciF = new GucciFactory();
            var gucciBag = gucciF.CreateBag();
            var gucciShouse = gucciF.CreateShouse();

            Console.WriteLine(gucciBag.Materil, gucciShouse.Price);

            IFactory gussiF = new GussiFactory();
            var gussiDag = gussiF.CreateBag();
            var gussiShouse = gussiF.CreateShouse();

            Console.WriteLine(gussiDag.Materil, gussiShouse.Price);

            Console.ReadKey();
        }
    }
}

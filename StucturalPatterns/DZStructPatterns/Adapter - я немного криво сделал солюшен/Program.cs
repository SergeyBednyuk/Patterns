using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IStringReader reader = new StringReader();

            reader.LoadText("112311143654bndg6357123435342346sdh1111hjd1");

            Console.WriteLine("Namber symbol - {0}",reader.GetCollSymbol('1'));

            Console.ReadKey();
        }
    }
}

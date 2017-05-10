using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PageBildet();

            var director = new PageDirector(builder);

            var page = director.BildPage(101);

            Console.WriteLine(page);

            Console.ReadKey();
        }
    }
}

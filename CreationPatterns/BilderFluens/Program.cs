using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilderFluens
{
    class Program
    {
        static void Main(string[] args)
        {
            var pageBilder = new PageBillder();

            var page = pageBilder.BuildHeader("Header")
                .BuildMenu("Menu")
                .BuldContent("Content")
                .BuilderFooter("Footer")
                .GetPage();

            Console.WriteLine(page);

            Console.ReadKey();
        }
    }
}

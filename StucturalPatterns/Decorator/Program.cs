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

            IComponent component = new Component() {Text = "Hello world!"};
            component.Print();
            Console.WriteLine();

            IComponent ident = new ComponentIdent(component) {Ident = 10};
            ident.Print();
            Console.WriteLine();

            IComponent brackets = new ComponentBrackets(component);
            brackets.Print();
            Console.WriteLine();

            IComponent brackets2 = new ComponentBrackets(ident);
            brackets2.Print();

            Console.Read();
        }
    }
}

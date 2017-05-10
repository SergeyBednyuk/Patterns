using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.SimpleExample
{
    public class Manager
    {
        private static readonly Dictionary<char, ILatter> Latters = new Dictionary<char, ILatter>();

        static Manager()
        {
            Latters.Add('A',new ClassA());
            Latters.Add('B', new ClassB());
        }

        public static ILatter Get(char c)
        {
            return Latters[c].Clone();
        }

    }
}

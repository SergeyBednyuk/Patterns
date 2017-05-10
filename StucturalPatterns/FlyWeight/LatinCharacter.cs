using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class LatinCharacter:Character
    {
        public char Symbol { get; set; }
        public override void Display(int position)
        {
            Console.WriteLine("{0} symbol. Position is {1}",Symbol,position);
        }
    }
}

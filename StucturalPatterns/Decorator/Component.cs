using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Component:IComponent
    {
        public string Text { get; set; }
        public void Print()
        {
            Console.Write("Component text = {0}",Text);
        }
    }
}

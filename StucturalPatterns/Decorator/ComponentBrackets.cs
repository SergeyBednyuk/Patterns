using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ComponentBrackets : ComponentDecorator
    {
        public ComponentBrackets(IComponent component) : base(component)
        {
        }

        public override void Print()
        {
            Console.Write("{");
            base.Print();
            Console.Write("}");
        }
    }
}



using System;

namespace Decorator
{
    class ComponentIdent : ComponentDecorator
    {
        public int Ident { get; set; }
        public ComponentIdent(IComponent component) : base(component)
        {
        }

        public override void Print()
        {
            Console.Write(new string(' ',Ident));
            base.Print();
            Console.WriteLine();
        }
    }
}


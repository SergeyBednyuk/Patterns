using System;

namespace FlyWeight
{
    class WhiteSpace:Character
    {
        public override void Display(int position)
        {
            Console.WriteLine("_, position is {0}",position);
        }
    }
}

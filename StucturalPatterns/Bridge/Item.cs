using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Item:ItemBase
    {
        public override void Get()
        {
            Console.WriteLine("Getting Item");
            base.Get();
            Console.WriteLine("Item is Got");
        }
    }
}

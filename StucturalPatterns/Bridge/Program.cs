using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Item();
            item.DataObject=new DataObject();
            item.Get();
            item.Next();
            item.Get();
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GussiFactory:IFactory
    {

        public IBag CreateBag()
        {
            return new GussiBag();
        }

        public IShouse CreateShouse()
        {
            return new GussiShoes();
        }
    }
}

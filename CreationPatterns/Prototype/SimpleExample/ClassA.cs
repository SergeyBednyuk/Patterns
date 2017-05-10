using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.SimpleExample
{
    public class ClassA:ILatter
    {
        public ILatter Clone()
        {
            return (ILatter) MemberwiseClone();
        }
    }
}

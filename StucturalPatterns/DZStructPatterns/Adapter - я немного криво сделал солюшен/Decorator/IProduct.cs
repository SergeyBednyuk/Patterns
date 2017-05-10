using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IProduct
    {
        string Name { get; set; }
        double Cost { get; set; }
        int VenderCode { get; set; }

        void PrintInfo();
    }
}

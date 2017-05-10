using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DefaultProduct:IProduct
    {
        public string ShipFrom()
        {
            return "Information Derfault Product";
        }
    }
}

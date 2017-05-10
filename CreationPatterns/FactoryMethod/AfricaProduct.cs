using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AfricaProduct:IProduct
    {
        public string ShipFrom()
        {
            return "Information Africa Product";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Creator
    {
        public IProduct GetProduct(int month)
        {
            if (month >= 4 && month <=11)
            {
                return  new PolandProduct();
            }
            if (month == 1 || month == 2 || month == 12)
            {
                return new AfricaProduct();
            }
            return  new DefaultProduct();
        }
    }
}

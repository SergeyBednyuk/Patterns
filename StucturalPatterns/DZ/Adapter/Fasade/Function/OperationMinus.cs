using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade.Function
{
    internal class OperationMinus
    {
        public double Minus(double first, params double[] nambers)
        {
            double result = first;
            foreach (var i in nambers)
            {
                result -= i;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade.Function
{
    internal class OperationDivision
    {
        public double Division(double first, params double[] nambers)
        {
            double result = first;
            if (result == 0)
            {
                throw new DivideByZeroException();
            }
            foreach (var i in nambers)
            {
                result /= i;
            }
            return result;
        }
    }
}

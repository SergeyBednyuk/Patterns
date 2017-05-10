using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class ExeptionsGenerator
    {
        public static void GetDivideByZeroException()
        {
            throw new DivideByZeroException();
        }
        public static ArgumentException GetArgumentException()
        {
            return new ArgumentException();
        }
        public static StackOverflowException GetStackOverflowException()
        {
            return new StackOverflowException();
        }
    }
}

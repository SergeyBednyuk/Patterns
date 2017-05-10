using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    public class ExeptionGenerator
    {
        public DivideByZeroException GetDivideByZeroExceptionExeption()
        {
            return new DivideByZeroException();           
        }
        public FormatException GetFormatExceptionExeption()
        {
            return new FormatException();
        }
    }
}

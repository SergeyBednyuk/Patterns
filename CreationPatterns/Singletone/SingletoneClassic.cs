using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class SingletoneClassic
    {
        private static SingletoneClassic _instnse;

        private SingletoneClassic()
        {
        }

        public static SingletoneClassic GetInstanse()
        {
            if (_instnse == null)
            {
                _instnse = new SingletoneClassic();
                return _instnse;
            }
            return _instnse;
        }
    }
}

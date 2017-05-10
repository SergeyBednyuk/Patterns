using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class SingletoneStatic
    {
        private static readonly SingletoneStatic _instnse = new SingletoneStatic();
        //private static readonly object _locker = new object();

        static SingletoneStatic()
        {
        }

        public static SingletoneStatic GetInstanse()
        {
           return _instnse;
        }
    }
}

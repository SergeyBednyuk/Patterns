using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class SingletoneLock
    {
        private static SingletoneLock _instnse;
        private static readonly object _locker = new object();

        private SingletoneLock()
        {
        }

        public static SingletoneLock GetInstanse()
        {
            lock (_locker)
            {
                if (_instnse == null)
                {
                    _instnse = new SingletoneLock();
                    return _instnse;
                }
                return _instnse;
            }
        }
    }
}

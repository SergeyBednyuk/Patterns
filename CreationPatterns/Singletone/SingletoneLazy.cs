using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class SingletoneLazy
    {
        private  static  readonly Lazy<SingletoneLazy> _lazy_instanse
            = new Lazy<SingletoneLazy>(() => new SingletoneLazy());

        private SingletoneLazy()
        {
        }

        public SingletoneLazy GetInstanse()
        {
            return _lazy_instanse.Value;
        }
    }
}

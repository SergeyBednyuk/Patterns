using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IIterator<T>
    {
        void Reset();
        void MoveNext();
        bool IsDone { get; }
        T Current { get;}
}
}

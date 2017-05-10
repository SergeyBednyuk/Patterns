using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class List : IContainer<int>
    {
        private readonly int[] _list;

        public List(params int[] data)
        {
            _list = new int[data.Length];
            data.CopyTo(_list, 0);
        }

        public IIterator<int> CreateIterator()
        {
            return new ForwardIterator(_list);
        }

        private class ForwardIterator : IIterator<int>
        {
            private readonly int[] _sourceList;
            private int _position;

            public ForwardIterator(int[] list)
            {
                _sourceList = new int[list.Length];
                list.CopyTo(_sourceList, 0);
            }

            public void Reset()
            {
                _position = 0;
            }

            public void MoveNext()
            {
                _position++;
            }

            public bool IsDone
            {
                get { return _position > _sourceList.Length - 1; }
            }

            public int Current
            {
                get { return _sourceList[_position]; }
            }
        }
    }
}

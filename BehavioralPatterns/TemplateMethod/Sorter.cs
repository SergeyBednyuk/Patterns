using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Sorter
    {
        private readonly int[] _data;

        protected Sorter(params int[] data)
        {
            _data = new int[data.Length];
            Array.Copy(data, _data, data.Length);
        }

        protected abstract bool Compare(int x, int y);

        public void Sort()
        {
            for (int i = 0; i < _data.Length - 1; i++)
            {
                for (int j = i + 1; j < _data.Length; j++)
                {
                    if (Compare(_data[i], _data[j]))
                    {
                        var temp = _data[i];
                        _data[i] = _data[j];
                        _data[j] = temp;
                    }
                }
            }
        }

        public int[] GetData()
        {
            var result = new int[_data.Length];
            Array.Copy(_data, result, _data.Length);
            return result;
        }

    }
}

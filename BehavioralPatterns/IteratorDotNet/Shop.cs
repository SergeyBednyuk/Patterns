using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorDotNet
{
    class Shop : IEnumerable<string>
    {
        private string[] _items = new string[0];

        public Shop(params string[] items)
        {
            Array.Resize(ref _items, _items.Length + items.Length);
            items.CopyTo(_items, 0);
        }

        public void AddItem(string item)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = item;
        }

        public string GetItem(int index)
        {
            return _items[index];
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

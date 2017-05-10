using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ItemBase
    {
        public IDataObject<string> DataObject { get; set; }

        public virtual void Next()
        {
            DataObject.NextItem();
        }

        public virtual void Prev()
        {
            DataObject.PrevItem();
        }

        public virtual void Add(string item)
        {
            DataObject.AddItem(item);
        }

        public virtual void Delete(string item)
        {
            DataObject.DeleteItem(item);
        }

        public virtual void Get()
        {
            var item = DataObject.GetCurrentItem();
            Console.WriteLine(item);
        }

    }
}

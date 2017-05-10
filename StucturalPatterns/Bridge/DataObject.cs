using System.Collections.Generic;

namespace Bridge
{
    class DataObject : IDataObject<string>
    {
        private readonly IList<string> records;
        private int current;

        public DataObject()
        {
            records = new List<string> {"Alex", "John"};
        }
        public void NextItem()
        {
            if (current < records.Count - 1)
            {
                current++;
            }
        }

        public void PrevItem()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public void AddItem(string item)
        {
           records.Add(item);
        }

        public void DeleteItem(string item)
        {
            records.Remove(item);
        }

        public string GetCurrentItem()
        {
            return records[current];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class XMLCars : IXMLComponent
    {
        private IList<IXMLComponent> _cars = new List<IXMLComponent>();
        public Car car { get; set; }
        public string Name { get; set; }
        private int level;
        public void Add(IXMLComponent component)
        {
            level++;
            _cars.Add(component);
        }

        public void Print()
        {
            Console.WriteLine(Name);
            foreach (var item in _cars)
            {

                item.Print();
            }
        }


    }
}

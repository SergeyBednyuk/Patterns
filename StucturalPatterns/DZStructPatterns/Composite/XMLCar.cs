using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    class XMLCar : IXMLComponent
    {
        public Car car { get; set; }
        private XElement _xElement;
        public string Name { get; set; }

        public XMLCar(string name, Car car)
        {
            Name = name;
            this.car = car;

            _xElement = new XElement
                (Name,
                   new XElement("Mark", car.CarMark),
                   new XElement("Model", car.CarModel),
                   new XElement("Year", car.CarYear)
                );
        }

        public void Add(IXMLComponent component)
        {
        }

        public void Print()
        {
            Console.WriteLine(_xElement);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    interface IXMLComponent
    {
        Car car { get; set; }
        string Name { get; set; }
        void Add(IXMLComponent component);
        void Print();
    }
}

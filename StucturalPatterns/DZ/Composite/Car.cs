using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Car
    {
        public string CarMark { get; set; }
        public string CarModel { get; set; }
        public string CarYear { get; set; }

        public override string ToString()
        {
            return String.Format("Mark {0} Model {1} Year - {2}", CarMark, CarModel, CarYear);
        }
    }
}

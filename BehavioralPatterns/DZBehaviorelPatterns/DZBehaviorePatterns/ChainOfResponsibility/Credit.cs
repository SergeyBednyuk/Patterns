using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Credit
    {
        public double Money { get; set; }
        public string Date { get; set; }

        public override string ToString()
        {
            return String.Format("Date : {0} Money - {1}",Date,Money);
        }
    }
}

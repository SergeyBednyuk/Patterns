using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ATM
    {
        public IATMstate State { get; set; }

        public ATM(IATMstate state)
        {
            State = state;
        }


    }
}

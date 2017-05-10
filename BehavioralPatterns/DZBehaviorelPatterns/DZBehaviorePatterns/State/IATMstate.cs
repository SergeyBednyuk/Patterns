using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    interface IATMstate
    {
        void InsertAKard(ATM atm);
        void GetAKard(ATM atm);
        void ErrorATM(ATM atm);
        void RebootATM(ATM atm);
        void SleepATM(ATM atm);
    }
}

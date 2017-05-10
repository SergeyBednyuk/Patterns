using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ATMGetKard : IATMstate
    {
        public void InsertAKard(ATM atm)
        {
            Console.WriteLine("ATM get kard. Error");
            atm.State = new ATMError();
        }

        public void GetAKard(ATM atm)
        {
            Console.WriteLine("ATM get kard.");
            atm.State = new ATMSleep();
        }

        public void ErrorATM(ATM atm)
        {
            Console.WriteLine("ATM error.");
            atm.State = new ATMError();
        }

        public void RebootATM(ATM atm)
        {
            Console.WriteLine("ATM get kard.");
            atm.State = new ATMError();
        }

        public void SleepATM(ATM atm)
        {
            Console.WriteLine("ATM need get kard.");
            atm.State = new ATMGetKard();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ATMSleep : IATMstate
    {
        public void InsertAKard(ATM atm)
        {
            Console.WriteLine("ATM sleep.");
            atm.State = new ATMInserdAKard();
        }

        public void GetAKard(ATM atm)
        {
            Console.WriteLine("ATM sleep. Error");
            atm.State = new ATMError();
        }

        public void ErrorATM(ATM atm)
        {
            Console.WriteLine("ATM sleep. Error");
            atm.State = new ATMError();
        }

        public void RebootATM(ATM atm)
        {
            Console.WriteLine("ATM reboot.");
            atm.State = new ATMReboot();
        }

        public void SleepATM(ATM atm)
        {
            Console.WriteLine("ATM sleep.");
            atm.State = new ATMSleep();
        }
    }
}

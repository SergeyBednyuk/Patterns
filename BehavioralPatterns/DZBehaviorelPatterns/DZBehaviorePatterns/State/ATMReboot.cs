using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ATMReboot : IATMstate
    {
        public void InsertAKard(ATM atm)
        {
            Console.WriteLine("ATM reboot. Error");
            atm.State = new ATMError();
        }

        public void GetAKard(ATM atm)
        {
            Console.WriteLine("ATM reboot. Error");
            atm.State = new ATMError();
        }

        public void ErrorATM(ATM atm)
        {
            Console.WriteLine("ATM reboot. Error");
            atm.State = new ATMError();
        }

        public void RebootATM(ATM atm)
        {
            Console.WriteLine("ATM reboot. Error");
            atm.State = new ATMError();
        }

        public void SleepATM(ATM atm)
        {
            Console.WriteLine("ATM reboot.");
            atm.State = new ATMSleep();
        }
    }
}

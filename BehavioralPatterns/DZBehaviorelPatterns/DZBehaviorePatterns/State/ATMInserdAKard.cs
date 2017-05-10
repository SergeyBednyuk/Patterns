using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace State
{
    class ATMInserdAKard : IATMstate
    {
        public void InsertAKard(ATM atm)
        {
            Console.WriteLine("ATM has got card");
            atm.State = new ATMError();
        }

        public void GetAKard(ATM atm)
        {
            Console.WriteLine("ATM get card");
            atm.State = new ATMSleep();
        }

        public void ErrorATM(ATM atm)
        {
            Console.WriteLine("ATM error");
            atm.State = new ATMError();
        }

        public void RebootATM(ATM atm)
        {
            Console.WriteLine("...reboot....");
            Thread.Sleep(1000);
            atm.State = new ATMSleep();
        }

        public void SleepATM(ATM atm)
        {
            Console.WriteLine("ATM has got card");
            atm.State = new ATMError();
        }
    }
}

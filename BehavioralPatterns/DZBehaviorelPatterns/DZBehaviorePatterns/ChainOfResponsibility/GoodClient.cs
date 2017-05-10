using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class GoodClient : Client
    {
        public override void ValidatePurchase(Credit credit)
        {
            if (credit.Money < 5000)
            {
                Console.WriteLine("Credit for {0} confirmed on {1}$ start date: {2}  The Bank"
                    ,this.name,credit.Money,credit.Date);
            }
            else
            {
                if (Successor != null)
                {
                    Console.WriteLine("You didn't confirm credit");
                    Successor.ValidatePurchase(credit);
                }
            }
        }
    }
}

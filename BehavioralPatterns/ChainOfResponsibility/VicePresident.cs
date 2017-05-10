using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class VicePresident : Approver
    {
        public override void ValidatePurchase(Purchase purchase)
        {
            if (purchase.Amount < 50000.0)
            {
                Console.WriteLine("Purchase {0} approved by VicePresident",
                    purchase.Number);
            }
            else
            {
                if (Successor != null)
                {
                    Successor.ValidatePurchase(purchase);
                }
            }
        }
    }
}

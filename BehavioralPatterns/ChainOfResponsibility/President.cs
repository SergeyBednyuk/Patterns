using System;

namespace ChainOfResponsibility
{
    class President : Approver
    {
        public override void ValidatePurchase(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine("Purchase {0} approved by President",
                    purchase.Number);
            }
            else
            {
                Console.WriteLine
                    ("Need to fix a meeting to duscuss purchase #{0}", 
                    purchase.Number);
            }
        }
    }
}

using System;

namespace ChainOfResponsibility
{
    class Director : Approver
    {
        public override void ValidatePurchase(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("Purchase {0} approved by Director",
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

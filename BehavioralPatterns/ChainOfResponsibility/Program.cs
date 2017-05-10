using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver larry = new Director();
            Approver john = new VicePresident();
            Approver tomas = new President();

            // larry -> john -> tomas
            larry.SetSuccessor(john);
            john.SetSuccessor(tomas);

            var p = new Purchase(1, 1000.0, "New iPhone for my wife");
            larry.ValidatePurchase(p);

            Console.ReadKey();

            var p2 = new Purchase(2, 50000.0, "New Audi A8 for my....");
            john.ValidatePurchase(p2);

            Console.ReadKey();

            var p3 = new Purchase(3, 15000000.0, "New Boeing for my wife");
            tomas.ValidatePurchase(p3);

            Console.ReadKey();
        }
    }
}

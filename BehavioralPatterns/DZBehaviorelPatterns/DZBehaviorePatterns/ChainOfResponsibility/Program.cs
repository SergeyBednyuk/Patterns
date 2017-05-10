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
            Client ivan = new GoodClient() {name = "Ivan"};
            Client vasya = new NormalClient() {name = "Vasya" };
            Client muhamed = new BadClient() {name = "Muhamed" };

            ivan.SetSuccessor(vasya);
            vasya.SetSuccessor(muhamed);

            var credit1 = new Credit() { Date = "12.01.2011", Money = 4000 };
            ivan.ValidatePurchase(credit1);

            Console.ReadKey();

            var credit2 = new Credit() {Date = "15.11.2013", Money = 3000 };
            vasya.ValidatePurchase(credit2);

            Console.ReadKey();

            var credit3 = new Credit() { Date = "1.05.2016", Money = 200 };
            muhamed.ValidatePurchase(credit3);

            Console.ReadKey();

        }
    }
}

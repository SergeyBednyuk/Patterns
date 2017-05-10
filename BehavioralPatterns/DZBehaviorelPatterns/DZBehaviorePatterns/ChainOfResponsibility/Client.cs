using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class Client
    {
        public string name;
        protected Client Successor;

        public void SetSuccessor(Client successor)
        {
            Successor = successor;
        }

        public abstract void ValidatePurchase(Credit credit);
    }
}

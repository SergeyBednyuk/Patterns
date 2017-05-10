using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TamplateMethod
{
    abstract class EmailDesigner
    {
        protected Email _email = new Email();

        protected void PushButtonCreateEmail()
        {
            Console.WriteLine("Email Create....");
            Thread.Sleep(3000);
            Console.WriteLine("Email Created!");
        }
        protected void SetAdress(string adress)
        {
            _email.Address = adress;
        }
        protected void SetHead(string head)
        {
            _email.Head = head;
        }
        protected abstract void SetFileName(bool name);
        protected void SetMessage()
        {
            Console.Write("Enter Yours message : ");
            _email.Message = Convert.ToString(Console.ReadLine());
        }
        public abstract Email GetEmail();
        public abstract void Create();

    }
}

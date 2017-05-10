using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateMethod
{
    class CreateEmail : EmailDesigner,ICloneable
    {
        public object Clone()
        {
            return new Email() {Address = _email.Address, Head = _email.Head,
                AddFile = _email.AddFile, Message = _email.Message};
        }

        public override Email GetEmail()
        {
            Email getEmail = _email;
            return getEmail;
        }

        protected override void SetFileName(bool name)
        {
            if (name == true)
            {
                _email.AddFile = true;
            }
        }


        public override string ToString()
        {
            return String.Format("Adress : {0} \nHead : {1}\nFile - {2}\nMessage : {3}"
                , _email.Address, _email.Head, _email.AddFile.ToString(),_email.Message);
        }

        public override void Create()
        {
            Console.Write("Enter Adress : ");
            SetAdress(Console.ReadLine());
            Console.Write("Enter Head : ");
            SetHead(Console.ReadLine());
            Console.Write("File? - ");
            SetFileName(Convert.ToBoolean(Console.ReadLine()));
            SetMessage();
        }
    }
}

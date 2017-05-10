using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class Email
    {
        public Uri Adress{ get; set; }
        public string Topic { get; set; }
        public Boolean FileToMail { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return String.Format("Adress {0}\nTopic\n{1}\nFile to Mail? {2}\nMessage\n{3}",Convert.ToString(Adress),Topic,FileToMail,Message);
        }
    }
}

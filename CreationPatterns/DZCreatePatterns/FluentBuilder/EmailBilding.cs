using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class EmailBilding : IEmailBilder
    {
        private Email _email = new Email();

        public Email GetEmail()
        {
            return _email;
        }

        public IEmailBilder SetAddFileToMail(bool flag)
        {
            _email.FileToMail = flag;
            return this;
        }

        public IEmailBilder SetAddress(Uri email)
        {
            _email.Adress = email;
            return this;
        }

        public IEmailBilder SetMessage(string message)
        {
            _email.Message = message;
            return this;
        }

        public IEmailBilder SetTopic(string topic)
        {
            _email.Topic = topic;
            return this;
        }
    }
}

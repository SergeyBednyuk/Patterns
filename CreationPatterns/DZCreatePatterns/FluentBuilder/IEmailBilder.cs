using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    interface IEmailBilder
    {
        IEmailBilder SetAddress(Uri email);
        IEmailBilder SetTopic(string topic);
        IEmailBilder SetAddFileToMail(bool flag);
        IEmailBilder SetMessage(string message);

        Email GetEmail();
    }
}

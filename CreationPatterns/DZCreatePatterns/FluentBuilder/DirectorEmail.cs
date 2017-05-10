using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class DirectorEmail
    {
        IEmailBilder _emailBilder;

        public DirectorEmail(IEmailBilder emailBilder)
        {
            this._emailBilder = emailBilder;
        }

        public IEmailBilder Construct(Uri adress,string topic,Boolean fileToMail, string message)
        {
            _emailBilder.SetAddress(adress)
                .SetTopic(topic)
                .SetAddFileToMail(fileToMail)
                .SetMessage(message);
            return this._emailBilder;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            var emailBilder = new EmailBilding();

            var emailDirector = new DirectorEmail(emailBilder);
            emailDirector.Construct(new Uri("https://www.google.com"), "Message", false, "Mama wash window");

            var email = emailBilder.GetEmail();

            Console.WriteLine(email);

            Console.ReadKey();
        }
    }
}

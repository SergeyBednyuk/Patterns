using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new CreateEmail();
            email.Create();

            var getEmail = email.GetEmail();

            Console.WriteLine(ReferenceEquals(email, getEmail));

            Console.WriteLine(email);

            Console.ReadKey();
        }
    }
}

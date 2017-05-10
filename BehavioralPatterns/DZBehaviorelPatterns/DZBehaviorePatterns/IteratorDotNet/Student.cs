using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDotNet
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupNumber { get; set; }

        public override string ToString()
        {
            return String.Format("First name - {0} Last name - {1} Group namber : {2}", FirstName, LastName, GroupNumber);
        }
    }
}

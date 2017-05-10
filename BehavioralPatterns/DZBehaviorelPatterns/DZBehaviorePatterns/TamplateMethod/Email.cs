using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamplateMethod
{
    public class Email
    {
        public string Address{ get; set; }
        public string Head{ get; set; }
        public bool AddFile { get; set; }
        public string Message { get; set; }
    }
}

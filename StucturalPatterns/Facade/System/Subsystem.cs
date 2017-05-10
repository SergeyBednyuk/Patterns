using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.System
{
    internal class Subsystem1
    {
        public string A1()
        {
            return "Subsystem1 method A1";
        }
        public string A2()
        {
            return "Subsystem1 method A2";
        }
    }
    internal class Subsystem2
    {
        public string B1()
        {
            return "Subsystem2 method B1";
        }
        public string B2()
        {
            return "Subsystem2 method B2";
        }
    }
    internal class Subsystem3
    {
        public string C()
        {
            return "Subsystem3 method C";
        }
       
    }
}

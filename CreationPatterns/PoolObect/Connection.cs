using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PoolObect
{
    public class Connection
    {
        public bool isInUse { get; set; }

        public Connection()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Create connect.....  ");
            Console.WriteLine("Connection is create");
        }
    }
}

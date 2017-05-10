using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var calc = new Colculator();
            user.SetCommand(new KalculatorCommand('!',100));
            user.Colculate();
            user.SetCommand(new KalculatorCommand('!', 10));
            user.Colculate();
            user.SetCommand(new KalculatorCommand('!', 20));
            user.Colculate();
            user.Exit();

        }
    }
}

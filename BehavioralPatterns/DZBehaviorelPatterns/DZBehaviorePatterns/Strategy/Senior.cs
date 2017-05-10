using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Senior : IColculateVacation
    {
        public void ColculateVacation(int expirians)
        {
            Console.WriteLine("You have {0} day vacation", expirians + 26);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new Creator();

            for (int i = 1; i < 8; i++)
            {
                var day = creator.GetDay(i);
                day.GetDailyRoutine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

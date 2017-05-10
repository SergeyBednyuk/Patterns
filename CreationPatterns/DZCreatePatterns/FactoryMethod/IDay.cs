using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class IDay
    {
        Dictionary<DateTime, string> _dailyRoutine = new Dictionary<DateTime, string>();

        public void SetDailyRoutine(DateTime time, string doings)
        {
            _dailyRoutine.Add(time, doings);
        }
        public void GetDailyRoutine()
        {
             foreach (var item in _dailyRoutine)
            {
                Console.WriteLine("Time - {0} Doings - {1}", item.Key, item.Value);
            }
        }
       
    }
}

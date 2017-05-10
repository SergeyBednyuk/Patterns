using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Sunday:IDay
    {
        public Sunday()
        {
            base.SetDailyRoutine(new DateTime(2017, 3, 26, 8, 00, 00), "Sunday");
            base.SetDailyRoutine(new DateTime(2017, 3, 26, 9, 00, 00), "Breakfest");
            base.SetDailyRoutine(new DateTime(2017, 3, 26, 10, 30, 00), "Study");
            base.SetDailyRoutine(new DateTime(2017, 3, 26, 14, 00, 00), "Lanch");
            base.SetDailyRoutine(new DateTime(2017, 3, 26, 22, 00, 00), "Dinner");
        }
    }
}

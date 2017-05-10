using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Saturday : IDay
    {
        public Saturday()
        {
            base.SetDailyRoutine(new DateTime(2017, 3, 25, 8, 00, 00), "Saturday");
            base.SetDailyRoutine(new DateTime(2017, 3, 25, 9, 00, 00), "Breakfest");
            base.SetDailyRoutine(new DateTime(2017, 3, 25, 10, 30, 00), "Study");
            base.SetDailyRoutine(new DateTime(2017, 3, 25, 14, 00, 00), "Lanch");
            base.SetDailyRoutine(new DateTime(2017, 3, 25, 22, 00, 00), "Dinner");
        }
    }
}

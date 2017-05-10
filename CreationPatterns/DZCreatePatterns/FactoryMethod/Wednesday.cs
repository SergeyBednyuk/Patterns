using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Wednesday:IDay
    {
        public Wednesday()
        {
            base.SetDailyRoutine(new DateTime(2017, 3, 22, 9, 00, 00), "Wednesday");
            base.SetDailyRoutine(new DateTime(2017, 3, 22, 10, 00, 00), "Breakfest");
            base.SetDailyRoutine(new DateTime(2017, 3, 22, 14, 00, 00), "Lanch");
            base.SetDailyRoutine(new DateTime(2017, 3, 22, 19, 30, 00), "Study");
            base.SetDailyRoutine(new DateTime(2017, 3, 22, 22, 00, 00), "Dinner");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Thursday:IDay
    {
        public Thursday()
        {
            base.SetDailyRoutine(new DateTime(2017, 3, 23, 9, 00, 00), "Thursday");
            base.SetDailyRoutine(new DateTime(2017, 3, 23, 10, 00, 00), "Breakfest");
            base.SetDailyRoutine(new DateTime(2017, 3, 23, 14, 00, 00), "Lanch");
            base.SetDailyRoutine(new DateTime(2017, 3, 23, 19, 30, 00), "Study");
            base.SetDailyRoutine(new DateTime(2017, 3, 23, 22, 00, 00), "Dinner");
        }
    }
}

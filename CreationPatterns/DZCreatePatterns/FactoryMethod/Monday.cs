using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Monday:IDay
    {
        public Monday()
        {
            base.SetDailyRoutine(new DateTime(2017, 3, 20, 9, 00, 00), "Monday");
            base.SetDailyRoutine(new DateTime(2017, 3, 20, 10, 00, 00), "Breakfest");
            base.SetDailyRoutine(new DateTime(2017, 3, 20, 14, 00, 00), "Lanch");
            base.SetDailyRoutine(new DateTime(2017, 3, 20, 19, 30, 00), "Study");
            base.SetDailyRoutine(new DateTime(2017, 3, 20, 22, 00, 00), "Dinner");
        }
    }
}

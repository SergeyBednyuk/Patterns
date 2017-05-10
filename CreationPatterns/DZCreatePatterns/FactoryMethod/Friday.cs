using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Friday:IDay
    {
        public Friday()
        {
            base.SetDailyRoutine(new DateTime(2017, 3, 24, 9, 00, 00), "Friday");
            base.SetDailyRoutine(new DateTime(2017, 3, 24, 10, 00, 00), "Breakfest");
            base.SetDailyRoutine(new DateTime(2017, 3, 24, 14, 00, 00), "Lanch");
            base.SetDailyRoutine(new DateTime(2017, 3, 24, 18, 00, 00), "Relaxation");
            base.SetDailyRoutine(new DateTime(2017, 3, 24, 23, 00, 00), "Dinner");
        }
    }
}

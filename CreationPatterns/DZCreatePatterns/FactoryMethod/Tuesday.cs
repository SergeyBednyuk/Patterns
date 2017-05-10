using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Tuesday:IDay
    {
        public Tuesday()
        {
            base.SetDailyRoutine(new DateTime(2017, 3, 21, 9, 00, 00), "Tuesday");           
            base.SetDailyRoutine(new DateTime(2017, 3, 21, 10, 00, 00), "Breakfest");
            base.SetDailyRoutine(new DateTime(2017, 3, 21, 14, 00, 00), "Lanch");
            base.SetDailyRoutine(new DateTime(2017, 3, 21, 20, 00, 00), "Dinner");
        }
    }
}

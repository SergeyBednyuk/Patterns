using System.Collections.Generic;


namespace Strategy
{
    class UnitedStatesHolidayList : IHolidayList
    {
        public HashSet<string> GetHolidays()
        {
            return new HashSet<string>
            {
                "01.01",
                "24.12",
                "25.12",
                "04.07"
            };
        }
    }
}

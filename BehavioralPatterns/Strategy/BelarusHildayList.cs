using System.Collections.Generic;


namespace Strategy
{
    class BelarusHildayList : IHolidayList
    {
        public HashSet<string> GetHolidays()
        {
            return new HashSet<string>
            {
                "01.01",
                "07.01",
                "08.03",
                "09.05",
                "03.07",
                "25.12"
            };
        }
    }
}

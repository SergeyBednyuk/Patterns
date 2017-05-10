namespace Strategy
{
    class Client
    {
        private readonly IHolidayList _holidayList;

        public Client(IHolidayList holidayList)
        {
            _holidayList = holidayList;
        }

        public bool CheckForHoliday(string date)
        {
            return _holidayList.GetHolidays().Contains(date);
        }
    }
}

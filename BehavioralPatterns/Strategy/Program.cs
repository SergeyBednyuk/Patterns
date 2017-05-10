using System;


namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new UnitedStatesHolidayList());

            var result = client.CheckForHoliday("24.12");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

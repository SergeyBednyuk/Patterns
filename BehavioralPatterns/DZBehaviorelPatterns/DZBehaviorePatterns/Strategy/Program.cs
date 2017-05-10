using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var vasya1 = new Employee("Vasya", "Pupkin", new Middle(), 3);
            vasya1.ColculateVacation();

            var vasya2 = new Employee("Vasya", "Pupkin", new Senior(), 5);
            vasya2.ColculateVacation();

            var vasya3 = new Employee("Vasya", "Pupkin", new Junior(), 2);
            vasya3.ColculateVacation();

            var vasya4 = new Employee("Vasya", "Pupkin", new Middle(), 1);
            vasya4.ColculateVacation();


            Console.ReadKey();
        }
    }
}

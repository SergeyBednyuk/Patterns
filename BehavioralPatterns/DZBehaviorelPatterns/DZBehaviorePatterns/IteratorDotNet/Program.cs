using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ivan1 = new Student() { FirstName = "Ivan1", LastName = "Ivanov1", GroupNumber = "123" };
            var Ivan2 = new Student() { FirstName = "Ivan2", LastName = "Ivanov2", GroupNumber = "123" };
            var Ivan3 = new Student() { FirstName = "Ivan3", LastName = "Ivanov3", GroupNumber = "123" };

            var students = new StudentsGroup(Ivan1, Ivan2, Ivan3);
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            students.AddItem(new Student() { FirstName = "Kolya", LastName = "Pupkin", GroupNumber = "123" });

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

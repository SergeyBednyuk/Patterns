using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(){ Name = "Alex",id = Guid.NewGuid()};
            Console.WriteLine("Name - {0} Id - {1}",student.Name,student.id);

            var clone = student.Clone();
            Console.WriteLine("Name - {0} Id - {1}", clone.Name, clone.id);

            Console.ReadKey();
        }
    }
}

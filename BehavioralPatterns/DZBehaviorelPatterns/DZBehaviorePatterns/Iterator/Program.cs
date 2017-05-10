using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var ivan1 = new Student() { FirstName = "Ivan1", LastName = "Ivanov1", GroupNumber = "123" };
            var ivan2 = new Student() { FirstName = "Ivan2", LastName = "Ivanov2", GroupNumber = "123" };
            var ivan3 = new Student() { FirstName = "Ivan3", LastName = "Ivanov3", GroupNumber = "123" };
            var ivan4 = new Student() { FirstName = "Ivan4", LastName = "Ivanov4", GroupNumber = "123" };

            var collection = new AgregatorCollection(ivan1, ivan2, ivan3, ivan4);

            var iterator = collection.CreateIterator();

            Console.WriteLine("Iterator:");
            while (!iterator.IsDone)
            {
                Console.WriteLine(iterator.Current);
                iterator.MoveNext();
            }


            Console.ReadKey();

        }
    }
}

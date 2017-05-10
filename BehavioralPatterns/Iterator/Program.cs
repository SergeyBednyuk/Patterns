using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List(1, 2, 3, 4, 5);
            Console.WriteLine("Iterator:");

            var iterator = list.CreateIterator();

            while (!iterator.IsDone)
            {
                Console.WriteLine(iterator.Current);
                iterator.MoveNext();
            }

            Console.ReadKey();
        }
    }
}

using System;


namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorter = new ConcreteSorter(1, 30, 15, 0);
            sorter.Sort();

            var result = sorter.GetData();

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

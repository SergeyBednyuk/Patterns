using System;


namespace IteratorDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop("Camera", "SmartPhone", "Laptop");

            foreach (var item in shop)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

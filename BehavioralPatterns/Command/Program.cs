using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            Console.WriteLine("Undo 4 commands");
            user.Undo(4);

            Console.ReadLine();
        }
    }
}

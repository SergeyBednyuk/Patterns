using System;


namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = new Parent();
            parent.HandleKid();
            parent.HandleOlder();
            parent.HandleKid();
            parent.HandleOlder();

            Console.ReadKey();
        }
    }
}

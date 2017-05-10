using System;
using Facade.System;

namespace Facade
{
    public static class Facade
    {
        static readonly Subsystem1 System1 = new Subsystem1();
        static readonly Subsystem2 System2 = new Subsystem2();
        static readonly Subsystem3 System3 = new Subsystem3();

        public static void Operation1()
        {
            var result = System1.A1() + System2.B1() + System3.C();
            Console.WriteLine("Operation1 result:{0}",result);
        }
        public static void Operation2()
        {
            var result = System1.A2() + System2.B2();
            Console.WriteLine("Operation2 result:{0}", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var detector = new Detector();

            var listener1 = new ConsoleObserver(ConsoleColor.Blue);
            detector.Observe(listener1);
            detector.Value = 150;

            Console.ReadLine();

            var listener2 = new ConsoleObserver(ConsoleColor.Red);
            detector.Observe(listener2);
            detector.Value = 200;
            Console.ReadLine();

            detector.StopObserving(listener1);
            detector.Value = 5;
            Console.ReadLine();
        }
    }
}

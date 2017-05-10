using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var detector = new Detector();

            var listener1 = new ConsoleObserver(ConsoleColor.Blue);
            var unsubscriber1 = detector.Subscribe(listener1);
            detector.Value = 100;

            Console.ReadLine();

            var listener2 = new ConsoleObserver(ConsoleColor.Red);
            var unsubscriber2 = detector.Subscribe(listener2);
            detector.Value = 150;

            Console.ReadLine();

            unsubscriber1.Dispose();
            detector.Value = 90;
            Console.ReadLine();
        }
    }
}

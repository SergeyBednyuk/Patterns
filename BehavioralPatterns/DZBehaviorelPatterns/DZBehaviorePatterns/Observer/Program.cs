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
            var bus1 = new Bus("Ivan1");
            var bus2 = new Bus("Ivan2");
            var bus3 = new Bus("Ivan3");

            var busStation = new BusStation();
            busStation.AddObserver(bus1);
            bus1.Move();
            bus2.Move();
            bus3.Move();

            busStation.NotifyObserversChange();
            Console.WriteLine();

            busStation.AddObserver(bus2);
            busStation.AddObserver(bus3);
            busStation.NotifyObserversChange();

            Console.ReadKey();
        }
    }
}

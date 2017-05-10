using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class BusStation : IObservable
    {
        private readonly IList<IObserver> _observers =
            new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserversChange()
        {
            Console.WriteLine("Acciden on the rout");
            foreach (var item in _observers)
            {
                item.OnChange();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Detector
    {
        private byte _value;

        private readonly IList<IObserver> _observers=
            new List<IObserver>();

        public byte Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    Notify();
                }
            }
        }

        public void Observe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void StopObserving(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.OnChange(this);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDotNet
{
    class Detector : IObservable<Detector>
    {
        private byte _value;

        private readonly IList<IObserver<Detector>> _observers=
            new List<IObserver<Detector>>();

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

        public IDisposable Subscribe(IObserver<Detector> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(this, observer);
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(this);
            }
        }

        private class Unsubscriber : IDisposable
        {
            private readonly Detector _detector;
            private readonly IObserver<Detector> _listener;

            public Unsubscriber(Detector detector, IObserver<Detector> listener)
            {
                _detector = detector;
                _listener = listener;
            }

            public void Dispose()
            {
               _detector._observers.Remove(_listener);
            }
        }
    }
}

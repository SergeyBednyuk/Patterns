using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Bus : IObserver
    {
        private string _nameBusDriver;

        public Bus(string nameBusDriver)
        {
            _nameBusDriver = nameBusDriver;
        }
        public void OnChange()
        {
            Console.WriteLine("{0} moves by reserve rout ", _nameBusDriver);
        }

        public void Move()
        {
            Console.WriteLine("{0} moves by standart rout ", _nameBusDriver);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Director
    {
        private  Teachers _teachers;
        private string _directorName;

        public Director(Teachers teachers, string name)
        {
            _teachers = teachers;
            _directorName = name;
            _teachers.SignOn(this);
        }

        public void RecieveMessage(string message, string from)
        {
            if (_directorName != from)
            {
                Console.WriteLine("{0} recieved a message from {1}: {2}",
                    _directorName, from, message);
            }
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Sent from {0}: {1}", _directorName, message);
            _teachers.Send(message, _directorName);
        }

    }
}

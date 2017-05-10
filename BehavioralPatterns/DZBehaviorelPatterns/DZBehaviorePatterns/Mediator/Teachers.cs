using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Teachers
    {
        private IList<Teacher> _teachers = 
            new List<Teacher>();

        public void SignOn(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void Send(string message, string from)
        {
            foreach (var teacher in _teachers)
            {
                teacher.RecieveMessage(message, from);
            }
        }
    }
}

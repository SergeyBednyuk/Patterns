using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Invoker
    class User
    {
        private ICommand _command;
    
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void Colculate()
        {
            _command.Execute();
        }
        public void Exit()
        {
            _command.Undo();
        }
    }
}

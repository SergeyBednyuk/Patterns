using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class User
    {
        private IList<ICommand> _commands = new List<ICommand>();
        private readonly Calculator _calculator = new Calculator();

        private int _current;

        public void Compute(char @operator, int operand)
        {
            var command = new CalculateCommand(_calculator, @operator, 
                operand);
            command.Execute();
            _commands.Add(command);
            _current++;
        }

        public void Undo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    _commands[--_current].Undo();
                }
            }
        }

    }
}

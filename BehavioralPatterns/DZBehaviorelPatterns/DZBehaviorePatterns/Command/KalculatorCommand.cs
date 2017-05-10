using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Command
{
    //ConcreteCommand
    class KalculatorCommand : ICommand
    {
        private readonly char _operator;
        private readonly int _number;
        private Colculator _calculator = new Colculator();

        public KalculatorCommand(char @operator, int operand)
        {
            _operator = @operator;
            _number = operand;
        }

        public void Execute()
        {
            _calculator.Oteration(_operator, _number);
        }

        public void Undo()
        {
            Console.WriteLine("Good by!");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}

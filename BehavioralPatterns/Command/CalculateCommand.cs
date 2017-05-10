using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CalculateCommand : ICommand
    {
        private readonly char _operator;
        private readonly int _operand;

        private readonly Calculator _calculator;

        public CalculateCommand(Calculator calculator, char @operator, int operand)
        {
            _operator = @operator;
            _operand = operand;
            _calculator = calculator;
        }

        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public void Undo()
        {
            _calculator.Operation(GetOppositeOperator(_operator), _operand);
        }

        private char GetOppositeOperator(char @operator)
        {
            const string operators = "+-*/";
            const string opposite = "-+/*";

            var operatorSymbolIndex = operators.IndexOf(@operator);
            if (operatorSymbolIndex == -1)
            {
                throw new ArgumentException("bad operator");
            }

            return opposite[operatorSymbolIndex];
        }
    }
}

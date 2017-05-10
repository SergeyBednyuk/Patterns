using System;

namespace Command
{
    public class Calculator
    {
        private int _value;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    _value += operand;
                    break;
                case '-':
                    _value -= operand;
                    break;
                case '*':
                    _value *= operand;
                    break;
                case '/':
                    _value /= operand;
                    break;
            }
            Console.WriteLine("Current Value is {0}", _value);
        }
    }
}

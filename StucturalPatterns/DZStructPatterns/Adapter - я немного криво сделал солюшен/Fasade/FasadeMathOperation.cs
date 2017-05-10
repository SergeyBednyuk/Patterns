using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fasade.Function;

namespace Fasade
{
    static class FasadeMathOperation
    {
        static readonly OperationPlus plus = new OperationPlus();
        static readonly OperationMinus minus = new OperationMinus();
        static readonly OperationMultiplication multiplication = new OperationMultiplication();
        static readonly OperationDivision division = new OperationDivision();

        public static void Plus(double first, params double[] nambers)
        {
            string tmp = String.Empty;
            foreach (var item in nambers)
            {
                tmp += " + "+item;
            }
            Console.WriteLine("{0} {1} = {2}", first,tmp,plus.Plus(first, nambers));
        }
        public static void Minus(double first, params double[] nambers)
        {
            string tmp = String.Empty;
            foreach (var item in nambers)
            {
                tmp += " - " + item;
            }
            Console.WriteLine("{0} {1} = {2}", first, tmp, minus.Minus(first, nambers));
        }
        public static void Multiplication(double first, params double[] nambers)
        {
            string tmp = String.Empty;
            foreach (var item in nambers)
            {
                tmp += " * " + item;
            }
            Console.WriteLine("{0} {1} = {2}", first, tmp, multiplication.Multiplication(first, nambers));
        }
        public static void Division(double first, params double[] nambers)
        {
            string tmp = String.Empty;
            foreach (var item in nambers)
            {
                tmp += " / " + item;
            }
            try
            {
                Console.WriteLine("{0} {1} = {2}", first, tmp, division.Division(first, nambers));
            }
            catch (Exception)
            {
                Console.WriteLine("Division by Zero");
            }
            
        }
        public static void Sqrt(double number)
        {
            Console.WriteLine("Sqrt {0} = {1}",number,multiplication.Multiplication(number,number));
        }
        public static void Factorial(int number)
        {
            double tmp = 1;
            for (int i = 1; i <= number; i++)
            {
                tmp = multiplication.Multiplication(tmp, i);
            }
            Console.WriteLine("{0}! = {1}",number,tmp);
        }
    }
}

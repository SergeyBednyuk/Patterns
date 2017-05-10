using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // Receiver
    class Colculator
    {
        public void Oteration(char @operation, double number)
        {
            switch (@operation)
            {
                case '!':
                    {
                        BigInteger BigInt = 1;
                        for (int i = 1; i <= number; i++)
                        {
                            BigInt *= i;
                        }
                        Console.WriteLine(BigInt);
                        Console.ReadKey();
                        break;
                    }
                    //Here you can add different math function....
                    //I am lazy ass  
                default:
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    class SingleToneStatic
    {
        private static SingleToneStatic _instnse = new SingleToneStatic();
        private ExeptionGenerator _exGen = new ExeptionGenerator();

        static SingleToneStatic()
        {

        }

        public static SingleToneStatic GetInstanse()
        {
            return _instnse;
        }

        public void Loger()
        {
            var logString = _exGen.GetDivideByZeroExceptionExeption().ToString()
                + DateTime.Now.ToString() + Environment.NewLine
                + _exGen.GetFormatExceptionExeption().ToString()
                + DateTime.Now.ToString() + Environment.NewLine
                + "Static Singletone" + Environment.NewLine;

            using (FileStream fs = new FileStream("log.txt", FileMode.Append))
            {
                byte[] logByte = System.Text.Encoding.Default.GetBytes(logString);

                fs.Write(logByte, 0, logByte.Length);
            }
        }
    }
}

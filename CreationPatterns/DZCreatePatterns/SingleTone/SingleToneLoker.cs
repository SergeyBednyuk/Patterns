using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    class SingleToneLoker
    {
        private static SingleToneLoker _instnse;
        private static readonly object _locker = new object();
        public ExeptionGenerator _exGen = new ExeptionGenerator();

        private SingleToneLoker()
        {

        }

        public static SingleToneLoker GetInstanse()
        {
            lock (_locker)
            {
                if (_instnse == null)
                {
                    _instnse = new SingleToneLoker();
                    return _instnse;
                }
                return _instnse;
            }

        }

        public void Loger()
        {
            var logString = _exGen.GetDivideByZeroExceptionExeption().ToString()
                + DateTime.Now.ToString() + Environment.NewLine
                + _exGen.GetFormatExceptionExeption().ToString()
                + DateTime.Now.ToString() + Environment.NewLine
                + "Loker Singletone" + Environment.NewLine;

            using (FileStream fs = new FileStream("log.txt", FileMode.Append))
            {
                byte[] logByte = System.Text.Encoding.Default.GetBytes(logString);

                fs.Write(logByte, 0, logByte.Length);
            }
        }
    }
}

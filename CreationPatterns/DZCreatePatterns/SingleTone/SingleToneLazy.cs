using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    class SingleToneLazy
    {
        private static readonly Lazy<SingleToneLazy> _lazy_instanse
            = new Lazy<SingleToneLazy>(()=> new SingleToneLazy());
        public static ExeptionGenerator _exGen = new ExeptionGenerator();

        private SingleToneLazy()
        {
        }

        public static SingleToneLazy GetInstanse()
        {
            return _lazy_instanse.Value;
        }

        public void Loger()
        {
            var logString = _exGen.GetDivideByZeroExceptionExeption().ToString()
                + DateTime.Now.ToString() + Environment.NewLine
                + _exGen.GetFormatExceptionExeption().ToString()
                + DateTime.Now.ToString() + Environment.NewLine 
                + "Lazy Singletone" + Environment.NewLine;

            using (FileStream fs = new FileStream("log.txt", FileMode.Append))
            {
                byte[] logByte = System.Text.Encoding.Default.GetBytes(logString);

                fs.Write(logByte, 0, logByte.Length);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    class SingletoneClassic
    {
        private static SingletoneClassic _instnse;
        //класс просто генерит исключения разные
        public ExeptionGenerator _exGen = new ExeptionGenerator();

        private SingletoneClassic()
        {

        }
        //метод отдающий либо новый обьект либо существующий
        public static SingletoneClassic GetInstanse()
        {
            if (_instnse == null)
            {
                _instnse = new SingletoneClassic();
                return _instnse;
            }
            return _instnse;
        }
        //метод пишет в файл
        public void Loger()
        {
            
            var logString = _exGen.GetDivideByZeroExceptionExeption().ToString()
                + DateTime.Now.ToString() + Environment.NewLine
                + _exGen.GetFormatExceptionExeption().ToString()
                + DateTime.Now.ToString() + Environment.NewLine
                + "Classic Singletone" + Environment.NewLine;

            using (FileStream fs = new FileStream("log.txt", FileMode.Append))
            {
                byte[] logByte = System.Text.Encoding.Default.GetBytes(logString);

                fs.Write(logByte, 0, logByte.Length);
            }
        }
    }
}

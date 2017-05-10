using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePatterns
{
    class StudentFactory : IStudentFactory
    {
        public BGUIRStudent CreateBGUIRStudent()
        {
            return new BGUIRStudent();
        }

        public BGUStudent CreateBGUStudent()
        {
            return new BGUStudent();
        }

        public BNTUStudent CreateBNTUStudent()
        {
            return new BNTUStudent();
        }
    }
}

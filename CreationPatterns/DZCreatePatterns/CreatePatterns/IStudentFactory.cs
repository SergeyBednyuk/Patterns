using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePatterns
{
    interface IStudentFactory
    {
        BNTUStudent CreateBNTUStudent();
        BGUIRStudent CreateBGUIRStudent();
        BGUStudent CreateBGUStudent();
    }
}

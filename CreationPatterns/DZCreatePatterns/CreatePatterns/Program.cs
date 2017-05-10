using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentFactory StudentF = new StudentFactory();

            var bguirStudent = StudentF.CreateBGUIRStudent();

            bguirStudent.Name = "Ivan";
            bguirStudent.Surname = "Ivanov";
            Console.WriteLine(bguirStudent);

            var bguStudent = StudentF.CreateBGUStudent();

            bguStudent.Name = "Petr";
            bguStudent.Surname = "Petrov";

            Console.WriteLine(bguStudent);

            var bntuStudent = StudentF.CreateBNTUStudent();

            bntuStudent.Name = "Aleksandr";
            bntuStudent.Surname = "Grigorevich";

            Console.WriteLine(bntuStudent);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Colection:IIterator<Student>
    {
        private readonly Student[] _students;
        private int index = 0;

        public Colection(params Student[] students)
        {
            _students = new Student[students.Length];
            students.CopyTo(_students, 0);
        }

        public Student Current
        {
            get
            {
                return _students[index];
            }
        }

        public bool IsDone
        {
            get
            {
                return index > _students.Length - 1;
            }
        }

        public void MoveNext()
        {
            index++;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}

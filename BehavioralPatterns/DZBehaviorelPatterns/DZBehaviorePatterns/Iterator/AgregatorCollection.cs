using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class AgregatorCollection : Colection,IAgtegator<Student>
    {
        private Student[] _students;
        public AgregatorCollection(params Student[] students)
        {
            _students = new Student[students.Length];
            students.CopyTo(_students, 0);
        }

        public IIterator<Student> CreateIterator()
        {
            return new Colection(_students);
        }
    }
}

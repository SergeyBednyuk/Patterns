using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDotNet
{
    class StudentsGroup : IEnumerable<Student>
    {
        private Student[] _students = new Student[0];

        public StudentsGroup(params Student[] students)
        {
            Array.Resize(ref _students, students.Length);
            students.CopyTo(_students, 0);
        }
        public void AddItem(Student item)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = item;
        }

        public Student GetItem(int index)
        {
            return _students[index];
        }
        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var item in _students)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

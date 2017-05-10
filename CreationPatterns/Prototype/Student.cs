using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Student:Prototype<Student>
    {
        public Guid id{ get; set; }
        public string Name { get; set; }
    }
}

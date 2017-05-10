using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePatterns
{
    interface IStudent
    {
        string Name { set; get; }
        string Surname { set; get; }
        string Speciality { get; }

       
    }
}

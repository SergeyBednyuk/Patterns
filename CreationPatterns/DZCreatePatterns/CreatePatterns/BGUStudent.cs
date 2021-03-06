﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePatterns
{
    class BGUStudent : IStudent
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Speciality
        {
            get
            {
                return "BGU student";
            }
        }


        public override string ToString()
        {
            return String.Format("Name - {0} Surname - {1} Speciality - {2}", Name, Surname, Speciality);
        }
    }
}

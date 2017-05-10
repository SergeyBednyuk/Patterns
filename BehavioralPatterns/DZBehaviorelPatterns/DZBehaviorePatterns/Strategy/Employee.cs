using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Employee
    {
        private string _firstName;
        private string _lastName;
        private IColculateVacation _position;
        private int _expirianse;

        public Employee(string firstName, string lastName, IColculateVacation position, int expirianse)
        {
            _firstName = firstName;
            _lastName = lastName;
            _position = position;
            _expirianse = expirianse;
        }

        public void ColculateVacation()
        {
            _position.ColculateVacation(this._expirianse);
        }

    }
}

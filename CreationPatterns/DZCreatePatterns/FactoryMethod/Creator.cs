using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Creator
    {
        public IDay GetDay(int DayNamber)
        {
            switch (DayNamber)
            {
                case 1:
                    {
                        return new Monday();
                    }
                case 2:
                    {
                        return new Tuesday();
                    }
                case 3:
                    {
                        return new Wednesday();
                    }
                case 4:
                    {
                        return new Thursday();
                    }
                case 5:
                    {
                        return new Friday();
                    }
                case 6:
                    {
                        return new Saturday();
                    }
                case 7:
                    {
                        return new Sunday();
                    }
                default:
                    return null;
            }
        }
    }
}

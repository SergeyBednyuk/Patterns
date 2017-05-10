using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyStringReader
{
    interface IStringReader
    {
        void LoadText(params string[] text);
        int GetCollSymbol(char symbol);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyStringReader
{
    class ProxyStringReader : IStringReader
    {
        private StringReader SR;

        public void LoadText(params string[] text)
        {
            if (SR == null)
            {
                SR = new StringReader();
                SR.LoadText(text);
            }
            else
            {
                SR.LoadText(text);
            }

        }

        public int GetCollSymbol(char symbol)
        {
            if (SR == null)
            {
                SR = new StringReader();
                return SR.GetCollSymbol(symbol);
            }
            else
            {
                return SR.GetCollSymbol(symbol);
            }
        }
        public override string ToString()
        {
            return String.Format("Text - {0}", SR.Text.ToUpper());
        }
    }
}

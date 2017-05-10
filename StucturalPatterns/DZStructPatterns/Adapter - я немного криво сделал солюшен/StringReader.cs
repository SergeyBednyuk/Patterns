using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class StringReader : IStringReader
    {
        private String Text { get; set; }

        public int GetCollSymbol(char symbol)
        {
            int countSymbol = 0;

            foreach (var item in Text)
            {
                if(symbol == item)
                {
                    countSymbol++;
                }
            }
            return countSymbol;
        }

        public void LoadText(params string[] text)
        {
            foreach (var item in text)
            {
                Text = item;
            }
        }
    }
}

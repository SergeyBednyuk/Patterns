using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PrintPageBilder : IPageBilder
    {
        private string _page = string.Empty;

        public void BuildHeader(string header) { }

        public void BuildMenu(string menu) { }

        public void BuldContent(string content)
        {
            _page += content + Environment.NewLine;
        }

        public void BuilderFooter(string footer) { }

        public string GetPage()
        {
            return _page;
        }
    }
}

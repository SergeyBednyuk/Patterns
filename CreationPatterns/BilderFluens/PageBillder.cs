using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilderFluens
{
    class PageBillder:IPageBilder
    {
        private string _page = String.Empty;

        public IPageBilder BuildHeader(string header)
        {
           _page += header + Environment.NewLine;
            return this;
        }

        public IPageBilder BuildMenu(string menu)
        {
            _page += menu + Environment.NewLine;
            return this;
        }

        public IPageBilder BuldContent(string content)
        {
            _page += content + Environment.NewLine;
            return this;
        }

        public IPageBilder BuilderFooter(string footer)
        {
            _page += footer + Environment.NewLine;
            return this;
        }

        public string GetPage()
        {
            return _page;
        }
    }
}

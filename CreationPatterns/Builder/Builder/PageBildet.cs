using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PageBildet:IPageBilder
    {
        private string _page = string.Empty;


        public void BuildHeader(string header)
        {
            _page += header + Environment.NewLine;
        }

        public void BuildMenu(string menu)
        {
            _page += menu + Environment.NewLine;
        }

        public void BuldContent(string content)
        {
            _page += content + Environment.NewLine;
        }

        public void BuilderFooter(string footer)
        {
            _page += footer + Environment.NewLine;
        }

        public string GetPage()
        {
            return _page;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IPageBilder
    {
        void BuildHeader(string header);
        void BuildMenu(string menu);
        void BuldContent(string content);
        void BuilderFooter(string footer);

        string GetPage();
    }
}

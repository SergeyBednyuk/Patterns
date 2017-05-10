using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PageDirector
    {
        private readonly IPageBilder _bilder;

        public PageDirector(IPageBilder bulder)
        {
            _bilder = bulder;
        }

        public string BildPage(int pageID)
        {
            _bilder.BuildHeader("Header of page " + pageID);
            _bilder.BuildMenu("Menu of page " + pageID);
            _bilder.BuldContent("Content of page " + pageID);
            _bilder.BuilderFooter("Footer of page " + pageID);

            return _bilder.GetPage();
        }

        //private string GetContent(int pageID)
        //{
        //    if (pageID <100)
        //    {
        //        return "Мама мыла раму!";
        //    }
        //    else
        //    {
        //        return "Мама не мыла раму!";
        //    }
        //}


    }
}

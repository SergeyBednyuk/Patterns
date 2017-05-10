using System;
using System.Threading;


namespace Proxy
{
    class Image: IImage
    {
        private readonly string FileName;
        public void Display()
        {
            Console.WriteLine("DisplayImage {0}",FileName);
            
        }

        public Image(string fileName)
        {
            FileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading from Disk///");
            Thread.Sleep(1000);
        }
    }
}

using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image1= new ImageProxy("1111");
            IImage image2 = new ImageProxy("22222");
            image1.Display();
            image1.Display();
            image2.Display();
            image2.Display();
            Console.Read();
        }
    }
}

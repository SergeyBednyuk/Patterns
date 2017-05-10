namespace Proxy
{
    class ImageProxy:IImage
    {
        private Image image;
        private readonly string fileName;

        public ImageProxy(string fileName)
        {
            this.fileName = fileName;
        }
        
        public void Display()
        {
            if (image == null)
            {
                image=new Image(fileName);
                image.Display();
            }
            else
            {
                image.Display();
            }
        }
    }
}

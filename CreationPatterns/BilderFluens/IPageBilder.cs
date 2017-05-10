namespace BilderFluens
{
    public interface IPageBilder
    {
        IPageBilder BuildHeader(string header);
        IPageBilder BuildMenu(string menu);
        IPageBilder BuldContent(string content);
        IPageBilder BuilderFooter(string footer);

        string GetPage();
    }
}

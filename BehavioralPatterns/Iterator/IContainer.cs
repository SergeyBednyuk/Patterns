namespace Iterator
{
    public interface IContainer<T>
    {
        IIterator<T> CreateIterator();
    }
}

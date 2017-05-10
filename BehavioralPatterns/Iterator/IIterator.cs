namespace Iterator
{
    public interface IIterator<T>
    {
        void Reset();
        void MoveNext();
        bool IsDone { get; }
        T Current { get; }
    }
}

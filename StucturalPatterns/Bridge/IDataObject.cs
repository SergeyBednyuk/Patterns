namespace Bridge
{
    interface IDataObject<T>
    {
        void NextItem();
        void PrevItem();
        void AddItem(T item);

        void DeleteItem(T item);

        T GetCurrentItem();


    }
}

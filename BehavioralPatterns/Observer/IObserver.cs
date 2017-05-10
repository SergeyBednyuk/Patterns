namespace Observer
{
    interface IObserver
    {
        void OnChange(Detector changedObject);
    }
}

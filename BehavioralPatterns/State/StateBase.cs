namespace State
{
    public abstract class StateBase
    {
        public abstract void HandleKid(Parent parent);
        public abstract void HandleOlder(Parent parent);
    }
}

namespace State
{
    public class Parent
    {
        public Parent()
        {
            State = StateTired.Instance;
        }

        public StateBase State { get; set; }

        public void HandleKid()
        {
            State.HandleKid(this);
        }

        public void HandleOlder()
        {
            State.HandleOlder(this);
        }
    }
}

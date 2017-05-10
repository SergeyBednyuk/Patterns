namespace ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver Successor;

        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }

        public abstract void ValidatePurchase(Purchase purchase);
    }
}

namespace ChainOfResponsability
{
    public class AOrderHandler : IOrderHandler
    {
        private IOrderHandler nextHandler;

        public virtual IOrderHandler setNext(IOrderHandler handler)
        {
            this.nextHandler = handler;
            return handler;
        }
        public virtual IOrder Handle(IOrder order)
        {
            return this.nextHandler != null ? this.nextHandler.Handle(order) : null;

        }
    }
}
namespace ChainOfResponsability
{
    public interface IOrderHandler
    {
         IOrderHandler setNext(IOrderHandler handler);
         IOrder Handle (IOrder order);
    }
}
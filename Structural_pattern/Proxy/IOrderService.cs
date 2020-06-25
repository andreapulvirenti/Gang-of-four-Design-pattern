namespace Proxy
{
    public interface IOrderService
    {
         void TakeOrder (string orderId);
         string DeliverOrder(string orderId);
         void ProcessPayment(string paymentId);

    }
}
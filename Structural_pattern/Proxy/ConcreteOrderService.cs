using System;

namespace Proxy
{
    public class ConcreteOrderService : IOrderService
    {
        public void TakeOrder(string orderId)
        {
            Console.WriteLine($"Creating Order {orderId}");
        }

        public string DeliverOrder(string orderId)
        {
            Console.WriteLine($"Deliver Order {orderId}");
            return "123";
        }

        public void ProcessPayment(string paymentId)
        {
            Console.WriteLine($"Processing Payment for paymentId: {paymentId}");
        }

    }
}
using System;

namespace Proxy
{
    public class OrderProxy : IOrderService
    {
        private ConcreteOrderService _orderService;

        public OrderProxy(ConcreteOrderService orderService) { _orderService = orderService; }

        public void TakeOrder(string orderId)
        {
            if (!OrderExist(orderId))
                throw new InvalidOperationException($"No Order found for orderId {orderId}");

            Console.WriteLine($"Creating Order {orderId}");
            _orderService.DeliverOrder(orderId);
        }

        public string DeliverOrder(string orderId)
        {
            if (!OrderDeliverable(orderId))
            {
                Console.WriteLine("no deliverable order");
                return string.Empty;
            }

           Console.WriteLine($"Creating Order {orderId}");
             var orderNum = _orderService.DeliverOrder(orderId);
            LogDeliverOrder(orderNum); //BASIC ACTION FOR PROXY OBJECT

            return "123";
        }

        public void ProcessPayment(string paymentId)
        {
            Console.WriteLine($"Processing Payment for paymentId: {paymentId}");
        }


        private bool OrderExist(string orderId)
        {
            return true;
        }

        private bool OrderDeliverable(string orderId)
        {
            return true;
        }

        private void LogDeliverOrder(string orderNum)
        {
            Console.WriteLine($"Delivering orderNum: {orderNum}");
        }
    }


}
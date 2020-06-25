
using System;
namespace Proxy
{
    public class OrderClient
    {
        private IOrderService _orderService;

        public OrderClient(IOrderService orderService) { _orderService = orderService; }
        public void TakeAndDeliverOrder(string orderId)
        {
            Console.WriteLine("TakeAndDeliverOrder : take order ");
            _orderService.TakeOrder(orderId);
            Console.WriteLine("TakeAndDeliverOrder : deliver order ");
            _orderService.DeliverOrder(orderId);
            return;
        }
    }
}
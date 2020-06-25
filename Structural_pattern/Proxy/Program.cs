using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteOrderService orderService = new ConcreteOrderService();
            var Client = new OrderClient(orderService);

            Client.TakeAndDeliverOrder("1");

        }
    }
}

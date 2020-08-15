using System;
using System.Collections.Generic;
namespace ChainOfResponsability
{
    public class BackEndHandler : AOrderHandler
    {
        public override IOrder Handle(IOrder order)
        {
            if (order.Products.Count > 0)
            {
                //TODO SHIPPING
                Console.WriteLine($"Registering the order: {order.IDOrder } \n product List: \n");
                foreach (var item in order.Products)
                {
                    Console.WriteLine($" Prodcut:  {item} ");
                }
                return order;
            }

            return base.Handle(order);
        }
    }
}
using System;

namespace ChainOfResponsability
{
    public class ShippingHandler : AOrderHandler
    {
        public override IOrder Handle(IOrder order)
        {
            if (!string.IsNullOrEmpty(order.BuyerAddress))
            {
                //TODO SHIPPING
                Console.WriteLine($"Shipping order: {order.IDOrder }");
                return order;
            }

            return base.Handle(order);
        }
    }
}
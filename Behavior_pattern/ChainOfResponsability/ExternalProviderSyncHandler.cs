using System;

namespace ChainOfResponsability
{
    public class ExternalProviderSyncHandler : AOrderHandler
    {
        public override IOrder Handle(IOrder order)
        {
            if (order.HasFlights)
            {
                //TODO SHIPPING
                Console.WriteLine($"Sending order request  to Neos: {order.IDOrder } \n");
                return order;
            }

            return base.Handle(order);
        }
    }
}

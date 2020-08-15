using System;
using System.Collections.Generic;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {

            IOrder myOrder = new Order()
            {
                BuyerAddress = "Via Roma, 17 Torino (TO)",
                BuyerName = "Marione",
                BuyerLastName = "Rossini",
                HasFlights = true,
                Products = new List<string>(){
                    "Hotel 5 stelle" , "Volo Neos dreamLiner" ,  "Escursione Isola Favignana", "Trasferimento Hotel", "Adeguamento carburante"
                },
                IDOrder = 126
            };

            List<IOrderHandler> orderHandlers  = new List<IOrderHandler>();
            orderHandlers.Add(new ShippingHandler());
            orderHandlers.Add(new BackEndHandler());
            orderHandlers.Add(new ExternalProviderSyncHandler());

            foreach (var oh in orderHandlers)
            {
                oh.Handle(myOrder);
            }

        }

    }
}

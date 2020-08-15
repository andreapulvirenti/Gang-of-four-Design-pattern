
using System;
using System.Collections.Generic;

namespace ChainOfResponsability
{
    public interface IOrder
    {

        int IDOrder { get; set; }
        List<string> Products { get; set; }

        string BuyerName { get; set; }
        string BuyerLastName { get; set; }
        string BuyerAddress { get; set; }
        bool HasFlights { get; set; }
        int CreateOrder(string id);

    }
}
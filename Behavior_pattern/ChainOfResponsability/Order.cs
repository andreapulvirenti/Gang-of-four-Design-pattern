using System.Collections.Generic;

namespace ChainOfResponsability
{
    public class Order : IOrder
    {
        public int IDOrder { get; set; }
        public List<string> Products { get; set; }

        public string BuyerName { get; set; }
        public string BuyerLastName { get; set; }
        public string BuyerAddress { get; set; }
        public bool HasFlights { get; set; }
        public int CreateOrder(string id)
        {

            //TODO STUFF 
            return 126;
        }
    }
}
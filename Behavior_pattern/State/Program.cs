using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            PricingContext context = new PricingContext(new PricingLowMarginState(null));
            context.State.Trip = new Trip("1890");
            context.State.Trip.Price = 1000;
            context.ReloadTrips(40); //load a number of trips available for example 10


            context.SellTrips(2);
            context.ReloadPrice();
            context.SellTrips(20);
            context.ReloadPrice();
            context.SellTrips(10);
            context.ReloadPrice();
            context.SellTrips(2);
            context.ReloadPrice();

        }
    }
}

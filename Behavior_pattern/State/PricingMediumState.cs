using System;
namespace State
{
    public class PricingMediumMarginState : State
    {
        private double marginPercent = 0.20; //medium margin
        public PricingMediumMarginState(State state)
        {
            this.LowerSoldLimit = 10;
            this.HeigherSoldLimit = 19;
            this.Trip = state.Trip;
            this.TripsSold = state.TripsSold;
            this.TripsAvailable = state.TripsAvailable;
        }

        public override double MarginPercent
        {
            get
            {
                return marginPercent;
            }
            set
            {
                marginPercent = value;
            }
        }


        public override void StateChangeCheck(PricingContext context)
        {
            if (this.TripsSold > LowerSoldLimit)
            {
                Console.WriteLine($"Trips SOlD: {this.TripsSold}, switching to {nameof(PricingHighMarginState)}");
                context.State = new PricingHighMarginState(context.State);
            }
            else if (this.TripsSold < HeigherSoldLimit)
            {
                Console.WriteLine($"Trips SOLD: {this.TripsSold}, switching to {nameof(PricingLowMarginState)}");
                context.State = new PricingLowMarginState(context.State);
            }

        }

    }
}
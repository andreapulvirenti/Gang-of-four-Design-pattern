using System;
namespace State
{
    public class PricingHighMarginState : State
    {
        private double marginPercent = 0.30; //high margin

        public PricingHighMarginState(State state)
        {
            this.LowerSoldLimit = 0;
            this.HeigherSoldLimit = 9;
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
            if (this.TripsSold < HeigherSoldLimit)
            {
                Console.WriteLine($"Trips SOLD: {this.TripsSold}, switching to {nameof(PricingMediumMarginState)}");
                context.State = new PricingMediumMarginState(context.State);
            }
            else
            {
                Console.WriteLine($"Trips SOLD: {this.TripsSold}, in {nameof(PricingHighMarginState)}");
            }
        }
    }
}
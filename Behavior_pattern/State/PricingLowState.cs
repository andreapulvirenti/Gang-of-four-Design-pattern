using System;
namespace State
{
    public class PricingLowMarginState : State
    {
        private double marginPercent = 0.10; //low margin
        public PricingLowMarginState(State state)
        {
            this.LowerSoldLimit = 20;
            // this.Trip = state.Trip;
            this.HeigherSoldLimit = 100;
            if (state != null){
                this.Trip = state.Trip;
                this.TripsSold = state.TripsSold;
                this.TripsAvailable = state.TripsAvailable;
            }
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
                Console.WriteLine($"Low margin state, Trips SOLD: {this.TripsSold}, switching to {nameof(PricingMediumMarginState)}");
                context.State = new PricingMediumMarginState(context.State);
            }
            else
            {
                Console.WriteLine($"low margin state, Trips SOLD: {this.TripsSold}");
            }
        }
    }
}
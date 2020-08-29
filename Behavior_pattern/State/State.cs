namespace State
{
    public abstract class State
    {
        public int TripsAvailable{get; set;}
        public int TripsSold { get; set; }
        protected int LowerSoldLimit { get; set; }
        protected int HeigherSoldLimit { get; set; }

        public Trip Trip { get; set; }
        public abstract double MarginPercent {get; set;}
        public abstract void StateChangeCheck(PricingContext context);

    }
}
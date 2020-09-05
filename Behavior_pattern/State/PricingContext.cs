using System;

namespace State
{
    public class PricingContext
    {
        private State _state;

        public PricingContext(State state)
        {
            this._state = state;
            
        }

        public State State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }


        public void SellTrips(int count)
        {
            Console.WriteLine($"Selling {count} trips");
            this.State.TripsAvailable -= count;
            this.State.TripsSold += count;
            Console.WriteLine($"Trips available: {this.State.TripsAvailable} , trips sold: {this.State.TripsSold}");
            ReloadPrice();
        }

        public void ReloadTrips(int tripsNumber)
        {
            this.State.TripsSold = 0;
            this.State.TripsAvailable = tripsNumber;
        }

        protected void ReloadPrice()
        {
            if (this._state.TripsSold <= 0)
                throw new InvalidOperationException("Cannot sell more trips that you have");

            _state.Trip.Price += _state.Trip.Price * _state.MarginPercent; //states pilot marginPercent

            Console.WriteLine($"Current Trip Price: {_state.Trip.Price.ToString()}");
            _state.StateChangeCheck(this);
        }
    }
}
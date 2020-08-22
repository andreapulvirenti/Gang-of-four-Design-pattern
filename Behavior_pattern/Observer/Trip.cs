using System;

namespace Observer
{
    public class Trip
    {
        private string _id;

        public Trip(string id)
        {
            _id = id;
        }

        public string ID => _id;

        public string AptArrival { get; set; }
        public string AptDeparture { get; set; }
        public string HotelName { get; set; }
        public int HotelStars { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int Duration { get; set; }

    }
}
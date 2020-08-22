using System;
namespace Observer
{
    public class MobileAppObserver : IObserver
    {
        public void Update(ISubject db)
        {
            if ((db as DatabaseSubject).Trips.Count > 10)
            {
                Console.WriteLine($"Trips is > 10 for Mobile app observer, forced to refresh");

                foreach (var t in (db as DatabaseSubject).Trips)
                {
                    Console.WriteLine($" {t.ID} - from {t.AptDeparture} to {t.AptArrival} in {t.DepartureDate.ToShortDateString()}, hotelName: {t.HotelName} ({t.HotelStars} stars), {t.Duration} days");
                }
            }
        }
    }
} 
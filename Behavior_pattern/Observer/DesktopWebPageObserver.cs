using System;

namespace Observer
{
    public class DesktopWebPageObserver : IObserver
    {
        public void Update(ISubject db)
        {
            if ((db as DatabaseSubject).Trips.Count > 15)
            {
                Console.WriteLine($"Trips is > 15 for desktop web page observer, forced to refresh");

                foreach (var t in (db as DatabaseSubject).Trips)
                {
                    Console.WriteLine($" {t.ID} - from {t.AptDeparture} to {t.AptArrival} in {t.DepartureDate.ToShortDateString()}, hotelName: {t.HotelName} ({t.HotelStars} stars), {t.Duration} days");
                }
            }
        }
    }
}
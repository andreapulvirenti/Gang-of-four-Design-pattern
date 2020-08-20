using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var trips = new TripCollection();
            trips.AddItem(new Trip("1")
            {
                AptDeparture = "Milano MXP",
                AptArrival = "Roma FCO",
                ArrivalDate = new DateTime(2020, 12, 7),
                Duration = 7,
                DepartureDate = new DateTime(2020, 12, 1),
                HotelName = "Grand Hotel",
                HotelStars = 5,
            });

            trips.AddItem(new Trip("2")
            {
                AptDeparture = "Milano MXP",
                AptArrival = "Roma FCO",
                ArrivalDate = new DateTime(2020, 12, 12),
                Duration = 8,
                DepartureDate = new DateTime(2020, 12, 4),
                HotelName = "Grand Hotel",
                HotelStars = 5,
            });

            trips.AddItem(new Trip("3")
            {
                AptDeparture = "Milano MXP",
                AptArrival = "Roma FCO",
                ArrivalDate = new DateTime(2020, 12, 11),
                Duration = 8,
                DepartureDate = new DateTime(2020, 12, 3),
                HotelName = "Grand Hotel",
                HotelStars = 5,
            });


            trips.AddItem(new Trip("4")
            {
                AptDeparture = "Milano MXP",
                AptArrival = "Roma FCO",
                ArrivalDate = new DateTime(2020, 12, 23),
                Duration = 13,
                DepartureDate = new DateTime(2020, 12, 10),
                HotelName = "Savoia Hotel",
                HotelStars = 3,
            });


            var enumerator = trips.GetEnumerator();
            ShowTrips(enumerator);

            trips.ReverseDirection();
            var enum2 = trips.GetEnumerator();

            ShowTrips(enum2);
        }

        private static void ShowTrips(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                var current = (Trip)enumerator.Current;
                Console.WriteLine($" TRIP {current.ID}: {current.AptDeparture} to {current.AptArrival} in {current.HotelName} for {current.Duration} days");
            }
        }

    }
}

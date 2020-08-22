using System;
using System.Collections.Generic;

namespace Observer
{
    public class DatabaseSubject : ISubject
    {
        private string[] aptArrivals = new string[12] { "Ibiza", "Milano", "Mosca", "Roma", "Catania", "Malè", "Vienna", "Torino", "Verona", "Madrid", "Barcellona", "Parigi" };
        private string[] HotelNames = new string[7] { "Grand Hotel", "Excelsior", "Holiday hin", "Savoy hotel", "Motel", "Hotel o mare", "Voi hotel" };
        private List<IObserver> observers = new List<IObserver>();

        public List<Trip> Trips { get; set; }

        public DatabaseSubject()
        {
            this.Trips = new List<Trip>();
        }
        public void Attach(IObserver observer)
        {
            if (observers.IndexOf(observer) == -1)
                observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (observers.IndexOf(observer) > 0)
                observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var obs in observers)
            {
                obs.Update(this);
            }
        }

        public void LoadRandomTrips()
        {
            int tripsCount = new Random().Next(5, 20);

            for (int i = 0; i < tripsCount; i++)
            {
                var depDate = RandomDate();
                var duration = 7 + new Random().Next(0, 4);
                Trips.Add(new Trip(new Random().Next(1000, 9999).ToString())
                {
                    AptArrival = RandomApt(),
                    AptDeparture = RandomApt(),
                    Duration = duration,
                    HotelStars = new Random().Next(3, 5),
                    DepartureDate = depDate,
                    ArrivalDate = depDate.AddDays(duration),
                    HotelName = HotelNames[new Random().Next(0, HotelNames.Length)],
                });
            }
            this.Notify();
        }

        private string RandomApt()
        {
            return aptArrivals[new Random().Next(0, aptArrivals.Length)];
        }

        private DateTime RandomDate()
        {
            return DateTime.Now.AddDays(new Random().Next(10, 25));
        }



    }
}
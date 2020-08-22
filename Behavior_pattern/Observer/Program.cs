using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var databaseSubject = new DatabaseSubject();
            var desktopObs = new DesktopWebPageObserver();
            var mobileApObs = new MobileAppObserver();

            databaseSubject.Attach(desktopObs);
            databaseSubject.Attach(mobileApObs);

            databaseSubject.LoadRandomTrips();

            Console.WriteLine("Detaching Desktop Web Page Observer ------- \n");
            databaseSubject.Detach(desktopObs);
            databaseSubject.LoadRandomTrips();

            Console.ReadKey();

        }
    }
}

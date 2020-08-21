using System;
using System.Collections.Generic;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator(new SessionState()
            {
                CurrenteUrlWebpage = "alpitour.it",
                PagesVisited = 1,
                SessionId = 84713,
                UrlHistory = new List<string>()
            });

            CareTaker caretaker = new CareTaker(originator);

            caretaker.PushMemento("session1");
            originator.AddPageVisited("alpitour.it/offerte");

            Console.WriteLine("---------------------------------");
            caretaker.ShowHistory();

            caretaker.PushMemento("session2");
            originator.AddPageVisited("alpitour.it/last-minute");

            Console.WriteLine("---------------------------------");
            caretaker.ShowHistory();

            caretaker.PushMemento("session3");
            originator.AddPageVisited("alpitour.it/traghetti");

            Console.WriteLine("---------------------------------");
            caretaker.ShowHistory();
            Console.WriteLine();

            Console.WriteLine("\n Now, let's rollback!\n");
            caretaker.PopMemento("session3");
            caretaker.ShowHistory();
            Console.WriteLine("---------------------------------");


            Console.WriteLine("\n Once more!\n");
            caretaker.PopMemento("session2");
            caretaker.ShowHistory();
            Console.WriteLine("---------------------------------");


            Console.ReadKey();
        }
    }
}

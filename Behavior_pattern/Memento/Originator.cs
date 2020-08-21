using System;

namespace Memento
{
    public class Originator
    {
        public SessionState _session;

        public Originator(SessionState sessionState)
        {
            _session = sessionState;
            Console.WriteLine($"my initial state was \n SessionId:{_session.SessionId} \n \t CurrentUrlWebpage: {_session.CurrenteUrlWebpage} \n \t PageVisited: {_session.PagesVisited.ToString()}");
        }

        public void AddPageVisited(string pageURL)
        {
            this._session.PagesVisited += 1;
            this._session.UrlHistory.Add(pageURL);
            this._session.CurrenteUrlWebpage = pageURL;
        }


        public IMemento SaveMemento(string name)
        {
            return new ConcreteMemento(name, this._session);
        }

        public void RestoreMemento(IMemento memento)
        {
             if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._session = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_session.SessionId}-{_session.CurrenteUrlWebpage}-{_session.PagesVisited.ToString()}");
        }

    }
}
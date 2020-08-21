using System;
using System.Collections;
using System.Collections.Generic;

namespace Memento
{
    public class CareTaker
    {
        private Dictionary<string, IMemento> mementoHistory = new Dictionary<string, IMemento>();

        private Originator _originator;
        public CareTaker(Originator originator)
        {
            this._originator = originator;
        }

        public void PushMemento(string backupName)
        {
            Console.WriteLine($"Pushing memento {backupName}");
            var memento = _originator.SaveMemento(backupName);
            mementoHistory.Add(backupName, memento);
        }


        public IMemento PopMemento(string backupName)
        {
            if (this.mementoHistory == null || this.mementoHistory.Count == 0)
                return null;

            var lastMemento = this.mementoHistory[backupName];

            Console.WriteLine($"Restoring memento: {lastMemento.GetName()}");
            _originator.RestoreMemento(lastMemento);
            mementoHistory.Remove(backupName);

            return lastMemento;
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this.mementoHistory.Values)
            {
                Console.WriteLine($"memento: {memento.GetName()} - currentpage: {memento.GetState().CurrenteUrlWebpage }");
                foreach (var item in memento.GetState().UrlHistory)
                {
                    Console.WriteLine($"Url History: {item}");

                }

            }
        }


    }
}
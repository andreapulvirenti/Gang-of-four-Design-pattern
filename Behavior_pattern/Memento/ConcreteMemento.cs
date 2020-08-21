using System;


namespace Memento
{
    public class ConcreteMemento : IMemento
    {
        private string _name;
        private SessionState _state;
        private DateTime creationDate;
        public ConcreteMemento(string name, SessionState state)
        {
            _name = name;
            _state = state;
            
        }

        public string GetName()
        {
            return this._name;
        }
        public SessionState GetState()
        {
            creationDate = DateTime.Now;
            return this._state;
        }
        public DateTime GetDate()
        {
            return creationDate;
        }
    }
}
using System;

namespace Memento
{
    public interface IMemento
    {
        string GetName();
        SessionState GetState();

        DateTime GetDate();
    }
}
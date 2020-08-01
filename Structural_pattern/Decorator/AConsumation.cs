
using System;

namespace Decorator
{
    public abstract class AConsumation
    {
        private string _name;
        public abstract string GetName();

        public abstract int GetPrice();
    }
}
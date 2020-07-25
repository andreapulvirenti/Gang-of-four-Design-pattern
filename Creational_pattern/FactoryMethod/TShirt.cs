using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class TShirt : IDress
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }

        private List<Components.IComponent> _components = new List<Components.IComponent>();
        public List<Components.IComponent> Components
        {
            get
            {
                return _components;
            }
        }

        public TShirt()
        {
            this.CreateDress();
        }

        public abstract void CreateDress();
    }
}
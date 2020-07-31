using System;
using System.Collections.Generic;

namespace Composite
{
    public class Device : AComponent
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private List<AComponent> Components;
        public Device(string name)
        {
            this._name = name;
            this.Components = new List<AComponent>();
        }

        public override void Add(AComponent component)
        {
            this.Components.Add(component);
        }

        public override bool Remove(AComponent component)
        {
            return this.Components.Remove(component);
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override string ShowComponents()
        {
            var childsString = "";
            var result = "";
            foreach (var item in this.Components)
            {
                childsString = item.IsComposite()? "--" : "";
                result += $"{childsString} {item.ShowComponents()} \n";
            }
            return result;
        }
    }
}
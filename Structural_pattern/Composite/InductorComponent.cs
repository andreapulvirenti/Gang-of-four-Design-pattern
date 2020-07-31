using System;

namespace Composite
{
    public class InductorComponent : AComponent
    {
        private string _name;

        public InductorComponent(string name)
        {
            this._name = name;
        }

        public override bool IsComposite()
        {
            return false;
        }
        public override void Add(AComponent component)
        {
            throw new System.Exception("cannot add component to inductor");
        }
        public override bool Remove(AComponent component)
        {
            throw new System.Exception("cannot remove component to inductor");

        }

          public override string ShowComponents(){
           return $"This is the inductor {this._name}";
        }
    }
}
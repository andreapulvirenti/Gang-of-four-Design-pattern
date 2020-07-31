using System;
namespace Composite
{
    public class TransistorComponent : AComponent
    {

        private string _name ;

        public TransistorComponent(string name) {
            this._name = name;
        }

        public override void Add(AComponent component){
            throw new System.Exception("Cannot add Component to a transistor");
        }

        public override bool Remove(AComponent component){
            throw new System.Exception("Cannot remove Component to a transistor");
        }

        public override string ShowComponents(){
            return $"This is the transistor {this._name}";
        }

        public override bool IsComposite(){
            return false;
        }
        
    }
}
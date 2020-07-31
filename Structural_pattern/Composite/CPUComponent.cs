using System;

namespace Composite
{
    public class CPUComponent : AComponent
    {
        private string _name;

        public CPUComponent(string name){
            this._name = name;
        }   

        public override string  ShowComponents(){
            return $"This is the CPU Component";
        }

        public override void Add(AComponent component){
            throw new Exception($"Cannot add component to a leaf component");
        }

        public override bool Remove(AComponent component){
            throw new Exception($"Cannot remove component to a leaf component");
        }

        public override bool IsComposite(){
            return false;
        }


    }
}
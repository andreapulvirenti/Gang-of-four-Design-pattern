namespace Decorator
{
    public class ExtraKetchupDecorator : AExtraAdditionDecorator
    {
        // private AConsumation consumation;
        public ExtraKetchupDecorator(AConsumation consumation){
            this.consumation = consumation;
        }

        public override int GetPrice(){
            return this.consumation.GetPrice() +1;
        }

        public override string GetName(){
            return this.consumation.GetName() + " with Extra Ketchup";
            
        }
    }
}
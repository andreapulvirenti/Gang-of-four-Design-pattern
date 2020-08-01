namespace Decorator
{
    public class ExtraCheeseDecorator : AExtraAdditionDecorator
    {
        private AConsumation consumation {get;}
        public ExtraCheeseDecorator(AConsumation consumation){
            this.consumation = consumation;
        }

        public override string GetName(){
            return this.consumation.GetName() + " With Extracheese!!";
        }

        public override int GetPrice() {
            return this.consumation.GetPrice() +  2 ; 
        }

    }
}
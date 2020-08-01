namespace Decorator
{
    public class Cheeseburger : AConsumation
    {
        private string _productName;
        public override string GetName(){
            return _productName;
        }
        public Cheeseburger(){
             this._productName = "CheeseBurger";
        }

        public override int GetPrice(){
            return 5;
        }
        
    }
}
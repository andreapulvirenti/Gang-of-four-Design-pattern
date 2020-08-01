namespace Decorator
{  public class Hamburger : AConsumation
    {
         private string _productName;
      
        public Hamburger(){
             this._productName = "Hamburger";
        }

         public override string GetName(){
            return _productName;
        }
        public override int GetPrice(){
            return 4;
        }
        
    }
}
using AbstractFactory.FamilyProductB;

namespace AbstractFactory
{
    public class ConcreteFactoryB : AbstractFactory
    {
        public override IShape GetShape(string shape){
            if (string.IsNullOrEmpty(shape))
                 return null;

            if(shape.ToUpper().Equals("RECTANGLE"))
                return new RoundedRectangle();
            
            if(shape.ToUpper() == "SQUARE"){
                return new Square();
            }
            
            throw new System.Exception("No shape found");
        }


    }
}
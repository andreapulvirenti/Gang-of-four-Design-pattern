using AbstractFactory.FamilyProductA;

namespace AbstractFactory
{
    public class ConcreteFactoryA : AbstractFactory
    {
        public override IShape GetShape(string shape){
            if (string.IsNullOrEmpty(shape))
                 return null;

            
            if(shape.ToUpper().Equals("RECTANGLE"))
                return new Rectangle();
            
            if(shape.ToUpper() == "SQUARE"){
                return new Square();
            }

            throw new System.Exception("No shape found");
        }


    }
}
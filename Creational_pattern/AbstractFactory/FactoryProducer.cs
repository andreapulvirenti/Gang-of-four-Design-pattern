namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string ProductFamily)
        {
            if (ProductFamily == "A")
                return new ConcreteFactoryA();
            else
                return new ConcreteFactoryB();
        }
    }
}
namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shape);
    }
}
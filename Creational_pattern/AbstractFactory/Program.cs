using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factoryProducer = FactoryProducer.GetFactory("B");
            IShape shape1 = factoryProducer.GetShape("RECTANGLE");
            shape1.Draw();

            IShape shape2 = factoryProducer.GetShape("SQUARE");
            shape2.Draw();
            
        }
    }
}

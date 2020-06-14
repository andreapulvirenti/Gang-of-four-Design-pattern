using System;

namespace Build
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBuilder = new ConcreteBuilder();
            Director dir = new Director(myBuilder);

            Console.WriteLine("BUILDING MINIMAL PRODUCT");
            dir.BuildMinimalProduct();
            Console.WriteLine(dir.Builder.GetProduct().ListParts());

            dir.Builder.Reset();

            Console.WriteLine("BUILDING FULL PRODUCT");
            dir.BuildFullProduct();
            Console.WriteLine(dir.Builder.GetProduct().ListParts());

            dir.Builder.Reset();

            Console.WriteLine("BUILDING DELTA PRODUCT");
            dir.BuildPartDelta();
            Console.WriteLine(dir.Builder.GetProduct().ListParts());

        }
    }
}

using System.Collections.Generic;
using System;

namespace FactoryMethod
{
    public class SimpleTShirt : TShirt
    {
        public SimpleTShirt()
        {
        }

        public override void CreateDress()
        {
            Console.WriteLine("I'm creating an amazing simple Tshirt");

            Components.Add(new Components.Sleeves());
            Components.Add(new Components.Neckbend());
        }
    }
}
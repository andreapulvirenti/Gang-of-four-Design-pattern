using System.Collections.Generic;
using System;

namespace FactoryMethod
{
    public class Polo : TShirt
    {
        public Polo()
        {
        }
        public override void CreateDress()
        {
            Console.WriteLine("I'm creating amazing Polo for your golf club");

            this.Components.Add(new Components.Hinge());
            this.Components.Add(new Components.Neckbend());
            this.Components.Add(new Components.Sleeves());
        }
    }
}

using System;

namespace FactoryMethod.Components
{
    public class Hinge : IComponent
    {
        public Hinge (){
            Console.WriteLine("With this Hing you can be cool");
        }
    }
}
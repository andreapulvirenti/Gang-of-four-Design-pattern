
using System;

namespace FactoryMethod.Components
{
    public class Sleeves : IComponent
    {
        public Sleeves(){
            Console.WriteLine("Here's your two sleeves");
        }
    }
}
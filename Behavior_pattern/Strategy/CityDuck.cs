using System;
namespace Strategy
{
    public class CityDuck : Duck
    {
        public CityDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(quackBehavior, flyBehavior)
        {

        }

        public override void Fly()
        {
            Console.WriteLine("i'm the city Duck! ");
            this._flyB.Fly();
        }
    }
}
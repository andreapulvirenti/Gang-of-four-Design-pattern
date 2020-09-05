using System;
namespace Strategy
{
    public class WildDuck : Duck
    {
        public WildDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(quackBehavior, flyBehavior)
        {

        }

        public override void Fly()
        {
            Console.WriteLine("I'm the WILD duck! ");
            this._flyB.Fly();
            this._quackB.Quack();
        }
    }
}
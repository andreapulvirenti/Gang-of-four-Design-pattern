namespace Strategy
{
    public abstract class Duck
    {
        protected IQuackBehavior _quackB;
        protected IFlyBehavior _flyB;

        public Duck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            this._flyB = flyBehavior;
            this._quackB = quackBehavior;
        }

        public abstract void Fly();


    }
}
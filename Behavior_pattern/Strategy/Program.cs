using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck wildDuck = new WildDuck(new FlyBehavior.SpeedFlyBehavior(), new QuackBehavior.LoudQack());
            Duck cityDuck = new CityDuck(new FlyBehavior.SlowFlyVehavior(), new QuackBehavior.LoudQack());
            Duck campaignDuck = new WildDuck(new FlyBehavior.SpeedFlyBehavior(), new QuackBehavior.NoQuack());

            wildDuck.Fly();
            cityDuck.Fly();
            campaignDuck.Fly();

        }
    }
}

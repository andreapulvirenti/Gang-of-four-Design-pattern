using System;
namespace Strategy.FlyBehavior
{
    public class SlowFlyVehavior : IFlyBehavior
    {
        public void Fly(){
            Console.WriteLine("Slow Fly");
        }
    }
}
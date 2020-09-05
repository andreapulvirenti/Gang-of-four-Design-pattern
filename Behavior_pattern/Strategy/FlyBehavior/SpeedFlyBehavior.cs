using System;
namespace Strategy.FlyBehavior
{
    public class SpeedFlyBehavior : IFlyBehavior
    {
        public void Fly(){
            Console.WriteLine("very speed Fly");
        }
    }
}
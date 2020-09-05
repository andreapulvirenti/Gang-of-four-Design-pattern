using System;
namespace Strategy.QuackBehavior
{
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("no Quack");
        }

    }
}
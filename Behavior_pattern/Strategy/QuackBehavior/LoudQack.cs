using System;
namespace Strategy.QuackBehavior
{
    public class LoudQack : IQuackBehavior
    {
        public void Quack(){
            Console.WriteLine("Very Loud Quack");
        }
        
    }
}
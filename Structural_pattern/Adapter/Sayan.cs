using System;
namespace Adapter
{
    public class Sayan : IWarrior
    {
         public const int ATTACK_BASE = 100;
          public int Attack(){
            Console.WriteLine("SAYAN IS ATTACKING");
            return ATTACK_BASE + 120;
        }
    }
}
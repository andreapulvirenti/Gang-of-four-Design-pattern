
using System;

namespace Adapter
{
    public class Namkie : IWarrior
    {
        public const int ATTACK_BASE = 50;
        public int Attack(){
            Console.WriteLine("NAMKIE IS ATTACKING");
            return ATTACK_BASE + 100;
        }
    }
}
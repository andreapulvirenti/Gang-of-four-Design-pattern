
using System;

namespace Adapter
{
    public class Android
    {
        public int ATTACK_BASE =>  40;
        public int Punch(){
            Console.WriteLine("Android Punch");
            return 30;
        }
        public int Kick(){
            Console.WriteLine("Android kick");
            return 50;
        }
    }
}
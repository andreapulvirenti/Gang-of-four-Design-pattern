using System;

namespace Adapter
{
    public class AndroidAdapter : IWarrior
    {
        private Android _android;
        public AndroidAdapter(Android android){
            _android = android;
        }

        public int Attack(){
            Console.WriteLine($"ANDROID IS ATTACKING");
            return _android.ATTACK_BASE
                    + _android.Punch() 
                    + _android.Kick();
        }
    }
}
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ILight light = new Light();
            ILight specialBulbLights = new SpecialBulbLights();

            var lightsInvoker = new LightsInvoker();
            lightsInvoker.AddCommand(new TurnOnCommand(light));
            lightsInvoker.AddCommand(new TurnOnCommand(specialBulbLights));
            lightsInvoker.AddCommand(new ChangeColorCommand(specialBulbLights,"Blue"));
            lightsInvoker.AddCommand(new ChangeColorCommand(light,"Red"));
            lightsInvoker.AddCommand(new TurnOffCommand(light));
            lightsInvoker.AddCommand(new TurnOffCommand(specialBulbLights));

            lightsInvoker.ExecuteCommands();
            lightsInvoker.ResetCommands();

        }
    }
}

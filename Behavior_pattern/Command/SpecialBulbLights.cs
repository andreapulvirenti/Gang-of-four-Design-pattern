using System;

namespace Command
{
    public class SpecialBulbLights : ILight
    {
         public void TurnOn()
        {
            Console.WriteLine($"Turning ON the SPECIAL light");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turning OFF the SPECIAL light");
        }

        public void ChangeColor(string color)
        {
            Console.WriteLine($"Changing the SPECIAL light in {color}");
        }
    }
}
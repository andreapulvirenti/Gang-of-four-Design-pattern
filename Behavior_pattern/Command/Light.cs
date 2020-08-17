
using System;

namespace Command
{
    public class Light : ILight
    {
        public void TurnOn()
        {
            Console.WriteLine($"Turning ON the light");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turning OFF the light");
        }

        public void ChangeColor(string color)
        {
            Console.WriteLine($"Changing the light in {color}");
        }
    }
}
using System;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your slider order (use characters B, V, Z with no spaces):");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            FlyWeightFactory factory = new FlyWeightFactory();

            int orderTotal = 0;

            //Get the slider from the factory
            foreach (char c in chars)
            {
                orderTotal++;
                AFlyweightSlider character = factory.GetSlider(c);
                character.Display(orderTotal);
            }

            Console.ReadKey();
        }
    }
}

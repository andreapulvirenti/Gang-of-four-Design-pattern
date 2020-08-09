using System;
namespace FlyWeight
{
    public class BBQSlider : AFlyweightSlider
    {
        
        public BBQSlider()
        {
            this.Name = "BBQ Slider";
            this.Cheese = "Cheddar";
            this.Toppings = "Onion rings, lettuce, and BBQ sauce";
            Price = 5.51m;
        }
        public override void Display(int orderTotal)
        {
            Console.WriteLine("BBQ Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " + Toppings + "! $" + Price.ToString());
        }
    }
}
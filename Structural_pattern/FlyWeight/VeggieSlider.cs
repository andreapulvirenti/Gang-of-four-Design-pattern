using System;
namespace FlyWeight
{
    public class VeggieSlider : AFlyweightSlider
    {
        
        public VeggieSlider()
        {
            this.Name = "Veggie Slider";
            this.Cheese = "Pecorino";
            this.Toppings = "Lettuce, onion, tomato";
            Price = 5.51m;
        }
        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " + Toppings + "! $" + Price.ToString());
        }
    }
}
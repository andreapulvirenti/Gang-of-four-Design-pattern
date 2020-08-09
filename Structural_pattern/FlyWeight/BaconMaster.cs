using System;

namespace FlyWeight
{
    public class BaconMaster : AFlyweightSlider
    {

        public BaconMaster()
        {
            this.Name = "Bacon Master";
            this.Cheese = "American";
            this.Toppings = "Bacon";
            Price = 4.51m;
        }
        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " + Toppings + "! $" + Price.ToString());
        }
    }
}
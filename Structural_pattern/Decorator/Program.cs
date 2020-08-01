using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            AConsumation hamburger = new Hamburger();
            AConsumation cheeseBurger = new Cheeseburger();

            ShowProduct(hamburger);
            ShowProduct(cheeseBurger);

            var extraCheese = new ExtraCheeseDecorator(cheeseBurger);
            ShowProduct(extraCheese);

            var extraKetchupBurget = new ExtraKetchupDecorator(hamburger);
            ShowProduct(extraKetchupBurget);

            Console.ReadLine();
        }

        private static void ShowProduct(AConsumation consumation){
            Console.WriteLine($"Consumazione: {consumation.GetName()} - Prezzo: {consumation.GetPrice()}");
        }
    }
}

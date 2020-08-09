namespace FlyWeight
{
    public  abstract class AFlyweightSlider
    {
        protected string Name;
        protected string Cheese;

        protected string Toppings;
        protected decimal Price;

        public abstract void Display(int orderTotal);

    }
}
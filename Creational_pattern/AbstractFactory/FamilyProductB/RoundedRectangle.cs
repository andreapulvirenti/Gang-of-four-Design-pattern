using System;

namespace AbstractFactory.FamilyProductB
{
    public class RoundedRectangle : IShape
    {
        public void Draw(){
            Console.WriteLine("Rounded rectangle B");
        }        
    }
}
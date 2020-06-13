using System;

namespace AbstractFactory.FamilyProductA
{
    public class RoundedRectangle : IShape
    {
        public void Draw(){
            Console.WriteLine("Rounded rectangle");
        }        
    }
}
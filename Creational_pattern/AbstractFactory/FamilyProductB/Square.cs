using System;

namespace AbstractFactory.FamilyProductB
{
    public class Square : IShape
    {
        public void Draw(){
            Console.WriteLine("Drawn Square B");
        }        
    }
}
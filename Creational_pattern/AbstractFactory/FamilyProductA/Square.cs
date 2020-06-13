using System;

namespace AbstractFactory.FamilyProductA
{
    public class Square : IShape
    {
        public void Draw(){
            Console.WriteLine("Drawn Square A");
        }        
    }
}
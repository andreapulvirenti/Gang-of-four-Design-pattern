
using System;

namespace AbstractFactory.FamilyProductB
{
    public class Rectangle : IShape
    {
        public void Draw(){
          Console.WriteLine("Hello Rectangle B");
        }
    }
}
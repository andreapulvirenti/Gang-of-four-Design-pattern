
using System;

namespace AbstractFactory.FamilyProductA
{
    public class Rectangle : IShape
    {
        public void Draw(){
          Console.WriteLine("Hello Rectangle A");
        }
    }
}
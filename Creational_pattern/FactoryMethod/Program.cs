using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TShirt> tshirts = new List<TShirt>();
            Console.WriteLine("Creating tshirts");
            tshirts.Add(new SimpleTShirt());
            tshirts.Add(new Polo());
            Console.WriteLine("Creation ends!!");

            Console.ReadKey();
        }
    }
}

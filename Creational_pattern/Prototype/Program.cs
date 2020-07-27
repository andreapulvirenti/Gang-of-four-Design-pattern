using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Age = 42;
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            Person p2 = p1.ShallowClone();
            Person p3 = p1.DeppCopy();
            // Display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.Age = 32;
            p1.Name = "Frank";
            p1.IdInfo.Id = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}",
                p.Name, p.Age);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.Id);
        }

    }
}

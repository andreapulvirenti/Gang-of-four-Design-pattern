using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AComponent smartphone = new Device("Smartphone");
            // AComponent smartphone = new Device("smartphone");

            smartphone.Add(new CPUComponent("CPU"));
            smartphone.Add(new TransistorComponent("Transistor1"));
            smartphone.Add(new TransistorComponent("Transistor2"));

            var RAM = new Device("RAM");
            RAM.Add(new TransistorComponent("TransistorRAM1"));
            RAM.Add(new InductorComponent("inductorRAM1"));

            smartphone.Add(RAM);


            Console.WriteLine(smartphone.ShowComponents());

        }
    }
}

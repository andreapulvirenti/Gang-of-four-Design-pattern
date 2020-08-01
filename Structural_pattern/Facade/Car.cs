using System;
namespace Facade
{
    public class Car : IVehicle
    {
        public Car(IEngine engine)
        {
            this.Engine = engine;
        }
        public string Accessories { get; set; }
        public IEngine Engine { get; set; }
        public int WheelsNum { get; set; }

        public void Move()
        {
            if (!this.Engine.Status)
            {
                this.Engine.TurnOn();
            }
            if (VehicleCheck.CheckWheels(this))
                Console.WriteLine("The car is moving");
        }
    }
}
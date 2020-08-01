using System;

namespace Facade
{
    public class PickUp : IVehicle, IJumpable
    {
        public PickUp(IEngine engine) 
        {
            this.Engine = engine;
        }
        public IEngine Engine { get; set; }
        public int WheelsNum { get; set; }
        public string Accessories {get; set;}
        public void Move()
        {
            if (!this.Engine.Status)
            {
                this.Engine.TurnOn();
            }
            if (VehicleCheck.CheckWheels(this))
                Console.WriteLine("The pickup is moving");
        }

        public void Jump()
        {
            if (!this.Engine.Status)
            {
                this.Engine.TurnOn();

            }
            Console.WriteLine("The pickup is jumping");
        }
    }
}
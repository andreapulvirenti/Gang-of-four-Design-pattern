using System;
namespace Facade
{
    public class Facade
    {

        public void MoveVehicle(string vehicleType)
        {
            IVehicle vehicle;
            Console.WriteLine("MOVE VEHICLE STARTED");
            switch (vehicleType)
            {
                case "REGULAR":
                    vehicle = new Car(new CombustionEngine(16));
                    break;
                case "PICKUP":
                    vehicle = new PickUp(new CombustionEngine(16));
                    break;
                case "REGULARHYDROGEN":
                    vehicle = new Car(new HydrogenEngine());
                    break;
                case "PICKUPHYDROGEN":
                    vehicle = new PickUp(new HydrogenEngine());
                    break;
                default:
                    vehicle = new Car(new CombustionEngine(16));
                    break;
            }
        
            VehicleAccessories va = new VehicleAccessories(vehicle);
            va.SetAccessories();
            vehicle.WheelsNum = 4;
            vehicle.Move();

        

        }
    }
}
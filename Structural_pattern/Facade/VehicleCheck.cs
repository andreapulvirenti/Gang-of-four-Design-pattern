namespace Facade
{
    public static class VehicleCheck
    {
        public static bool CheckKeysInserted(IVehicle vehicle){
            return true;
        }

         public static bool CheckWheels(IVehicle vehicle){
            if(vehicle.WheelsNum <4)
                throw new System.Exception("HEY YOU LOST ONE OR MORE WHEELS!");
            return true;
        }
    }
}
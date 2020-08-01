namespace Facade
{
    public class VehicleAccessories
    {
        private IVehicle _vehicle;
        public VehicleAccessories(IVehicle vehicle)
        {
            this._vehicle = vehicle;

        }

        public void SetAccessories()
        {
             this._vehicle.Accessories = "Great Accessories"!;
        }
    }
}
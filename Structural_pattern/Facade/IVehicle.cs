namespace Facade
{
    public interface IVehicle
    {
        int WheelsNum { get; set; }
        string Accessories {get; set;}
        IEngine Engine { get; set; }
        void Move();
    }
}
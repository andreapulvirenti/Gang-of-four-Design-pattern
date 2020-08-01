namespace Facade
{
    public interface IEngine
    {
        bool Status { get; set; }

        string EngineType { get; set; }

        int RoundPerMin {get; }
        void TurnOn();
        

    }
}
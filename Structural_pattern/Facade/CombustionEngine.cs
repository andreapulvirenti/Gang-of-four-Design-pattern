using System;

namespace Facade
{
    public class CombustionEngine : IEngine
    {
        private int _cylinders;
        public CombustionEngine(int cylinders)
        {
            this._cylinders = cylinders;
            this.Status = false;
            this.EngineType = "Combustion";
            this.RoundPerMin = 0;
        }

        public bool Status { get; set; }
        public string EngineType { get; set; }
        public int RoundPerMin { get; set; }
        public void TurnOn(){
            this.RoundPerMin = 2000;
            this.Status = true;
            Console.WriteLine("CombustionEngine is turned on");
        }

    }
}
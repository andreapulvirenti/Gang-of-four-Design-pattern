using System;
namespace Facade
{
    public class HydrogenEngine : IEngine
    {
        public HydrogenEngine()
        {
            this.Status = false;
            this.EngineType = "Hydrogen";
            this.RoundPerMin = 0;
        }

        public bool Status { get; set; }
        public string EngineType { get; set; }

        private int defaultRound = 200;
        public int RoundPerMin
        {
            get
            {
                if (StaticUtility.UtilityOperation())
                    defaultRound = 50;
                return defaultRound;
            }
            set
            {
                defaultRound = value;
            }
        }
        public void TurnOn()
        {
            this.RoundPerMin = 2000;
            this.Status = true;
            Console.WriteLine(GetElectricity());
            Console.WriteLine("Hydrogen engine is turned on");
        }


        private string GetElectricity()
        {
            return "Get Electricity power";
        }

    }
}
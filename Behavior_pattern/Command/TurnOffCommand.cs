using System;
using System.Collections.Generic;

namespace Command
{
    public class TurnOffCommand : ICommand
    {
        private ILight _light;
        public TurnOffCommand(ILight light)
        {
            this._light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
        public void UnExecute()
        {
            _light.TurnOn();

        }
    }
}
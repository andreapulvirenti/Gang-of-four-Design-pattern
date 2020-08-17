namespace Command
{
    public class TurnOnCommand : ICommand
    {
        private ILight _light;
        public TurnOnCommand(ILight light)
        {
            this._light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
        public void UnExecute()
        {
            _light.TurnOff();

        }
    }
}
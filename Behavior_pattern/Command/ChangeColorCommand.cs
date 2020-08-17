using System;
namespace Command
{
    public class ChangeColorCommand : ICommand
    {
        private ILight _light;
        private string _color;
        private string _prevColor;

        public ChangeColorCommand(ILight light, string color)
        {
            this._light = light;
            this._prevColor = this._color;
            this._color = color;
        }

        public void Execute()
        {
            _light.ChangeColor(this._color);
        }
        public void UnExecute()
        {
            _light.ChangeColor(this._prevColor);

        }
    }
}
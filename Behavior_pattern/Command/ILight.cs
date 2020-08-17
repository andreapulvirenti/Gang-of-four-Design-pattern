namespace Command
{
    public interface ILight
    {
        void TurnOn();
        void TurnOff();
        void ChangeColor(string color);

    }
}
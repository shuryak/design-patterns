namespace DesignPatterns.Structural.Bridge.BridgeEnds
{
    public class Tv : IDevice
    {
        public bool IsEnabled { get; private set; }
        public int Volume { get; private set; }

        public string TogglePower()
        {
            IsEnabled = !IsEnabled;
            return "TV is " + (IsEnabled ? "on" : "off");
        }

        public string SetVolume(int percent)
        {
            Volume = percent;
            return "TV volume is set to " + Volume;
        }
    }
}

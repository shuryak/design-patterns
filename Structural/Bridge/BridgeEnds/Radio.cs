namespace DesignPatterns.Structural.Bridge.BridgeEnds
{
    public class Radio : IDevice
    {
        public bool IsEnabled { get; private set; }
        public int Volume { get; private set; }

        public string TogglePower()
        {
            IsEnabled = !IsEnabled;
            return "Radio is " + (IsEnabled ? "on" : "off");
        }

        public string SetVolume(int percent)
        {
            Volume = percent;
            return "Radio volume is set to " + Volume;
        }
    }
}

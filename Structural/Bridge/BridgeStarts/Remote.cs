namespace DesignPatterns.Structural.Bridge.BridgeStarts
{
    public class Remote
    {
        protected readonly IDevice Device;

        public Remote(IDevice device)
        {
            Device = device;
        }

        public string TogglePower()
        {
            return Device.TogglePower();
        }

        public string VolumeUp()
        {
            return Device.SetVolume(Device.Volume + 10);
        }
        
        public string VolumeDown()
        {
            return Device.SetVolume(Device.Volume - 10);
        }
    }
}

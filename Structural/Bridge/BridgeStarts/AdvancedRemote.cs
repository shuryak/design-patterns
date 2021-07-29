namespace DesignPatterns.Structural.Bridge.BridgeStarts
{
    // Refined abstraction
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public string Mute()
        {
            return Device.SetVolume(0);
        }
    }
}

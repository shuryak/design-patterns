namespace DesignPatterns.Structural.Bridge
{
    public interface IDevice
    {
        bool IsEnabled { get; }
        int Volume { get; }
        string TogglePower();
        string SetVolume(int percent);
    }
}

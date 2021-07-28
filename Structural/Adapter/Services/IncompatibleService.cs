namespace DesignPatterns.Structural.Adapter.Services
{
    // Adaptee (right logic, but wrong interface)
    public class IncompatibleService
    {
        public string GetSpecificRequest()
        {
            return "Specific request";
        }
    }
}

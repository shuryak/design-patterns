using DesignPatterns.Structural.Adapter.Abstractions;

namespace DesignPatterns.Structural.Adapter.Services
{
    public class StandardService : ITarget
    {
        public string GetRequest()
        {
            return "This is Standard request";
        }
    }
}

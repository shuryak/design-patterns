using Adapter.Abstractions;

namespace Adapter.Services
{
    public class StandardService : ITarget
    {
        public string GetRequest()
        {
            return "This is Standard request";
        }
    }
}

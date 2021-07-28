using Adapter.Abstractions;
using Adapter.Services;

namespace Adapter
{
    /*
     * Adapter provides cooperation between classes with different interfaces
     */
    public class Adapter : ITarget
    {
        private readonly IncompatibleService _service;

        public Adapter(IncompatibleService service)
        {
            _service = service;
        }

        public string GetRequest()
        {
            return "This is " + _service.GetSpecificRequest();
        }
    }
}

using System.Collections;

namespace DesignPatterns.Behavioral.Iterator.Abstractions
{
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}

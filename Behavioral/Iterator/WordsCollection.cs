using System.Collections;
using System.Collections.Generic;
using DesignPatterns.Behavioral.Iterator.Abstractions;

namespace DesignPatterns.Behavioral.Iterator
{
    public class WordsCollection : IteratorAggregate
    {
        private readonly List<string> _collection = new List<string>();

        private bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> GetItems()
        {
            return _collection;
        }

        public void AddItem(string item)
        {
            _collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
